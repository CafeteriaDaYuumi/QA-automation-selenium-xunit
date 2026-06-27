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
            ReportHelper.CreateTest("CT014 - Deve adicionar produto ao carrinho");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando CT014 - Deve adicionar produto ao carrinho"
                );

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                CartPage cartPage = new CartPage(Driver);

                cartPage.OpenProductsPage();
                cartPage.AddFirstProductToCart();
                cartPage.ViewCart();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT014_AdicionarProdutoAoCarrinho"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(cartPage.HasProductsInCart());

                ReportHelper.LogPass("Produto adicionado ao carrinho com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT014_AdicionarProdutoAoCarrinho_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        /// <summary>
        /// Valida a adição de múltiplos produtos ao carrinho.
        /// </summary>
        [Fact]
        public void CT015_DeveAdicionarMultiplosProdutosAoCarrinho()
        {
            ReportHelper.CreateTest("CT015 - Deve adicionar múltiplos produtos ao carrinho");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando CT015 - Deve adicionar múltiplos produtos ao carrinho"
                );

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                CartPage cartPage = new CartPage(Driver);

                cartPage.AddProductById("1");
                cartPage.AddProductById("2");

                cartPage.OpenCartPage();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT015_AdicionarMultiplosProdutosAoCarrinho"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.Equal(
                    2,
                    cartPage.GetCartItemsCount()
                );

                ReportHelper.LogPass("Múltiplos produtos adicionados ao carrinho com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT015_AdicionarMultiplosProdutosAoCarrinho_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        /// <summary>
        /// Valida a remoção de um produto do carrinho.
        /// </summary>
        [Fact]
        public void CT016_DeveRemoverProdutoDoCarrinho()
        {
            ReportHelper.CreateTest("CT016 - Deve remover produto do carrinho");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
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

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT016_RemoverProdutoDoCarrinho"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(cartPage.IsCartEmpty());

                ReportHelper.LogPass("Produto removido do carrinho com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT016_RemoverProdutoDoCarrinho_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }
    }
}