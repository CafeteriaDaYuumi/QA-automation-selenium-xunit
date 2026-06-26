 using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar
    /// o fluxo do carrinho de compras.
    /// </summary>
    [Collection("Sequential Tests")]
    public class CartTests : BaseTest
    {
        /// <summary>
        /// Valida a adição de um produto ao carrinho.
        /// </summary>
        [Fact]
        public void CT014_DeveAdicionarProdutoAoCarrinho()
        {
            Console.WriteLine(
                "Executando CT014 - Deve adicionar produto ao carrinho"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CartPage cartPage = new CartPage(Driver);

            cartPage.OpenProductsPage();
            cartPage.AddFirstProductToCart();
            cartPage.ViewCart();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT014_AdicionarProdutoAoCarrinho"
            );

            Assert.True(cartPage.HasProductsInCart());
        }

        /// <summary>
        /// Valida a adição de múltiplos produtos ao carrinho.
        /// </summary>
        [Fact]
        public void CT015_DeveAdicionarMultiplosProdutosAoCarrinho()
        {
            Console.WriteLine(
                "Executando CT015 - Deve adicionar múltiplos produtos ao carrinho"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CartPage cartPage = new CartPage(Driver);

            cartPage.AddProductById("1");
            cartPage.AddProductById("2");

            cartPage.OpenCartPage();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT015_AdicionarMultiplosProdutosAoCarrinho"
            );

            Assert.Equal(
                2,
                cartPage.GetCartItemsCount()
            );
        }

        /// <summary>
        /// Valida a remoção de um produto do carrinho.
        /// </summary>
        [Fact]
        public void CT016_DeveRemoverProdutoDoCarrinho()
        {
            Console.WriteLine(
                "Executando CT016 - Deve remover produto do carrinho"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CartPage cartPage = new CartPage(Driver);

            cartPage.AddProductById("1");
            cartPage.OpenCartPage();

            Assert.True(cartPage.HasProductsInCart());

            cartPage.RemoveFirstProductFromCart();

            Thread.Sleep(2000);

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT016_RemoverProdutoDoCarrinho"
            );

            Assert.True(cartPage.IsCartEmpty());
        }
    }
}