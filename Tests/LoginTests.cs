using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    public class LoginTests : BaseTest
    {
        [Fact]
        public void DeveAcessarPaginaDeLogin()
        {
            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "DeveAcessarPaginaDeLogin"
            );

            Assert.True(loginPage.IsLoginPageDisplayed());
        }

        [Fact]
        public void CT001_DeveRealizarLoginComCredenciaisValidas()
        {
            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            loginPage.Login(
                "QA-automation-selenium-xunit@gmail.com",
                "123456"
            );

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT001_LoginValido"
            );

            Assert.True(loginPage.IsUserLoggedIn());
        }

        [Fact]
        public void CT002_DeveExibirErroAoRealizarLoginComSenhaInvalida()
        {
            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            loginPage.Login(
                "QA-automation-selenium-xunit@gmail.com",
                "senha_invalida"
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

        [Fact]
        public void CT003_DeveValidarCamposObrigatoriosNoLogin()
        {
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

        [Fact]
        public void CT004_DeveRealizarLogoutComSucesso()
        {
            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            loginPage.Login(
                "QA-automation-selenium-xunit@gmail.com",
                "123456"
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