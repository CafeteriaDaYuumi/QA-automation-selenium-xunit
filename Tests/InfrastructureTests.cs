using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar a infraestrutura básica
    /// do framework de automação.
    /// </summary>
    [Collection("Sequential Tests")]
    public class InfrastructureTests : BaseTest
    {
        /// <summary>
        /// Valida se o navegador pode ser iniciado,
        /// acessar a aplicação e gerar evidências da execução.
        /// </summary>
        [Fact]
        public void DeveAbrirNavegadorEAcessarSite()
        {
            // Acessa a URL base configurada no appsettings.json.
            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            // Gera evidência visual da execução.
            ScreenshotHelper.TakeScreenshot(
                Driver,
                "DeveAbrirNavegadorEAcessarSite"
            );

            // Valida se a página foi carregada corretamente.
            Assert.Contains(
                "Automation Exercise",
                Driver.Title
            );
        }
    }
}