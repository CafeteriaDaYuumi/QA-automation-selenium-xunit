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

             // Exibe no console qual teste está sendo executado.
            Console.WriteLine(
                "A Pagina Esta Sendo Aberta Pela Primeira Vez"
            );

            // Acessa a aplicação.
            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            // Navega para a área de login.
            loginPage.OpenLoginPage();

            // Gera evidência da execução.
            ScreenshotHelper.TakeScreenshot(
                Driver,
                "DeveAcessarPaginaDeLogin"
            );

            // Valida se a página de login está visível.
            Assert.True(loginPage.IsLoginPageDisplayed());
        }

        /// <summary>
        /// Valida o login com credenciais válidas.
        /// </summary>
        [Fact]
        public void CT001_DeveRealizarLoginComCredenciaisValidas()
        {

            // Exibe no console qual teste está sendo executado.
            Console.WriteLine(
                "Executando CT001 - Deve Realizar Login Com Credenciais Validas"
            );


            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            // Obtém usuário válido da massa de dados.
            var user = TestDataReader.GetUser("validUser");

            // Executa login.
            loginPage.Login(
                user.Email,
                user.Password
            );

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT001_LoginValido"
            );

            // Valida autenticação com sucesso.
            Assert.True(loginPage.IsUserLoggedIn());
        }

        /// <summary>
        /// Valida a exibição de erro ao utilizar senha inválida.
        /// </summary>
        [Fact]
        public void CT002_DeveExibirErroAoRealizarLoginComSenhaInvalida()
        {

            // Exibe no console qual teste está sendo executado.
            Console.WriteLine(
                "Executando CT002 - Deve Exibir Erro Ao Realizar Login Com Senha Invalida"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            // Obtém usuário inválido da massa de dados.
            var user = TestDataReader.GetUser("invalidUser");

            // Executa tentativa de login inválida.
            loginPage.Login(
                user.Email,
                user.Password
            );

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT002_LoginSenhaInvalida"
            );

            // Valida mensagem de erro apresentada pelo sistema.
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

            // Exibe no console qual teste está sendo executado.
            Console.WriteLine(
                "Executando CT003 - Deve Validar Campos Obrigatorios No Login"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            // Tenta realizar login sem preencher os campos.
            loginPage.ClickLogin();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT003_LoginCamposVazios"
            );

            // Valida permanência na tela de login.
            Assert.True(loginPage.IsLoginPageDisplayed());
        }

        /// <summary>
        /// Valida o encerramento da sessão do usuário.
        /// </summary>
        [Fact]
        public void CT004_DeveRealizarLogoutComSucesso()
        {

            // Exibe no console qual teste está sendo executado.
            Console.WriteLine(
                "Executando CT004 - Logout do usuário"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            // Obtém usuário válido da massa de dados.
            var user = TestDataReader.GetUser("validUser");

            // Realiza login.
            loginPage.Login(
                user.Email,
                user.Password
            );

            // Confirma autenticação.
            Assert.True(loginPage.IsUserLoggedIn());

            // Executa logout.
            loginPage.Logout();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT004_LogoutValido"
            );

            // Valida retorno para a tela de login.
            Assert.True(loginPage.IsLoginPageDisplayed());
        }
    }
}