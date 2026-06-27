using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar o fluxo de autenticação
    /// da aplicação.
    /// </summary>
    [Collection("Sequential Tests")]
    public class LoginTests : BaseTest
    {
        /// <summary>
        /// Valida se a página de login pode ser acessada.
        /// </summary>
        [Fact]
        public void DeveAcessarPaginaDeLogin()
        {
            ReportHelper.CreateTest("LOGIN001 - Deve acessar página de login");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "A Pagina Esta Sendo Aberta Pela Primeira Vez"
                );

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                LoginPage loginPage = new LoginPage(Driver);

                loginPage.OpenLoginPage();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "DeveAcessarPaginaDeLogin"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(loginPage.IsLoginPageDisplayed());

                ReportHelper.LogPass(
                    "Página de login acessada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "DeveAcessarPaginaDeLogin_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        /// <summary>
        /// Valida o login com credenciais válidas.
        /// </summary>
        [Fact]
        public void CT001_DeveRealizarLoginComCredenciaisValidas()
        {
            Console.WriteLine(
                "Executando CT001 - Deve Realizar Login Com Credenciais Validas"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            var user = TestDataReader.GetUser("validUser");

            loginPage.Login(
                user.Email,
                user.Password
            );

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT001_LoginValido"
            );

            Assert.True(loginPage.IsUserLoggedIn());
        }

        /// <summary>
        /// Valida a exibição de erro ao utilizar senha inválida.
        /// </summary>
        [Fact]
        public void CT002_DeveExibirErroAoRealizarLoginComSenhaInvalida()
        {
            Console.WriteLine(
                "Executando CT002 - Deve Exibir Erro Ao Realizar Login Com Senha Invalida"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            var user = TestDataReader.GetUser("invalidUser");

            loginPage.Login(
                user.Email,
                user.Password
            );

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT002_LoginSenhaInvalida"
            );

            Assert.Equal(
                "Your email or password is incorrect!",
                loginPage.GetLoginErrorMessage()
            );
        }

        /// <summary>
        /// Valida o comportamento do sistema quando os campos
        /// obrigatórios não são preenchidos.
        /// </summary>
        [Fact]
        public void CT003_DeveValidarCamposObrigatoriosNoLogin()
        {
            Console.WriteLine(
                "Executando CT003 - Deve Validar Campos Obrigatorios No Login"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            loginPage.ClickLogin();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT003_LoginCamposVazios"
            );

            Assert.True(loginPage.IsLoginPageDisplayed());
        }

        /// <summary>
        /// Valida o encerramento da sessão do usuário.
        /// </summary>
        [Fact]
        public void CT004_DeveRealizarLogoutComSucesso()
        {
            Console.WriteLine(
                "Executando CT004 - Logout do usuário"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            var user = TestDataReader.GetUser("validUser");

            loginPage.Login(
                user.Email,
                user.Password
            );

            Assert.True(loginPage.IsUserLoggedIn());

            loginPage.Logout();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT004_LogoutValido"
            );

            Assert.True(loginPage.IsLoginPageDisplayed());
        }
    }
}