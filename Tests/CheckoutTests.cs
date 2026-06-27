using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar
    /// o fluxo de checkout da aplicação.
    /// </summary>
    [Collection("Sequential Tests")]
    public class CheckoutTests : BaseTest
    {
        private void Login()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.OpenLoginPage();

            loginPage.Login(
                "QA-automation-selenium-xunit@gmail.com",
                "123456"
            );

            Thread.Sleep(2000);

            Assert.True(loginPage.IsUserLoggedIn());
        }

        [Fact]
        public void CT017_DeveAcessarTelaDeCheckout()
        {
            ReportHelper.CreateTest("CT017 - Deve acessar tela de checkout");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT017 - Deve acessar tela de checkout");

                Login();

                CheckoutPage checkoutPage = new CheckoutPage(Driver);

                checkoutPage.AddProductById("1");
                checkoutPage.OpenCartPage();

                Assert.True(checkoutPage.HasProductsInCart());

                checkoutPage.ProceedToCheckout();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT017_AcessarTelaDeCheckout"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(checkoutPage.IsCheckoutPageDisplayed());

                ReportHelper.LogPass("Tela de checkout acessada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT017_AcessarTelaDeCheckout_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        [Fact]
        public void CT018_DeveFinalizarCompraComSucesso()
        {
            ReportHelper.CreateTest("CT018 - Deve finalizar compra com sucesso");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT018 - Deve finalizar compra com sucesso");

                Login();

                CheckoutPage checkoutPage = new CheckoutPage(Driver);

                checkoutPage.AddProductById("1");
                checkoutPage.OpenCartPage();

                Assert.True(checkoutPage.HasProductsInCart());

                checkoutPage.ProceedToCheckout();

                Assert.True(checkoutPage.IsCheckoutPageDisplayed());

                checkoutPage.EnterOrderComment(
                    "Pedido automatizado para validação do fluxo de checkout."
                );

                checkoutPage.ClickPlaceOrder();

                checkoutPage.FillPaymentInformation(
                    "Usuario Teste",
                    "4111111111111111",
                    "123",
                    "12",
                    "2030"
                );

                checkoutPage.ClickPayAndConfirmOrder();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT018_FinalizarCompraComSucesso"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(checkoutPage.IsOrderPlaced());

                ReportHelper.LogPass("Compra finalizada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT018_FinalizarCompraComSucesso_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        [Fact]
        public void CT019_DeveAcessarTelaDePagamento()
        {
            ReportHelper.CreateTest("CT019 - Deve acessar tela de pagamento");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT019 - Deve acessar tela de pagamento");

                Login();

                CheckoutPage checkoutPage = new CheckoutPage(Driver);

                checkoutPage.AddProductById("1");
                checkoutPage.OpenCartPage();

                Assert.True(checkoutPage.HasProductsInCart());

                checkoutPage.ProceedToCheckout();

                Assert.True(checkoutPage.IsCheckoutPageDisplayed());

                checkoutPage.EnterOrderComment(
                    "Validação da navegação para a tela de pagamento."
                );

                checkoutPage.ClickPlaceOrder();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT019_AcessarTelaDePagamento"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(checkoutPage.IsPaymentPageDisplayed());

                ReportHelper.LogPass("Tela de pagamento acessada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT019_AcessarTelaDePagamento_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        [Fact]
        public void CT020_DeveFinalizarCompraComSegundaMassaDeDados()
        {
            ReportHelper.CreateTest("CT020 - Deve finalizar compra com segunda massa de dados");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando CT020 - Deve finalizar compra com segunda massa de dados"
                );

                Login();

                CheckoutPage checkoutPage = new CheckoutPage(Driver);

                checkoutPage.AddProductById("2");
                checkoutPage.OpenCartPage();

                Assert.True(checkoutPage.HasProductsInCart());

                checkoutPage.ProceedToCheckout();

                Assert.True(checkoutPage.IsCheckoutPageDisplayed());

                checkoutPage.EnterOrderComment(
                    "Pedido automatizado utilizando segunda massa de dados."
                );

                checkoutPage.ClickPlaceOrder();

                checkoutPage.FillPaymentInformation(
                    "Maria Oliveira",
                    "5555555555554444",
                    "456",
                    "10",
                    "2032"
                );

                checkoutPage.ClickPayAndConfirmOrder();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT020_FinalizarCompraSegundaMassa"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(checkoutPage.IsOrderPlaced());

                ReportHelper.LogPass(
                    "Compra finalizada com sucesso utilizando segunda massa de dados."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT020_FinalizarCompraSegundaMassa_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }
    }
}