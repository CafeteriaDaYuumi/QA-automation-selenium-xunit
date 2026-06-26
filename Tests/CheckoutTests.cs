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
        /// <summary>
        /// Realiza login antes da execução dos testes.
        /// Limpa os cookies para evitar reaproveitamento
        /// de sessão entre os cenários.
        /// </summary>
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

        /// <summary>
        /// Valida o acesso à tela de checkout.
        /// </summary>
        [Fact]
        public void CT017_DeveAcessarTelaDeCheckout()
        {
            Console.WriteLine(
                "Executando CT017 - Deve acessar tela de checkout"
            );

            Login();

            CheckoutPage checkoutPage = new CheckoutPage(Driver);

            checkoutPage.AddProductById("1");
            checkoutPage.OpenCartPage();

            Assert.True(checkoutPage.HasProductsInCart());

            checkoutPage.ProceedToCheckout();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT017_AcessarTelaDeCheckout"
            );

            Assert.True(checkoutPage.IsCheckoutPageDisplayed());
        }

        /// <summary>
        /// Valida a finalização de compra com sucesso.
        /// </summary>
        [Fact]
        public void CT018_DeveFinalizarCompraComSucesso()
        {
            Console.WriteLine(
                "Executando CT018 - Deve finalizar compra com sucesso"
            );

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

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT018_FinalizarCompraComSucesso"
            );

            Assert.True(checkoutPage.IsOrderPlaced());
        }

        /// <summary>
        /// Valida o acesso à tela de pagamento.
        /// </summary>
        [Fact]
        public void CT019_DeveAcessarTelaDePagamento()
        {
            Console.WriteLine(
                "Executando CT019 - Deve acessar tela de pagamento"
            );

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

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT019_AcessarTelaDePagamento"
            );

            Assert.True(checkoutPage.IsPaymentPageDisplayed());
        }

        /// <summary>
        /// Valida a finalização de compra utilizando
        /// uma segunda massa de dados.
        /// </summary>
        [Fact]
        public void CT020_DeveFinalizarCompraComSegundaMassaDeDados()
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

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT020_FinalizarCompraSegundaMassa"
            );

            Assert.True(checkoutPage.IsOrderPlaced());
        }
    }
}