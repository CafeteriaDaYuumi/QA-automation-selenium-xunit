using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace QA_automation_selenium_xunit.Utils
{
    /// <summary>
    /// Classe responsável pela configuração e gerenciamento
    /// dos relatórios de execução dos testes automatizados.
    /// </summary>
    public static class ReportHelper
    {
        private static ExtentReports? _extentReports;
        private static ExtentTest? _extentTest;

        /// <summary>
        /// Retorna a instância principal do relatório.
        /// Caso ainda não exista, cria e configura o relatório HTML.
        /// </summary>
        /// <returns>Instância configurada do ExtentReports.</returns>
        public static ExtentReports GetReportInstance()
        {
            if (_extentReports == null)
            {
                string reportDirectory = Path.Combine(
                    AppContext.BaseDirectory,
                    "Reports"
                );

                Directory.CreateDirectory(reportDirectory);

                string reportPath = Path.Combine(
                    reportDirectory,
                    $"TestReport_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.html"
                );

                ExtentSparkReporter sparkReporter =
                    new ExtentSparkReporter(reportPath);

                sparkReporter.Config.DocumentTitle =
                    "QA Test Automation Framework";

                sparkReporter.Config.ReportName =
                    "Relatório de Execução dos Testes Automatizados";

                _extentReports = new ExtentReports();
                _extentReports.AttachReporter(sparkReporter);

                _extentReports.AddSystemInfo(
                    "Projeto",
                    "QA Test Automation Framework"
                );

                _extentReports.AddSystemInfo("Linguagem", "C#");
                _extentReports.AddSystemInfo("Framework", "xUnit");
                _extentReports.AddSystemInfo("Automação", "Selenium WebDriver");
                _extentReports.AddSystemInfo("Ambiente", "QA");
                _extentReports.AddSystemInfo("Navegador", "Google Chrome");
            }

            return _extentReports;
        }

        /// <summary>
        /// Cria um novo registro de teste no relatório.
        /// </summary>
        /// <param name="testName">Nome do teste executado.</param>
        public static void CreateTest(string testName)
        {
            _extentTest = GetReportInstance().CreateTest(testName);
        }

        /// <summary>
        /// Registra uma informação no teste atual.
        /// </summary>
        /// <param name="message">Mensagem informativa.</param>
        public static void LogInfo(string message)
        {
            _extentTest?.Info(message);
        }

        /// <summary>
        /// Registra sucesso no teste atual.
        /// </summary>
        /// <param name="message">Mensagem de sucesso.</param>
        public static void LogPass(string message)
        {
            _extentTest?.Pass(message);
        }

        /// <summary>
        /// Registra falha no teste atual.
        /// </summary>
        /// <param name="message">Mensagem de falha.</param>
        public static void LogFail(string message)
        {
            _extentTest?.Fail(message);
        }

        /// <summary>
        /// Anexa uma captura de tela ao teste atual.
        /// </summary>
        /// <param name="screenshotPath">Caminho completo da captura de tela.</param>
        public static void AttachScreenshot(string screenshotPath)
        {
            if (string.IsNullOrWhiteSpace(screenshotPath))
            {
                _extentTest?.Warning(
                    "Caminho da evidência não informado."
                );

                return;
            }

            if (File.Exists(screenshotPath))
            {
                _extentTest?.AddScreenCaptureFromPath(screenshotPath);

                _extentTest?.Info(
                    $"Evidência anexada: {Path.GetFileName(screenshotPath)}"
                );
            }
            else
            {
                _extentTest?.Warning(
                    $"Evidência não encontrada: {screenshotPath}"
                );
            }
        }

        /// <summary>
        /// Finaliza e grava o relatório em disco.
        /// </summary>
        public static void FlushReport()
        {
            _extentReports?.Flush();
        }
    }
}