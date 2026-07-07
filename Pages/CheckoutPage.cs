using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    public class CheckoutPage
    {
        private readonly IWebDriver _driver;

        // Itens exibidos dentro do carrinho.
        private readonly By _cartItems =
            By.XPath(
                "//tr[contains(@id,'product')]"
            );

        // Botão responsável por avançar para o checkout.
        private readonly By _proceedToCheckoutButton =
            By.XPath(
                "//a[contains(text(),'Proceed To Checkout')]"
            );

        // Título da seção de detalhes do endereço.
        private readonly By _addressDetailsTitle =
            By.XPath(
                "//h2[contains(text(),'Address Details')]"
            );

        // Título da seção de revisão do pedido.
        private readonly By _reviewOrderTitle =
            By.XPath(
                "//h2[contains(text(),'Review Your Order')]"
            );

        // Campo utilizado para inserir comentários sobre o pedido.
        private readonly By _commentField =
            By.Name("message");

        // Botão responsável por avançar para a etapa de pagamento.
        private readonly By _placeOrderButton =
            By.XPath(
                "//a[contains(text(),'Place Order')]"
            );

        // Campo utilizado para informar o nome presente no cartão.
        private readonly By _nameOnCardField =
            By.Name("name_on_card");

        // Campo utilizado para informar o número do cartão.
        private readonly By _cardNumberField =
            By.Name("card_number");

        // Campo utilizado para informar o código de segurança do cartão.
        private readonly By _cvcField =
            By.Name("cvc");

        // Campo utilizado para informar o mês de expiração.
        private readonly By _expirationMonthField =
            By.Name("expiry_month");

        // Campo utilizado para informar o ano de expiração.
        private readonly By _expirationYearField =
            By.Name("expiry_year");

        // Botão responsável por confirmar o pagamento e o pedido.
        private readonly By _payAndConfirmButton =
            By.Id("submit");

        // Mensagem exibida após a finalização do pedido.
        private readonly By _orderPlacedMessage =
            By.XPath(
                "//b[contains(text(),'Order Placed!')]"
            );

        // Inicializa a página de checkout com a instância atual do WebDriver.
        public CheckoutPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Adiciona um produto ao carrinho pelo identificador interno.
        public void AddProductById(string productId)
        {
            _driver.Navigate().GoToUrl(
                $"https://automationexercise.com/add_to_cart/{productId}"
            );
        }

        // Acessa diretamente a página do carrinho.
        public void OpenCartPage()
        {
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/view_cart"
            );
        }

        // Verifica se existem produtos no carrinho.
        public bool HasProductsInCart()
        {
            return _driver
                .FindElements(_cartItems)
                .Count > 0;
        }

        // Avança do carrinho para a página de checkout.
        public void ProceedToCheckout()
        {
            ClickWithJavaScript(
                _proceedToCheckoutButton
            );
        }

        // Verifica se a página de checkout está sendo exibida.
        public bool IsCheckoutPageDisplayed()
        {
            return _driver
                .FindElements(_addressDetailsTitle)
                .Count > 0
                &&
                _driver
                .FindElements(_reviewOrderTitle)
                .Count > 0;
        }

        // Preenche o campo de comentário do pedido.
        public void EnterOrderComment(string comment)
        {
            _driver
                .FindElement(_commentField)
                .SendKeys(comment);
        }

        // Avança para a etapa de pagamento.
        public void ClickPlaceOrder()
        {
            ClickWithJavaScript(
                _placeOrderButton
            );
        }

        // Verifica se a página de pagamento está sendo exibida.
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

        // Preenche os dados utilizados durante o pagamento.
        public void FillPaymentInformation(
            string cardName,
            string cardNumber,
            string cvc,
            string expirationMonth,
            string expirationYear
        )
        {
            _driver
                .FindElement(_nameOnCardField)
                .SendKeys(cardName);

            _driver
                .FindElement(_cardNumberField)
                .SendKeys(cardNumber);

            _driver
                .FindElement(_cvcField)
                .SendKeys(cvc);

            _driver
                .FindElement(_expirationMonthField)
                .SendKeys(expirationMonth);

            _driver
                .FindElement(_expirationYearField)
                .SendKeys(expirationYear);
        }

        // Confirma o pagamento e finaliza o pedido.
        public void ClickPayAndConfirmOrder()
        {
            ClickWithJavaScript(
                _payAndConfirmButton
            );
        }

        // Verifica se o pedido foi finalizado com sucesso.
        public bool IsOrderPlaced()
        {
            return _driver
                .FindElements(_orderPlacedMessage)
                .Count > 0;
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