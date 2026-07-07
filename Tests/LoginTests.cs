using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    // Testes responsáveis por validar
    // o fluxo de autenticação da aplicação.
    [Collection("Sequential Tests")]
    public class LoginTests : BaseTest
    {
        [Fact]
        public void LOGIN001_DeveAcessarPaginaDeLogin()
        {
            ReportHelper.CreateTest(
                "LOGIN001 - Deve acessar página de login"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando LOGIN001 - Deve acessar página de login"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                LoginPage loginPage =
                    new LoginPage(Driver);

                loginPage.OpenLoginPage();

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "LOGIN001_AcessarPaginaDeLogin"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    loginPage.IsLoginPageDisplayed()
                );

                ReportHelper.LogPass(
                    "Página de login acessada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "LOGIN001_AcessarPaginaDeLogin_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }

        [Fact]
        public void CT001_DeveRealizarLoginComCredenciaisValidas()
        {
            ReportHelper.CreateTest(
                "CT001 - Deve realizar login com credenciais válidas"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT001 - Deve realizar login com credenciais válidas"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                LoginPage loginPage =
                    new LoginPage(Driver);

                loginPage.OpenLoginPage();

                var user =
                    TestDataReader.GetUser(
                        "validUser"
                    );

                loginPage.Login(
                    user.Email,
                    user.Password
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT001_LoginValido"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    loginPage.IsUserLoggedIn()
                );

                ReportHelper.LogPass(
                    "Login realizado com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT001_LoginValido_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }

        [Fact]
        public void CT002_DeveExibirErroAoRealizarLoginComSenhaInvalida()
        {
            ReportHelper.CreateTest(
                "CT002 - Deve exibir erro ao realizar login com senha inválida"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT002 - Deve exibir erro ao realizar login com senha inválida"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                LoginPage loginPage =
                    new LoginPage(Driver);

                loginPage.OpenLoginPage();

                var user =
                    TestDataReader.GetUser(
                        "invalidUser"
                    );

                loginPage.Login(
                    user.Email,
                    user.Password
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT002_LoginSenhaInvalida"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.Equal(
                    "Your email or password is incorrect!",
                    loginPage.GetLoginErrorMessage()
                );

                ReportHelper.LogPass(
                    "Mensagem de erro validada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT002_LoginSenhaInvalida_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }

        [Fact]
        public void CT003_DeveValidarCamposObrigatoriosNoLogin()
        {
            ReportHelper.CreateTest(
                "CT003 - Deve validar campos obrigatórios no login"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT003 - Deve validar campos obrigatórios no login"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                LoginPage loginPage =
                    new LoginPage(Driver);

                loginPage.OpenLoginPage();

                loginPage.ClickLogin();

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT003_LoginCamposVazios"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    loginPage.IsLoginPageDisplayed()
                );

                ReportHelper.LogPass(
                    "Validação de campos obrigatórios executada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT003_LoginCamposVazios_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }

        [Fact]
        public void CT004_DeveRealizarLogoutComSucesso()
        {
            ReportHelper.CreateTest(
                "CT004 - Deve realizar logout com sucesso"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT004 - Deve realizar logout com sucesso"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                LoginPage loginPage =
                    new LoginPage(Driver);

                loginPage.OpenLoginPage();

                var user =
                    TestDataReader.GetUser(
                        "validUser"
                    );

                loginPage.Login(
                    user.Email,
                    user.Password
                );

                Assert.True(
                    loginPage.IsUserLoggedIn()
                );

                loginPage.Logout();

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT004_LogoutValido"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    loginPage.IsLoginPageDisplayed()
                );

                ReportHelper.LogPass(
                    "Logout realizado com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT004_LogoutValido_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }
    }
}