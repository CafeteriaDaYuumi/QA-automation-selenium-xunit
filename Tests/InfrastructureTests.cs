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
            ReportHelper.CreateTest("INFRA001 - Deve abrir navegador e acessar o site");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando INFRA001 - Deve abrir navegador e acessar o site"
                );

                // Acessa a URL base configurada.
                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                // Gera evidência da execução.
                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "DeveAbrirNavegadorEAcessarSite"
                );

                ReportHelper.AttachScreenshot(screenshot);

                // Valida carregamento da aplicação.
                Assert.Contains(
                    "Automation Exercise",
                    Driver.Title
                );

                ReportHelper.LogPass(
                    "Aplicação acessada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "DeveAbrirNavegadorEAcessarSite_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }
    }
}