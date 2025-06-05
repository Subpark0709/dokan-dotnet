using DokanNet;
using DokanNet.Logging; // ConsoleLogger 및 ILogger를 위해 필요
using System;
using System.Threading;
using VirtualJsonDrive; // VirtualJsonOperations가 있는 네임스페이스

namespace VirtualJsonDriveApp
{
    /// <summary>
    /// 가상 JSON 드라이브를 마운트하고 실행하는 주 프로그램입니다.
    /// </summary>
    class Program
    {
        private static readonly string MountPoint = "M:\\"; // 원하는 드라이브 문자 또는 경로
        private static readonly ManualResetEventSlim UnmountEvent = new ManualResetEventSlim(false); // 프로그램 종료 동기화를 위한 이벤트

        /// <summary>
        /// 애플리케이션의 주 진입점입니다.
        /// </summary>
        /// <param name="args">명령줄 인수입니다.</param>
        static void Main(string[] args)
        {
            // Dokan 로거 설정 (콘솔에 출력)
            var logger = new ConsoleLogger("[VirtualJsonDrive] ");

            try
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 가상 JSON 드라이브 마운트를 시도합니다: {MountPoint}");

                // VirtualJsonOperations 인스턴스 생성 (생성자에서 JSON 로드)
                var operations = new VirtualJsonOperations();

                // Dokan 객체 생성 (로거 전달)
                var dokan = new Dokan(logger);

                // DokanInstanceBuilder를 사용하여 DokanInstance 구성
                var dokanBuilder = new DokanInstanceBuilder(dokan) // Dokan 객체를 생성자에 전달
                    .ConfigureOptions(options =>
                    {
                        options.MountPoint = MountPoint;
                        options.Options = DokanOptions.DebugMode |       // 상세 디버그 메시지
                                          DokanOptions.StderrOutput |    // 표준 오류 스트림으로 출력
                                          DokanOptions.RemovableDrive |  // 이동식 드라이브로 표시
                                          DokanOptions.MountManager |    // Windows 탑재 관리자 사용
                                          DokanOptions.CurrentSession;   // 현재 사용자 세션에만 마운트
                        // options.ThreadCount는 DokanOptions에 직접 설정하는 멤버가 아님.
                        // options.Timeout도 DokanOptions에 직접 설정하는 멤버가 아님.
                        // 스레드 수와 타임아웃은 Dokan.Mount의 오버로드를 사용하거나,
                        // DokanInstance를 사용할 경우 Mount() 호출 시 내부 기본값 또는 다른 방식으로 설정됨.
                        // 필요하다면 DokanNet 문서를 참조하여 고급 설정을 적용해야 함.
                        // 현재는 기본값을 사용하도록 이 라인들을 제거하거나 주석 처리.
                    })
                    .ConfigureLogger(() => logger); // 로거 설정
                    // .ConfigureSerializer(s => {}); // 직렬화 관련 설정이 필요하다면 여기에 추가

                // DokanInstance 빌드
                using (var dokanInstance = dokanBuilder.Build(operations))
                {
                    // 마운트 및 언마운트 이벤트 핸들러 설정
                    dokanInstance.Mounted += (sender, eventArgs) =>
                    {
                        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 성공적으로 마운트됨: {eventArgs.MountPoint}");
                    };
                    dokanInstance.Unmounted += (sender, eventArgs) =>
                    {
                        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 마운트 해제됨 ({eventArgs.MountPoint})");
                        UnmountEvent.Set(); // 프로그램 종료를 위한 신호 발생
                    };
                    // 파일 시스템 예외 이벤트 핸들러 (선택 사항)
                    // DokanNet 2.x 에서는 FileSystemException 이벤트가 더 일반적입니다.
                    dokanInstance.FileSystemException += (sender, errorEventArgs) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Error.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Dokan 파일 시스템 오류: {errorEventArgs.ErrorException.Message} (파일: {errorEventArgs.FileName}, 작업: {errorEventArgs.Operation})");
                        Console.ResetColor();
                    };


                    // Ctrl+C (SIGINT) 및 콘솔 종료 이벤트 처리기 설정
                    Console.CancelKeyPress += (sender, eventArgs) =>
                    {
                        eventArgs.Cancel = true; // 기본 종료 동작 방지
                        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 애플리케이션 종료 요청 수신, 언마운트 시도...");
                        try
                        {
                            dokanInstance.Unmount(); // DokanInstance를 통해 마운트 해제
                        }
                        catch (DokanException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Error.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 언마운트 중 Dokan 오류 발생: {ex.Message}");
                            Console.ResetColor();
                            UnmountEvent.Set(); // 오류 발생 시에도 종료 이벤트 설정
                        }
                    };

                    // 파일 시스템 마운트 실행
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {MountPoint} 에 드라이브 마운트 중...");
                    dokanInstance.Mount(); // 이 메서드는 마운트가 해제될 때까지 현재 스레드를 차단합니다.

                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] '{MountPoint}' 드라이브 사용 가능해야 합니다. (Mounted 이벤트 대기 중)");

                    // UnmountEvent가 설정될 때까지 (즉, 언마운트될 때까지) 대기
                    UnmountEvent.Wait(); // WaitOne 대신 Wait 사용
                } // using 블록 종료 시 dokanInstance.Dispose() 자동 호출 (IDisposable 구현)
            }
            catch (DokanException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Dokan 초기화 또는 마운트 오류 발생: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.Error.WriteLine($"    내부 예외: {ex.InnerException.Message}");
                }
                Console.ResetColor();
                Console.WriteLine("오류로 인해 마운트하지 못했습니다. Dokan 드라이버가 설치되어 있고 최신 버전인지 확인하세요.");
                Console.WriteLine("Dokan 설치 경로 예시: C:\\Program Files\\Dokan\\Dokan Library-2.X.X");
                Console.WriteLine("DokanCoreX.dll, DokanNet.dll 파일이 실행 파일과 같은 디렉터리에 있거나 시스템 경로에 등록되어 있어야 합니다.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 일반 오류 발생: {ex.Message}");
                if (ex.StackTrace != null)
                {
                     Console.Error.WriteLine($"    스택 트레이스: {ex.StackTrace}");
                }
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 애플리케이션을 종료합니다. {MountPoint} 드라이브가 언마운트되었는지 확인하세요.");
            }
        }
    }
}
