using OpenQA.Selenium;
using QA_automation_selenium_xunit.Drivers;
using QA_automation_selenium_xunit.Utils;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Classe base responsável pela inicialização e encerramento
    /// do navegador utilizado pelos testes automatizados.
    /// Também centraliza a finalização do relatório de execução.
    /// </summary>
    public abstract class BaseTest : IDisposable
    {
        protected DriverFactory DriverFactory { get; private set; }
        protected IWebDriver Driver { get; private set; }

        protected BaseTest()
        {
            DriverFactory = new DriverFactory();
            Driver = DriverFactory.GetDriver();

            ReportHelper.GetReportInstance();
        }

        /// <summary>
        /// Cria um teste no relatório.
        /// Deve ser chamado no início de cada teste.
        /// </summary>
        protected void StartReportTest(string testName)
        {
            ReportHelper.CreateTest(testName);
            ReportHelper.LogInfo("Teste iniciado.");
        }

        /// <summary>
        /// Encerra o navegador e atualiza o relatório
        /// ao final da execução do teste.
        /// </summary>
        public void Dispose()
        {
            DriverFactory.QuitDriver();

            ReportHelper.FlushReport();
        }
    }
}