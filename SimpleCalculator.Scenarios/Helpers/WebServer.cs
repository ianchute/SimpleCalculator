using System.Diagnostics;
using System.Threading;

namespace SimpleCalculator.Scenarios.Helpers
{
    /// <summary>
    /// For automatically running IIS when running BDD tests.
    /// Source : http://www.radicalgeek.co.uk/Post/12/starting-up-iis-express-for-a-specflow-and-selenium-webdriver-test-run
    /// </summary>
    internal static class WebServer
    {
        private static Process _iisProcess;

        public static void Start()
        {
            if (_iisProcess == null)
            {
                var thread = new Thread(StartIisExpress)
                {
                    IsBackground = true
                };

                thread.Start();
            }
        }

        private static void StartIisExpress()
        {
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Normal,
                ErrorDialog = true,
                LoadUserProfile = true,
                CreateNoWindow = false,
                UseShellExecute = false,
                Arguments = string.Format("/path:\"{0}\" /port:{1}",
                    @"C:\Users\ian\Documents\Visual Studio 2015\Projects\SimpleCalculator\SimpleCalculator",
                    "8888")
            };

            var programfiles = string.IsNullOrEmpty(startInfo.EnvironmentVariables["programfiles"])
                ? startInfo.EnvironmentVariables["programfiles(x86)"] 
                : startInfo.EnvironmentVariables["programfiles"];

            startInfo.FileName = programfiles + "\\IIS Express\\iisexpress.exe";

            try
            {
                _iisProcess = new Process { StartInfo = startInfo };
                _iisProcess.Start();
                _iisProcess.WaitForExit();
            }
            catch
            {
                _iisProcess.CloseMainWindow();
                _iisProcess.Dispose();
            }
        }

        public static void Stop()
        {
            if (_iisProcess != null)
            {
                _iisProcess.CloseMainWindow();
                _iisProcess.Dispose();
            }
        }
    }
}