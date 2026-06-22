using OpenQA.Selenium;
using QA_automation_selenium_xunit.Drivers;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Classe base responsável pela inicialização e encerramento
    /// do navegador utilizado pelos testes automatizados.
    /// </summary>
    public abstract class BaseTest : IDisposable
    {
        protected DriverFactory DriverFactory { get; private set; }
        protected IWebDriver Driver { get; private set; }

        protected BaseTest()
        {
            DriverFactory = new DriverFactory();
            Driver = DriverFactory.GetDriver();
        }

        /// <summary>
        /// Encerra o navegador ao final da execução do teste.
        /// </summary>
        public void Dispose()
        {
            DriverFactory.QuitDriver();
        }
    }
}