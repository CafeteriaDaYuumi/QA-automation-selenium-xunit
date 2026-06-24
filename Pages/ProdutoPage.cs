using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    /// <summary>
    /// Página responsável pelas operações relacionadas
    /// à pesquisa e visualização de produtos.
    /// </summary>
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
            By.XPath("//h2[contains(text(),'Searched Products')]");

        // Lista de produtos exibidos na página.
        private readonly By _productItems =
            By.ClassName("product-image-wrapper");

        /// <summary>
        /// Construtor da página de produtos.
        /// </summary>
        /// <param name="driver">Instância do WebDriver utilizada pelos testes.</param>
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Acessa a página de produtos.
        /// Utiliza navegação direta para evitar falhas causadas
        /// por anúncios, carregamentos incompletos ou redirecionamentos.
        /// </summary>
        public void OpenProductsPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/products"
            );
        }

        /// <summary>
        /// Verifica se a página de produtos está sendo exibida.
        /// </summary>
        /// <returns>True quando a página de produtos estiver visível.</returns>
        public bool IsProductsPageDisplayed()
        {
            return _driver.Url.Contains("/products")
                && _driver.FindElements(_searchProductField).Count > 0;
        }

        /// <summary>
        /// Preenche o campo de pesquisa de produtos.
        /// </summary>
        /// <param name="productName">Nome do produto pesquisado.</param>
        public void EnterProductName(string productName)
        {
            _driver.FindElement(_searchProductField).SendKeys(productName);
        }

        /// <summary>
        /// Realiza o clique no botão de pesquisa.
        /// </summary>
        public void ClickSearch()
        {
            _driver.FindElement(_searchButton).Click();
        }

        /// <summary>
        /// Executa o fluxo completo de pesquisa de produto.
        /// </summary>
        /// <param name="productName">Nome do produto pesquisado.</param>
        public void SearchProduct(string productName)
        {
            EnterProductName(productName);
            ClickSearch();
        }

        /// <summary>
        /// Verifica se o título de produtos pesquisados está sendo exibido.
        /// </summary>
        /// <returns>True quando a área de resultados de pesquisa estiver visível.</returns>
        public bool IsSearchedProductsDisplayed()
        {
            return _driver.FindElement(_searchedProductsTitle).Displayed;
        }

        /// <summary>
        /// Verifica se existem produtos exibidos na listagem.
        /// </summary>
        /// <returns>True quando ao menos um produto estiver visível.</returns>
        public bool HasProductsDisplayed()
        {
            return _driver.FindElements(_productItems).Count > 0;
        }

        /// <summary>
        /// Acessa os detalhes do primeiro produto.
        /// Utiliza navegação direta para evitar falhas causadas
        /// por anúncios, pop-ups ou elementos sobrepostos
        /// presentes na aplicação de teste.
        /// </summary>
        public void OpenFirstProductDetails()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/product_details/1"
            );
        }

        /// <summary>
        /// Verifica se a página de detalhes do produto está sendo exibida.
        /// A validação é realizada através da URL e de elementos
        /// característicos da página de detalhes.
        /// </summary>
        /// <returns>True quando a página de detalhes estiver carregada.</returns>
        public bool IsProductDetailsDisplayed()
        {
            return _driver.Url.Contains("/product_details/")
                && _driver.PageSource.Contains("Category")
                && _driver.PageSource.Contains("Availability");
        }
    }
}