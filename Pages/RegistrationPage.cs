using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QA_automation_selenium_xunit.Pages
{
    public class RegistrationPage
    {
        private readonly IWebDriver _driver;

        // Menu responsável por acessar a área de login e cadastro.
        private readonly By _loginMenu =
            By.XPath(
                "//a[contains(text(),'Signup / Login')]"
            );

        // Campo de nome utilizado no cadastro inicial.
        private readonly By _nameField =
            By.XPath(
                "//input[@data-qa='signup-name']"
            );

        // Campo de e-mail utilizado no cadastro inicial.
        private readonly By _emailField =
            By.XPath(
                "//input[@data-qa='signup-email']"
            );

        // Botão responsável por iniciar o cadastro.
        private readonly By _signupButton =
            By.XPath(
                "//button[@data-qa='signup-button']"
            );

        // Mensagem exibida quando o e-mail informado já está cadastrado.
        private readonly By _emailAlreadyExistsMessage =
            By.XPath(
                "//p[contains(text(),'Email Address already exist!')]"
            );

        // Título exibido na área de criação de conta.
        private readonly By _newUserSignupTitle =
            By.XPath(
                "//h2[contains(text(),'New User Signup!')]"
            );

        // Título exibido na tela de informações da conta.
        private readonly By _accountInformationTitle =
            By.XPath(
                "//b[contains(text(),'Enter Account Information')]"
            );

        // Opção de gênero utilizada no cadastro completo.
        private readonly By _genderMr =
            By.Id("id_gender1");

        // Campo de senha da etapa de informações da conta.
        private readonly By _passwordField =
            By.Id("password");

        // Seletores de data de nascimento.
        private readonly By _daySelect =
            By.Id("days");

        private readonly By _monthSelect =
            By.Id("months");

        private readonly By _yearSelect =
            By.Id("years");

        // Campos de endereço utilizados no cadastro completo.
        private readonly By _firstNameField =
            By.Id("first_name");

        private readonly By _lastNameField =
            By.Id("last_name");

        private readonly By _addressField =
            By.Id("address1");

        private readonly By _countrySelect =
            By.Id("country");

        private readonly By _stateField =
            By.Id("state");

        private readonly By _cityField =
            By.Id("city");

        private readonly By _zipcodeField =
            By.Id("zipcode");

        private readonly By _mobileNumberField =
            By.Id("mobile_number");

        // Botão responsável por criar a conta.
        private readonly By _createAccountButton =
            By.XPath(
                "//button[@data-qa='create-account']"
            );

        // Mensagem exibida quando a conta é criada com sucesso.
        private readonly By _accountCreatedMessage =
            By.XPath(
                "//b[contains(text(),'Account Created!')]"
            );

        // Botão de continuar após criação ou exclusão da conta.
        private readonly By _continueButton =
            By.XPath(
                "//a[@data-qa='continue-button']"
            );

        // Mensagem exibida quando a conta é excluída com sucesso.
        private readonly By _accountDeletedMessage =
            By.XPath(
                "//b[contains(text(),'Account Deleted!')]"
            );

        // Inicializa a página de cadastro com a instância atual do WebDriver.
        public RegistrationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Acessa a área de login e cadastro da aplicação.
        public void OpenRegistrationPage()
        {
            _driver
                .FindElement(_loginMenu)
                .Click();
        }

        // Verifica se a área de cadastro está sendo exibida.
        public bool IsRegistrationAreaDisplayed()
        {
            return _driver
                .FindElement(_newUserSignupTitle)
                .Displayed;
        }

        // Verifica se a tela de informações da conta está sendo exibida.
        public bool IsAccountInformationDisplayed()
        {
            return _driver
                .FindElement(_accountInformationTitle)
                .Displayed;
        }

        // Preenche o campo de nome utilizado no cadastro.
        public void EnterName(string name)
        {
            _driver
                .FindElement(_nameField)
                .SendKeys(name);
        }

        // Preenche o campo de e-mail utilizado no cadastro.
        public void EnterEmail(string email)
        {
            _driver
                .FindElement(_emailField)
                .SendKeys(email);
        }

        // Realiza o clique no botão responsável por iniciar o cadastro.
        // Primeiro tenta o clique padrão do Selenium.
        // Caso anúncio ou iframe bloqueie o botão,
        // utiliza JavaScript como alternativa.
        public void ClickSignup()
        {
            IWebElement signupButton =
           _driver.FindElement(_signupButton);

            try
            {
                signupButton.Click();
            }
            catch (ElementClickInterceptedException)
            {
                IJavaScriptExecutor js =
                 (IJavaScriptExecutor)_driver;

                js.ExecuteScript(
                   "arguments[0].click();",
                   signupButton
               );
            }
        }

        // Executa o fluxo inicial de cadastro.
        public void StartSignup(string name, string email)
        {
            EnterName(name);
            EnterEmail(email);
            ClickSignup();
        }

        // Preenche as informações básicas da conta.
        public void FillAccountInformation(string password)
        {
            _driver
                .FindElement(_genderMr)
                .Click();

            _driver
                .FindElement(_passwordField)
                .SendKeys(password);

            new SelectElement(
                _driver.FindElement(_daySelect)
            ).SelectByValue("10");

            new SelectElement(
                _driver.FindElement(_monthSelect)
            ).SelectByValue("5");

            new SelectElement(
                _driver.FindElement(_yearSelect)
            ).SelectByValue("2000");
        }

        // Preenche as informações obrigatórias de endereço.
        public void FillAddressInformation()
        {
            _driver
                .FindElement(_firstNameField)
                .SendKeys("Usuario");

            _driver
                .FindElement(_lastNameField)
                .SendKeys("Teste");

            _driver
                .FindElement(_addressField)
                .SendKeys("Rua Teste, 123");

            new SelectElement(
                _driver.FindElement(_countrySelect)
            ).SelectByText("Canada");

            _driver
                .FindElement(_stateField)
                .SendKeys("Ontario");

            _driver
                .FindElement(_cityField)
                .SendKeys("Toronto");

            _driver
                .FindElement(_zipcodeField)
                .SendKeys("00000");

            _driver
                .FindElement(_mobileNumberField)
                .SendKeys("11999999999");
        }

        // Cria a conta utilizando JavaScript para reduzir falhas
        // causadas por anúncios ou elementos sobrepostos.
        public void ClickCreateAccount()
        {
            IWebElement createAccountButton =
                _driver.FindElement(_createAccountButton);

            IJavaScriptExecutor js =
                (IJavaScriptExecutor)_driver;

            js.ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                createAccountButton
            );

            js.ExecuteScript(
                "arguments[0].click();",
                createAccountButton
            );
        }

        // Verifica se a conta foi criada com sucesso.
        public bool IsAccountCreated()
        {
            return _driver
                .FindElement(_accountCreatedMessage)
                .Displayed;
        }

        // Continua o fluxo após a criação ou exclusão da conta.
        public void ClickContinue()
        {
            _driver
                .FindElement(_continueButton)
                .Click();
        }

        // Exclui a conta utilizando navegação direta como solução temporária
        // para reduzir falhas causadas por anúncios e redirecionamentos.
        public void DeleteAccount()
        {
            // TODO:
            // Implementar futuramente a exclusão pelo botão da interface.
            _driver.Navigate().GoToUrl(
                "https://automationexercise.com/delete_account"
            );
        }

        // Verifica se a conta foi excluída com sucesso.
        public bool IsAccountDeleted()
        {
            return _driver
                .FindElement(_accountDeletedMessage)
                .Displayed;
        }

        // Retorna a mensagem exibida quando o e-mail já está cadastrado.
        public string GetEmailAlreadyExistsMessage()
        {
            return _driver
                .FindElement(_emailAlreadyExistsMessage)
                .Text;
        }
    }
}