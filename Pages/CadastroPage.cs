using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QA_automation_selenium_xunit.Pages
{
    /// <summary>
    /// Página responsável pelas operações de cadastro de usuário.
    /// Implementa as ações e validações relacionadas ao processo
    /// de criação de novas contas na aplicação.
    /// </summary>
    public class CadastroPage
    {
        private readonly IWebDriver _driver;

        // Menu responsável por acessar a área de Login/Cadastro.
        private readonly By _loginMenu =
            By.XPath("//a[contains(text(),'Signup / Login')]");

        // Campo de nome utilizado no cadastro inicial.
        private readonly By _nameField =
            By.XPath("//input[@data-qa='signup-name']");

        // Campo de e-mail utilizado no cadastro inicial.
        private readonly By _emailField =
            By.XPath("//input[@data-qa='signup-email']");

        // Botão responsável por iniciar o cadastro.
        private readonly By _signupButton =
            By.XPath("//button[@data-qa='signup-button']");

        // Mensagem exibida quando o e-mail informado já está cadastrado.
        private readonly By _emailAlreadyExistsMessage =
            By.XPath("//p[contains(text(),'Email Address already exist!')]");

        // Título exibido na área de criação de conta.
        private readonly By _newUserSignupTitle =
            By.XPath("//h2[contains(text(),'New User Signup!')]");

        // Título exibido na tela de informações da conta.
        private readonly By _accountInformationTitle =
            By.XPath("//b[contains(text(),'Enter Account Information')]");

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
            By.XPath("//button[@data-qa='create-account']");

        // Mensagem exibida quando a conta é criada com sucesso.
        private readonly By _accountCreatedMessage =
            By.XPath("//b[contains(text(),'Account Created!')]");

        // Botão de continuar após criação ou exclusão da conta.
        private readonly By _continueButton =
            By.XPath("//a[@data-qa='continue-button']");

        // Botão responsável por excluir a conta criada.
        private readonly By _deleteAccountButton =
            By.XPath("//a[contains(text(),'Delete Account')]");

        // Mensagem exibida quando a conta é excluída com sucesso.
        private readonly By _accountDeletedMessage =
            By.XPath("//b[contains(text(),'Account Deleted!')]");

        /// <summary>
        /// Construtor da página de cadastro.
        /// </summary>
        /// <param name="driver">Instância do WebDriver utilizada pelos testes.</param>
        public CadastroPage(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Acessa a área de Login/Cadastro da aplicação.
        /// </summary>
        public void OpenCadastroPage()
        {
            _driver.FindElement(_loginMenu).Click();
        }

        /// <summary>
        /// Verifica se a área de cadastro está sendo exibida.
        /// </summary>
        /// <returns>True quando a área de cadastro estiver visível.</returns>
        public bool IsCadastroAreaDisplayed()
        {
            return _driver.FindElement(_newUserSignupTitle).Displayed;
        }

        /// <summary>
        /// Verifica se a tela de informações da conta está sendo exibida.
        /// </summary>
        /// <returns>True quando a tela de informações da conta estiver visível.</returns>
        public bool IsAccountInformationDisplayed()
        {
            return _driver.FindElement(_accountInformationTitle).Displayed;
        }

        /// <summary>
        /// Preenche o campo de nome utilizado no cadastro.
        /// </summary>
        /// <param name="name">Nome do usuário.</param>
        public void EnterName(string name)
        {
            _driver.FindElement(_nameField).SendKeys(name);
        }

        /// <summary>
        /// Preenche o campo de e-mail utilizado no cadastro.
        /// </summary>
        /// <param name="email">E-mail do usuário.</param>
        public void EnterEmail(string email)
        {
            _driver.FindElement(_emailField).SendKeys(email);
        }

        /// <summary>
        /// Realiza o clique no botão de cadastro.
        /// </summary>
        public void ClickSignup()
        {
            _driver.FindElement(_signupButton).Click();
        }

        /// <summary>
        /// Executa o fluxo inicial de cadastro.
        /// </summary>
        /// <param name="name">Nome do usuário.</param>
        /// <param name="email">E-mail do usuário.</param>
        public void StartSignup(string name, string email)
        {
            EnterName(name);
            EnterEmail(email);
            ClickSignup();
        }

        /// <summary>
        /// Preenche as informações básicas da conta.
        /// </summary>
        /// <param name="password">Senha utilizada no cadastro.</param>
        public void FillAccountInformation(string password)
        {
            _driver.FindElement(_genderMr).Click();

            _driver.FindElement(_passwordField).SendKeys(password);

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

        /// <summary>
        /// Preenche as informações de endereço obrigatórias.
        /// </summary>
        public void FillAddressInformation()
        {
            _driver.FindElement(_firstNameField).SendKeys("Usuario");
            _driver.FindElement(_lastNameField).SendKeys("Teste");
            _driver.FindElement(_addressField).SendKeys("Rua Teste, 123");

            new SelectElement(
                _driver.FindElement(_countrySelect)
            ).SelectByText("Canada");

            _driver.FindElement(_stateField).SendKeys("Ontario");
            _driver.FindElement(_cityField).SendKeys("Toronto");
            _driver.FindElement(_zipcodeField).SendKeys("00000");
            _driver.FindElement(_mobileNumberField).SendKeys("11999999999");
        }

        /// <summary>
        /// Clica no botão responsável por criar a conta.
        /// </summary>
        public void ClickCreateAccount()
        {
            _driver.FindElement(_createAccountButton).Click();
        }

        /// <summary>
        /// Verifica se a conta foi criada com sucesso.
        /// </summary>
        /// <returns>True quando a mensagem de conta criada estiver visível.</returns>
        public bool IsAccountCreated()
        {
            return _driver.FindElement(_accountCreatedMessage).Displayed;
        }

        /// <summary>
        /// Clica no botão continuar após criação ou exclusão da conta.
        /// </summary>
        public void ClickContinue()
        {
            _driver.FindElement(_continueButton).Click();
        }

        /// <summary>
        /// Exclui a conta atualmente autenticada.
        /// </summary>
        public void DeleteAccount()
        {
            _driver.FindElement(_deleteAccountButton).Click();
        }

        /// <summary>
        /// Verifica se a conta foi excluída com sucesso.
        /// </summary>
        /// <returns>True quando a mensagem de conta excluída estiver visível.</returns>
        public bool IsAccountDeleted()
        {
            return _driver.FindElement(_accountDeletedMessage).Displayed;
        }

        /// <summary>
        /// Retorna a mensagem exibida quando o e-mail informado
        /// já possui cadastro no sistema.
        /// </summary>
        /// <returns>Texto da mensagem de erro.</returns>
        public string GetEmailAlreadyExistsMessage()
        {
            return _driver.FindElement(
                _emailAlreadyExistsMessage
            ).Text;
        }
    }
}