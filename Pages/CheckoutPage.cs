using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    /// <summary>
    /// Página responsável pelas operações relacionadas
    /// ao fluxo de checkout da aplicação.
    /// </summary>
    public class CheckoutPage
    {
        private readonly IWebDriver _driver;

        private readonly By _cartItems =
            By.XPath("//tr[contains(@id,'product')]");

        private readonly By _proceedToCheckoutButton =
            By.XPath("//a[contains(text(),'Proceed To Checkout')]");

        private readonly By _addressDetailsTitle =
            By.XPath("//h2[contains(text(),'Address Details')]");

        private readonly By _reviewOrderTitle =
            By.XPath("//h2[contains(text(),'Review Your Order')]");

        private readonly By _commentField =
            By.Name("message");

        private readonly By _placeOrderButton =
            By.XPath("//a[contains(text(),'Place Order')]");

        private readonly By _nameOnCardField =
            By.Name("name_on_card");

        private readonly By _cardNumberField =
            By.Name("card_number");

        private readonly By _cvcField =
            By.Name("cvc");

        private readonly By _expirationMonthField =
            By.Name("expiry_month");

        private readonly By _expirationYearField =
            By.Name("expiry_year");

        private readonly By _payAndConfirmButton =
            By.Id("submit");

        private readonly By _orderPlacedMessage =
            By.XPath("//b[contains(text(),'Order Placed!')]");

        public CheckoutPage(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Adiciona um produto ao carrinho utilizando a rota interna da aplicação.
        /// </summary>
        public void AddProductById(string productId)
        {
            _driver.Navigate().GoToUrl(
                $"https://automationexercise.com/add_to_cart/{productId}"
            );
        }

        /// <summary>
        /// Acessa diretamente a página do carrinho.
        /// </summary>
        public void OpenCartPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/view_cart"
            );
        }

        /// <summary>
        /// Verifica se existem produtos no carrinho.
        /// </summary>
        public bool HasProductsInCart()
        {
            return _driver.FindElements(_cartItems).Count > 0;
        }

        /// <summary>
        /// Avança do carrinho para a tela de checkout.
        /// </summary>
        public void ProceedToCheckout()
        {
            ClickWithJavaScript(_proceedToCheckoutButton);
        }

        /// <summary>
        /// Verifica se a tela de checkout está sendo exibida.
        /// </summary>
        public bool IsCheckoutPageDisplayed()
        {
            return _driver.FindElements(_addressDetailsTitle).Count > 0
                && _driver.FindElements(_reviewOrderTitle).Count > 0;
        }

        /// <summary>
        /// Preenche o comentário do pedido.
        /// </summary>
        public void EnterOrderComment(string comment)
        {
            _driver.FindElement(_commentField).SendKeys(comment);
        }

        /// <summary>
        /// Clica no botão responsável por seguir para o pagamento.
        /// </summary>
        public void ClickPlaceOrder()
        {
            ClickWithJavaScript(_placeOrderButton);
        }

        /// <summary>
        /// Verifica se a tela de pagamento está sendo exibida.
        /// </summary>
        public bool IsPaymentPageDisplayed()
        {
            return _driver.Url.Contains("/payment")
                && _driver.FindElements(_nameOnCardField).Count > 0
                && _driver.FindElements(_cardNumberField).Count > 0
                && _driver.FindElements(_cvcField).Count > 0
                && _driver.FindElements(_expirationMonthField).Count > 0
                && _driver.FindElements(_expirationYearField).Count > 0
                && _driver.FindElements(_payAndConfirmButton).Count > 0;
        }

        /// <summary>
        /// Preenche os dados de pagamento.
        /// </summary>
        public void FillPaymentInformation(
            string cardName,
            string cardNumber,
            string cvc,
            string expirationMonth,
            string expirationYear
        )
        {
            _driver.FindElement(_nameOnCardField).SendKeys(cardName);
            _driver.FindElement(_cardNumberField).SendKeys(cardNumber);
            _driver.FindElement(_cvcField).SendKeys(cvc);
            _driver.FindElement(_expirationMonthField).SendKeys(expirationMonth);
            _driver.FindElement(_expirationYearField).SendKeys(expirationYear);
        }

        /// <summary>
        /// Confirma o pagamento e finaliza o pedido.
        /// </summary>
        public void ClickPayAndConfirmOrder()
        {
            ClickWithJavaScript(_payAndConfirmButton);
        }

        /// <summary>
        /// Verifica se o pedido foi finalizado com sucesso.
        /// </summary>
        public bool IsOrderPlaced()
        {
            return _driver.FindElements(_orderPlacedMessage).Count > 0;
        }

        /// <summary>
        /// Realiza clique em um elemento utilizando JavaScript.
        /// </summary>
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