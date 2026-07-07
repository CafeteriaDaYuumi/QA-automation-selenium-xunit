using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    public class CartPage
    {
        private readonly IWebDriver _driver;

        // Botão responsável por adicionar o primeiro produto ao carrinho.
        private readonly By _firstProductAddToCartButton =
            By.XPath(
                "//a[@data-product-id='1' and contains(@class,'add-to-cart')]"
            );

        // Botão exibido no modal para visualizar o carrinho.
        private readonly By _viewCartButton =
            By.XPath(
                "//u[contains(text(),'View Cart')]"
            );

        // Itens exibidos dentro do carrinho.
        private readonly By _cartItems =
            By.XPath(
                "//tr[contains(@id,'product')]"
            );

        // Botão responsável por remover o primeiro produto do carrinho.
        private readonly By _deleteFirstProductButton =
            By.XPath(
                "(//a[contains(@class,'cart_quantity_delete')])[1]"
            );

        // Inicializa a página do carrinho com a instância atual do WebDriver.
        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Acessa diretamente a página de produtos.
        public void OpenProductsPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/products"
            );
        }

        // Acessa diretamente a página do carrinho.
        public void OpenCartPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/view_cart"
            );
        }

        // Adiciona o primeiro produto exibido ao carrinho.
        public void AddFirstProductToCart()
        {
            ClickWithJavaScript(
                _firstProductAddToCartButton
            );
        }

        // Adiciona um produto ao carrinho pelo identificador interno.
        public void AddProductById(string productId)
        {
            _driver.Navigate().GoToUrl(
                $"https://automationexercise.com/add_to_cart/{productId}"
            );
        }

        // Acessa o carrinho pelo modal exibido após adicionar um produto.
        public void ViewCart()
        {
            _driver
                .FindElement(_viewCartButton)
                .Click();
        }

        // Remove o primeiro produto presente no carrinho.
        public void RemoveFirstProductFromCart()
        {
            _driver
                .FindElement(_deleteFirstProductButton)
                .Click();
        }

        // Verifica se existem produtos no carrinho.
        public bool HasProductsInCart()
        {
            return _driver
                .FindElements(_cartItems)
                .Count > 0;
        }

        // Retorna a quantidade total de produtos presentes no carrinho.
        public int GetCartItemsCount()
        {
            return _driver
                .FindElements(_cartItems)
                .Count;
        }

        // Verifica se o carrinho está vazio.
        public bool IsCartEmpty()
        {
            return _driver
                .FindElements(_cartItems)
                .Count == 0;
        }

        // Executa clique com JavaScript para reduzir falhas causadas
        // por anúncios, overlays ou elementos sobrepostos.
        private void ClickWithJavaScript(By locator)
        {
            IWebElement element =
                _driver.FindElement(locator);

            IJavaScriptExecutor js =
                (IJavaScriptExecutor)_driver;

            js.ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                element
            );

            js.ExecuteScript(
                "arguments[0].click();",
                element
            );
        }
    }
}