using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    public class ProductPage
    {
        private readonly IWebDriver _driver;

        // Campo utilizado para informar o termo de pesquisa.
        private readonly By _searchProductField =
            By.Id("search_product");

        // Botão responsável por executar a pesquisa.
        private readonly By _searchButton =
            By.Id("submit_search");

        // Título exibido após a realização de uma pesquisa.
        private readonly By _searchedProductsTitle =
            By.XPath(
                "//h2[contains(text(),'Searched Products')]"
            );

        // Lista de produtos exibidos na página.
        private readonly By _productItems =
            By.ClassName(
                "product-image-wrapper"
            );

        // Inicializa a página de produtos com a instância atual do WebDriver.
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Acessa diretamente a página de produtos para reduzir falhas
        // causadas por anúncios, carregamentos incompletos ou redirecionamentos.
        public void OpenProductsPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/products"
            );
        }

        // Verifica se a página de produtos está sendo exibida.
        public bool IsProductsPageDisplayed()
        {
            return _driver.Url.Contains("/products")
                && _driver
                    .FindElements(_searchProductField)
                    .Count > 0;
        }

        // Preenche o campo de pesquisa com o nome do produto.
        public void EnterProductName(string productName)
        {
            _driver
                .FindElement(_searchProductField)
                .SendKeys(productName);
        }

        // Realiza o clique no botão de pesquisa.
        public void ClickSearch()
        {
            _driver
                .FindElement(_searchButton)
                .Click();
        }

        // Executa o fluxo completo de pesquisa de produto.
        public void SearchProduct(string productName)
        {
            EnterProductName(productName);
            ClickSearch();
        }

        // Verifica se a área de produtos pesquisados está sendo exibida.
        public bool IsSearchedProductsDisplayed()
        {
            return _driver
                .FindElement(_searchedProductsTitle)
                .Displayed;
        }

        // Verifica se existem produtos exibidos na listagem.
        public bool HasProductsDisplayed()
        {
            return _driver
                .FindElements(_productItems)
                .Count > 0;
        }

        // Acessa diretamente os detalhes do primeiro produto para reduzir
        // falhas causadas por anúncios, pop-ups ou elementos sobrepostos.
        public void OpenFirstProductDetails()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/product_details/1"
            );
        }

        // Verifica se a página de detalhes do produto está carregada
        // utilizando a URL e elementos característicos da página.
        public bool IsProductDetailsDisplayed()
        {
            return _driver.Url.Contains("/product_details/")
                && _driver.PageSource.Contains("Category")
                && _driver.PageSource.Contains("Availability");
        }
    }
}