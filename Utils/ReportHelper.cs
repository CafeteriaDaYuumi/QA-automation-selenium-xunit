using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace QA_automation_selenium_xunit.Utils
{
    // Responsável pela configuração e gerenciamento
    // dos relatórios de execução dos testes automatizados.
    public static class ReportHelper
    {
        private static ExtentReports? _extentReports;
        private static ExtentTest? _extentTest;

        // Retorna a instância principal do relatório.
        // Caso ainda não exista, cria e configura o relatório HTML.
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

                _extentReports.AttachReporter(
                    sparkReporter
                );

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

        // Cria um novo registro de teste no relatório.
        public static void CreateTest(string testName)
        {
            _extentTest =
                GetReportInstance().CreateTest(testName);
        }

        // Registra uma informação no teste atual.
        public static void LogInfo(string message)
        {
            _extentTest?.Info(message);
        }

        // Registra sucesso no teste atual.
        public static void LogPass(string message)
        {
            _extentTest?.Pass(message);
        }

        // Registra falha no teste atual.
        public static void LogFail(string message)
        {
            _extentTest?.Fail(message);
        }

        // Anexa uma captura de tela ao teste atual.
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
                _extentTest?.AddScreenCaptureFromPath(
                    screenshotPath
                );

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

        // Finaliza e grava o relatório em disco.
        public static void FlushReport()
        {
            _extentReports?.Flush();
        }
    }
}