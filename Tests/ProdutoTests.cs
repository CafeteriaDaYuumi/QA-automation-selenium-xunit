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
            ReportHelper.CreateTest("CT010 - Deve acessar área de produtos");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando CT010 - Deve acessar área de produtos"
                );

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                ProductPage productPage = new ProductPage(Driver);

                productPage.OpenProductsPage();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT010_AcessarAreaDeProdutos"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(productPage.IsProductsPageDisplayed());

                ReportHelper.LogPass(
                    "Área de produtos acessada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT010_AcessarAreaDeProdutos_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        /// <summary>
        /// Valida se o sistema retorna produtos ao pesquisar
        /// por um produto existente.
        /// </summary>
        [Fact]
        public void CT011_DevePesquisarProdutoExistente()
        {
            ReportHelper.CreateTest("CT011 - Deve pesquisar produto existente");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando CT011 - Deve pesquisar produto existente"
                );

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                ProductPage productPage = new ProductPage(Driver);

                productPage.OpenProductsPage();

                productPage.SearchProduct("Blue Top");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT011_PesquisarProdutoExistente"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(productPage.IsSearchedProductsDisplayed());
                Assert.True(productPage.HasProductsDisplayed());

                ReportHelper.LogPass(
                    "Pesquisa de produto existente realizada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT011_PesquisarProdutoExistente_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        /// <summary>
        /// Valida o comportamento do sistema ao pesquisar
        /// por um produto inexistente.
        /// </summary>
        [Fact]
        public void CT012_DevePesquisarProdutoInexistente()
        {
            ReportHelper.CreateTest("CT012 - Deve pesquisar produto inexistente");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando CT012 - Deve pesquisar produto inexistente"
                );

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                ProductPage productPage = new ProductPage(Driver);

                productPage.OpenProductsPage();

                productPage.SearchProduct("Produto Inexistente XYZ");

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT012_PesquisarProdutoInexistente"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(productPage.IsSearchedProductsDisplayed());
                Assert.False(productPage.HasProductsDisplayed());

                ReportHelper.LogPass(
                    "Pesquisa de produto inexistente validada com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT012_PesquisarProdutoInexistente_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }

        /// <summary>
        /// Valida se o usuário consegue acessar os detalhes
        /// de um produto exibido na listagem.
        /// </summary>
        [Fact]
        public void CT013_DeveVisualizarDetalhesDoProduto()
        {
            ReportHelper.CreateTest("CT013 - Deve visualizar detalhes do produto");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine(
                    "Executando CT013 - Deve visualizar detalhes do produto"
                );

                Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

                ProductPage productPage = new ProductPage(Driver);

                productPage.OpenProductsPage();

                productPage.OpenFirstProductDetails();

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT013_VisualizarDetalhesDoProduto"
                );

                ReportHelper.AttachScreenshot(screenshot);

                Assert.True(productPage.IsProductDetailsDisplayed());

                ReportHelper.LogPass(
                    "Detalhes do produto exibidos com sucesso."
                );
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(
                    $"Falha durante a execução: {ex.Message}"
                );

                string screenshot = ScreenshotHelper.TakeScreenshot(
                    Driver,
                    "CT013_VisualizarDetalhesDoProduto_Falha"
                );

                ReportHelper.AttachScreenshot(screenshot);

                throw;
            }
        }
    }
}