using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar o fluxo de pesquisa
    /// e visualização de produtos na aplicação.
    /// </summary>
    [Collection("Sequential Tests")]
    public class ProductTests : BaseTest
    {
        /// <summary>
        /// Valida se a área de produtos pode ser acessada.
        /// </summary>
        [Fact]
        public void CT010_DeveAcessarAreaDeProdutos()
        {
            Console.WriteLine(
                "Executando CT010 - Deve acessar área de produtos"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            ProductPage productPage = new ProductPage(Driver);

            productPage.OpenProductsPage();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT010_AcessarAreaDeProdutos"
            );

            Assert.True(productPage.IsProductsPageDisplayed());
        }

        /// <summary>
        /// Valida se o sistema retorna produtos ao pesquisar
        /// por um produto existente.
        /// </summary>
        [Fact]
        public void CT011_DevePesquisarProdutoExistente()
        {
            Console.WriteLine(
                "Executando CT011 - Deve pesquisar produto existente"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            ProductPage productPage = new ProductPage(Driver);

            productPage.OpenProductsPage();

            productPage.SearchProduct("Blue Top");

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT011_PesquisarProdutoExistente"
            );

            Assert.True(productPage.IsSearchedProductsDisplayed());
            Assert.True(productPage.HasProductsDisplayed());
        }

        /// <summary>
        /// Valida o comportamento do sistema ao pesquisar
        /// por um produto inexistente.
        /// </summary>
        [Fact]
        public void CT012_DevePesquisarProdutoInexistente()
        {
            Console.WriteLine(
                "Executando CT012 - Deve pesquisar produto inexistente"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            ProductPage productPage = new ProductPage(Driver);

            productPage.OpenProductsPage();

            productPage.SearchProduct("Produto Inexistente XYZ");

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT012_PesquisarProdutoInexistente"
            );

            Assert.True(productPage.IsSearchedProductsDisplayed());
            Assert.False(productPage.HasProductsDisplayed());
        }

        /// <summary>
        /// Valida se o usuário consegue acessar os detalhes
        /// de um produto exibido na listagem.
        /// </summary>
        [Fact]
        public void CT013_DeveVisualizarDetalhesDoProduto()
        {
            Console.WriteLine(
                "Executando CT013 - Deve visualizar detalhes do produto"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            ProductPage productPage = new ProductPage(Driver);

            productPage.OpenProductsPage();

            productPage.OpenFirstProductDetails();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT013_VisualizarDetalhesDoProduto"
            );

            Assert.True(productPage.IsProductDetailsDisplayed());
        }
    }
}