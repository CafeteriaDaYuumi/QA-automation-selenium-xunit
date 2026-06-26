using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    /// <summary>
    /// Página responsável pelas operações relacionadas
    /// ao carrinho de compras.
    /// </summary>
    public class CartPage
    {
        private readonly IWebDriver _driver;

        // Botão responsável por adicionar o primeiro produto ao carrinho.
        private readonly By _firstProductAddToCartButton =
            By.XPath("//a[@data-product-id='1' and contains(@class,'add-to-cart')]");

        // Botão exibido no modal para visualizar o carrinho.
        private readonly By _viewCartButton =
            By.XPath("//u[contains(text(),'View Cart')]");

        // Itens exibidos dentro do carrinho.
        private readonly By _cartItems =
            By.XPath("//tr[contains(@id,'product')]");

        // Botão responsável por remover o primeiro produto do carrinho.
        private readonly By _deleteFirstProductButton =
            By.XPath("(//a[contains(@class,'cart_quantity_delete')])[1]");

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenProductsPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/products"
            );
        }

        public void OpenCartPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/view_cart"
            );
        }

        public void AddFirstProductToCart()
        {
            ClickWithJavaScript(_firstProductAddToCartButton);
        }

        public void AddProductById(string productId)
        {
            _driver.Navigate().GoToUrl(
                $"https://automationexercise.com/add_to_cart/{productId}"
            );
        }

        public void ViewCart()
        {
            _driver.FindElement(_viewCartButton).Click();
        }

        public void RemoveFirstProductFromCart()
        {
            _driver.FindElement(_deleteFirstProductButton).Click();
        }

        public bool HasProductsInCart()
        {
            return _driver.FindElements(_cartItems).Count > 0;
        }

        public int GetCartItemsCount()
        {
            return _driver.FindElements(_cartItems).Count;
        }

        public bool IsCartEmpty()
        {
            return _driver.FindElements(_cartItems).Count == 0;
        }

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