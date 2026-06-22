using OpenQA.Selenium;
using QA_automation_selenium_xunit.Drivers;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar a infraestrutura básica
    /// do framework de automação.
    /// </summary>
    public class InfrastructureTests
    {
        /// <summary>
        /// Valida se o navegador pode ser iniciado,
        /// acessar a aplicação e gerar evidências da execução.
        /// </summary>
        [Fact]
        public void DeveAbrirNavegadorEAcessarSite()
        {
            // Inicializa o navegador através da DriverFactory.
            DriverFactory driverFactory = new DriverFactory();
            IWebDriver driver = driverFactory.GetDriver();

            // Acessa a URL configurada no ambiente.
            driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            // Gera evidência da execução.
            ScreenshotHelper.TakeScreenshot(
                driver,
                "DeveAbrirNavegadorEAcessarSite"
            );

            // Valida se a página foi carregada corretamente.
            Assert.Contains("Automation Exercise", driver.Title);

            // Finaliza a execução do navegador.
            driverFactory.QuitDriver();
        }
    }
}