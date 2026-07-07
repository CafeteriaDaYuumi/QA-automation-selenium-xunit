using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    // Testes responsáveis por validar o fluxo
    // de pesquisa e visualização de produtos.
    [Collection("Sequential Tests")]
    public class ProductTests : BaseTest
    {
        [Fact]
        public void CT010_ShouldAccessProductsArea()
        {
            ReportHelper.CreateTest(
                "CT010 - Deve acessar área de produtos"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT010 - Deve acessar área de produtos"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                ProductPage productPage =
                    new ProductPage(Driver);

                productPage.OpenProductsPage();

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT010_AcessarAreaDeProdutos"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    productPage.IsProductsPageDisplayed()
                );

                ReportHelper.LogPass(
                    "Área de produtos acessada com sucesso."
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
                        "CT010_AcessarAreaDeProdutos_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }

        [Fact]
        public void CT011_ShouldSearchExistingProduct()
        {
            ReportHelper.CreateTest(
                "CT011 - Deve pesquisar produto existente"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT011 - Deve pesquisar produto existente"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                ProductPage productPage =
                    new ProductPage(Driver);

                productPage.OpenProductsPage();

                productPage.SearchProduct(
                    "Blue Top"
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT011_PesquisarProdutoExistente"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    productPage.IsSearchedProductsDisplayed()
                );

                Assert.True(
                    productPage.HasProductsDisplayed()
                );

                ReportHelper.LogPass(
                    "Pesquisa de produto existente realizada com sucesso."
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
                        "CT011_PesquisarProdutoExistente_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }

        [Fact]
        public void CT012_ShouldSearchNonExistingProduct()
        {
            ReportHelper.CreateTest(
                "CT012 - Deve pesquisar produto inexistente"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT012 - Deve pesquisar produto inexistente"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                ProductPage productPage =
                    new ProductPage(Driver);

                productPage.OpenProductsPage();

                productPage.SearchProduct(
                    "Produto Inexistente XYZ"
                );

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT012_PesquisarProdutoInexistente"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    productPage.IsSearchedProductsDisplayed()
                );

                Assert.False(
                    productPage.HasProductsDisplayed()
                );

                ReportHelper.LogPass(
                    "Pesquisa de produto inexistente validada com sucesso."
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
                        "CT012_PesquisarProdutoInexistente_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }

        [Fact]
        public void CT013_ShouldViewProductDetails()
        {
            ReportHelper.CreateTest(
                "CT013 - Deve visualizar detalhes do produto"
            );

            ReportHelper.LogInfo(
                "Iniciando execução do teste."
            );

            try
            {
                Console.WriteLine(
                    "Executando CT013 - Deve visualizar detalhes do produto"
                );

                Driver.Navigate().GoToUrl(
                    ConfigReader.GetBaseUrl()
                );

                ProductPage productPage =
                    new ProductPage(Driver);

                productPage.OpenProductsPage();

                productPage.OpenFirstProductDetails();

                string screenshot =
                    ScreenshotHelper.TakeScreenshot(
                        Driver,
                        "CT013_VisualizarDetalhesDoProduto"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                Assert.True(
                    productPage.IsProductDetailsDisplayed()
                );

                ReportHelper.LogPass(
                    "Detalhes do produto exibidos com sucesso."
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
                        "CT013_VisualizarDetalhesDoProduto_Falha"
                    );

                ReportHelper.AttachScreenshot(
                    screenshot
                );

                throw;
            }
        }
    }
}