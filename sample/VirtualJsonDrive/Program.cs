using DokanNet;
using DokanNet.Logging;
using System;
using System.Threading;
using VirtualJsonDrive; // FileSystemOperations 및 FileSystemLoader가 있는 네임스페이스

namespace VirtualJsonDriveApp
{
    /// <summary>
    /// 가상 JSON 드라이브를 마운트하고 실행하는 주 프로그램입니다.
    /// </summary>
    class Program
    {
        private static readonly string MountPoint = "M:\\"; // 원하는 드라이브 문자 또는 경로
        private static ManualResetEventSlim unmountEvent = new ManualResetEventSlim(false);

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

                // Dokan 마운트 옵션 설정
                // DokanOptions.DebugMode: 상세한 디버그 메시지를 Dokan 라이브러리에서 출력합니다.
                // DokanOptions.StderrOutput: 오류 메시지를 표준 오류 스트림으로 보냅니다.
                // DokanOptions.RemovableDrive: 드라이브를 이동식 드라이브로 표시합니다.
                // DokanOptions.MountManager: Windows 탑재 관리자를 사용하여 드라이브 문자를 할당합니다. (더 안정적일 수 있음)
                // DokanOptions.CurrentSession: 현재 사용자 세션에만 드라이브를 마운트합니다.
                DokanOptions mountOptions = DokanOptions.DebugMode | DokanOptions.StderrOutput | DokanOptions.RemovableDrive | DokanOptions.MountManager | DokanOptions.CurrentSession;

                // 스레드 수: 0 또는 1로 설정하면 단일 스레드로 Dokan 처리,
                // 더 높은 값은 병렬 처리를 위해 여러 스레드를 사용 (기본값은 5).
                // FileSystemOperations의 동시성 처리가 준비되지 않았다면 1로 시작하는 것이 안전할 수 있습니다.
                int threadCount = 1;

                // Dokan 인스턴스 생성 및 마운트
                // Mount 메서드는 마운트가 해제될 때까지 현재 스레드를 차단합니다.
                // 별도 스레드에서 마운트하려면 Task.Run 등을 사용할 수 있습니다.
                // Timeout 값을 설정하여 마운트 시도 시간을 제한할 수 있습니다. (예: TimeSpan.FromSeconds(30))

                // Unmount 이벤트 핸들러 등록
                Console.CancelKeyPress += (sender, e) =>
                {
                    e.Cancel = true; // 기본 Ctrl+C 종료 방지
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 애플리케이션 종료 요청 수신, 언마운트 시도...");
                    Dokan.Unmount(MountPoint[0]); // 드라이브 문자만 전달
                };

                // Dokan.Mount는 차단 호출이므로, 애플리케이션이 여기서 대기하게 됩니다.
                // 사용자가 Ctrl+C를 누르거나 다른 방식으로 마운트가 해제될 때까지 실행됩니다.
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {MountPoint} 에 드라이브 마운트 중... Ctrl+C를 눌러 종료합니다.");

                // Mount 메서드는 성공 시 차단하고, 마운트 해제 시 반환하거나 예외 발생 시 즉시 반환합니다.
                // Dokan.Mount()의 마지막 인자는 timeout 입니다.
                // Version 2.x 에서는 DokanInstance 사용을 권장합니다.
                // new Dokan(logger).Mount(operations, MountPoint, mountOptions, threadCount, null, TimeSpan.FromSeconds(30));
                // 하지만 DokanInstance를 사용하면 Unmount 시그널 처리가 더 명확해집니다.

                using (var dokanInstance = new DokanInstance(logger, MountPoint))
                {
                    dokanInstance.Mounted += () => Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {MountPoint} 에 성공적으로 마운트되었습니다.");
                    dokanInstance.Unmounted += () =>
                    {
                        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {MountPoint} 에서 성공적으로 언마운트되었습니다.");
                        unmountEvent.Set(); // 언마운트 이벤트 발생시켜 Main 스레드 종료 허용
                    };

                    // Mount 메서드 호출 (비동기적으로 처리되지 않음, 이 스레드를 차단)
                    dokanInstance.Mount(operations, mountOptions, threadCount);

                    // Mount가 반환되면 (일반적으로 Unmount 후), 프로그램 종료를 위해 대기
                    // 또는 Ctrl+C 핸들러가 unmountEvent를 설정할 때까지 대기
                    unmountEvent.Wait();
                }

            }
            catch (DokanException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Dokan 오류 발생: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.Error.WriteLine($"    내부 예외: {ex.InnerException.Message}");
                }
                Console.ResetColor();
                Console.WriteLine("오류로 인해 마운트하지 못했습니다. Dokan 드라이버가 설치되어 있고 최신 버전인지 확인하세요.");
                Console.WriteLine("Dokan 설치 경로: C:\\Program Files\\Dokan\\Dokan Library-2.0.4");
                Console.WriteLine("DokanCore2.dll, DokanNet.dll 파일이 실행 파일과 같은 디렉터리에 있거나 시스템 경로에 등록되어 있어야 할 수 있습니다.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 일반 오류 발생: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] 애플리케이션을 종료합니다. 필요한 경우 {MountPoint}를 수동으로 확인하세요.");
                // Console.ReadLine(); // 사용자가 메시지를 읽을 시간을 줌 (디버깅 시 유용)
            }
        }
    }
}
