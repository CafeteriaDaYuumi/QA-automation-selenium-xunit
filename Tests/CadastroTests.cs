using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar o fluxo de cadastro
    /// de usuário na aplicação.
    /// </summary>
    [Collection("Sequential Tests")]
    public class CadastroTests : BaseTest
    {
        [Fact]
        public void CT005_DeveAcessarAreaDeCadastro()
        {
            ReportHelper.CreateTest("CT005 - Deve acessar área de cadastro");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT005 - Deve acessar área de cadastro");

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                CadastroPage cadastroPage = new CadastroPage(Driver);

                cadastroPage.OpenCadastroPage();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT005_AcessarAreaDeCadastro"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(cadastroPage.IsCadastroAreaDisplayed());

                ReportHelper.LogPass("Área de cadastro acessada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT005_AcessarAreaDeCadastro_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        [Fact]
        public void CT006_DeveIniciarCadastroComDadosValidos()
        {
            ReportHelper.CreateTest("CT006 - Deve iniciar cadastro com dados válidos");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT006 - Deve iniciar cadastro com dados válidos");

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                CadastroPage cadastroPage = new CadastroPage(Driver);

                cadastroPage.OpenCadastroPage();

                cadastroPage.StartSignup(
                    "Usuario Teste",
                    $"usuario.teste.{DateTime.Now.Ticks}@gmail.com"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT006_IniciarCadastroComDadosValidos"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(cadastroPage.IsAccountInformationDisplayed());

                ReportHelper.LogPass("Cadastro iniciado com dados válidos.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT006_IniciarCadastroComDadosValidos_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        [Fact]
        public void CT007_DeveValidarEmailJaCadastrado()
        {
            ReportHelper.CreateTest("CT007 - Deve validar e-mail já cadastrado");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT007 - Deve validar e-mail já cadastrado");

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                CadastroPage cadastroPage = new CadastroPage(Driver);

                cadastroPage.OpenCadastroPage();

                cadastroPage.StartSignup(
                    "Usuario Existente",
                    "QA-automation-selenium-xunit@gmail.com"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT007_EmailJaCadastrado"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.Equal(
                    "Email Address already exist!",
                    cadastroPage.GetEmailAlreadyExistsMessage()
                );

                ReportHelper.LogPass("Mensagem de e-mail já cadastrado validada.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT007_EmailJaCadastrado_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        [Fact]
        public void CT008_DeveValidarCamposObrigatoriosNoCadastro()
        {
            ReportHelper.CreateTest("CT008 - Deve validar campos obrigatórios no cadastro");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT008 - Deve validar campos obrigatórios no cadastro");

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                CadastroPage cadastroPage = new CadastroPage(Driver);

                cadastroPage.OpenCadastroPage();

                cadastroPage.ClickSignup();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT008_CamposObrigatoriosCadastro"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(cadastroPage.IsCadastroAreaDisplayed());

                ReportHelper.LogPass("Validação de campos obrigatórios executada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT008_CamposObrigatoriosCadastro_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        [Fact]
        public void CT009_DeveCriarEExcluirContaComSucesso()
        {
            ReportHelper.CreateTest("CT009 - Deve criar e excluir conta com sucesso");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT009 - Deve criar e excluir conta com sucesso");

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                CadastroPage cadastroPage = new CadastroPage(Driver);

                cadastroPage.OpenCadastroPage();

                cadastroPage.StartSignup(
                    "Usuario Teste",
                    $"usuario.teste.{DateTime.Now.Ticks}@gmail.com"
                );

                cadastroPage.FillAccountInformation("123456");
                cadastroPage.FillAddressInformation();
                cadastroPage.ClickCreateAccount();

                string screenshotContaCriada = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT009_ContaCriada"
                );

                ReportHelper.AttachScreenshot(screenshotContaCriada);

                Assert.True(cadastroPage.IsAccountCreated());

                cadastroPage.ClickContinue();

                Thread.Sleep(2000);

                cadastroPage.DeleteAccount();

                string screenshotContaExcluida = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT009_ContaExcluida"
                );

                ReportHelper.AttachScreenshot(screenshotContaExcluida);

                Assert.True(cadastroPage.IsAccountDeleted());

                ReportHelper.LogPass("Conta criada e excluída com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT009_CriarEExcluirConta_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }
    }
}