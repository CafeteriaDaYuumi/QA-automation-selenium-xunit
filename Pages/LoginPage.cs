using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    /// <summary>
    /// Página responsável pelas operações de autenticação.
    /// </summary>
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Campo de e-mail utilizado no login.
        private readonly By _emailField =
            By.XPath("//input[@data-qa='login-email']");

        // Campo de senha utilizado no login.
        private readonly By _passwordField =
            By.XPath("//input[@data-qa='login-password']");

        // Botão responsável por enviar as credenciais.
        private readonly By _loginButton =
            By.XPath("//button[@data-qa='login-button']");

        // Botão responsável por encerrar a sessão do usuário.
        private readonly By _logoutButton =
            By.XPath("//a[contains(text(),'Logout')]");

        // Título exibido na área de login.
        private readonly By _loginTitle =
            By.XPath("//h2[contains(text(),'Login to your account')]");

        // Mensagem exibida quando o login é realizado com sucesso.
        private readonly By _loggedInMessage =
            By.XPath("//a[contains(text(),'Logged in as')]");

        // Mensagem exibida quando usuário ou senha são inválidos.
        private readonly By _loginErrorMessage =
            By.XPath("//p[contains(text(),'Your email or password is incorrect!')]");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Acessa a página de login.
        /// </summary>
        public void OpenLoginPage()
        {
            if (!_driver.Url.Contains("/login"))
            {
                _driver.FindElement(
                    By.XPath("//a[contains(text(),'Signup / Login')]")
                ).Click();
            }
        }
        /// <summary>
        /// Preenche o campo de e-mail.
        /// </summary>
        /// <param name="email">E-mail utilizado para autenticação.</param>
        public void EnterEmail(string email)
        {
            _driver.FindElement(_emailField).SendKeys(email);
        }

        /// <summary>
        /// Preenche o campo de senha.
        /// </summary>
        /// <param name="password">Senha utilizada para autenticação.</param>
        public void EnterPassword(string password)
        {
            _driver.FindElement(_passwordField).SendKeys(password);
        }

        /// <summary>
        /// Realiza o clique no botão de login.
        /// Utiliza JavaScript para evitar bloqueios causados
        /// por anúncios ou elementos sobrepostos.
        /// </summary>
        public void ClickLogin()
        {
            IWebElement loginButton = _driver.FindElement(_loginButton);

            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;

            js.ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                loginButton
            );

            js.ExecuteScript(
                "arguments[0].click();",
                loginButton
            );
        }

        /// <summary>
        /// Executa o fluxo completo de autenticação.
        /// </summary>
        /// <param name="email">E-mail do usuário.</param>
        /// <param name="password">Senha do usuário.</param>
        public void Login(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            ClickLogin();
        }

        /// <summary>
        /// Realiza logout do usuário autenticado.
        /// </summary>
        public void Logout()
        {
            _driver.FindElement(_logoutButton).Click();
        }

        /// <summary>
        /// Retorna a mensagem de erro exibida para login inválido.
        /// </summary>
        /// <returns>Texto da mensagem de erro.</returns>
        public string GetLoginErrorMessage()
        {
            return _driver.FindElement(_loginErrorMessage).Text;
        }

        /// <summary>
        /// Verifica se o usuário está autenticado.
        /// </summary>
        /// <returns>True quando o usuário estiver logado.</returns>
        public bool IsUserLoggedIn()
        {
            return _driver.FindElement(_loggedInMessage).Displayed;
        }

        /// <summary>
        /// Verifica se a área de login está sendo exibida.
        /// </summary>
        /// <returns>True quando a página de login estiver visível.</returns>
        public bool IsLoginPageDisplayed()
        {
            return _driver.FindElement(_loginTitle).Displayed;
        }
    }
}