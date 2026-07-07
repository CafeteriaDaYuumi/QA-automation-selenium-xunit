using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Campo de e-mail utilizado no login.
        private readonly By _emailField =
            By.XPath(
                "//input[@data-qa='login-email']"
            );

        // Campo de senha utilizado no login.
        private readonly By _passwordField =
            By.XPath(
                "//input[@data-qa='login-password']"
            );

        // Botão responsável por enviar as credenciais.
        private readonly By _loginButton =
            By.XPath(
                "//button[@data-qa='login-button']"
            );

        // Botão responsável por encerrar a sessão do usuário.
        private readonly By _logoutButton =
            By.XPath(
                "//a[contains(text(),'Logout')]"
            );

        // Título exibido na área de login.
        private readonly By _loginTitle =
            By.XPath(
                "//h2[contains(text(),'Login to your account')]"
            );

        // Mensagem exibida quando o login é realizado com sucesso.
        private readonly By _loggedInMessage =
            By.XPath(
                "//a[contains(text(),'Logged in as')]"
            );

        // Mensagem exibida quando usuário ou senha são inválidos.
        private readonly By _loginErrorMessage =
            By.XPath(
                "//p[contains(text(),'Your email or password is incorrect!')]"
            );

        // Inicializa a página de login com a instância atual do WebDriver.
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Acessa a página de login quando o navegador
        // ainda não estiver na rota correspondente.
        public void OpenLoginPage()
        {
            if (!_driver.Url.Contains("/login"))
            {
                _driver
                    .FindElement(
                        By.XPath(
                            "//a[contains(text(),'Signup / Login')]"
                        )
                    )
                    .Click();
            }
        }

        // Preenche o campo de e-mail.
        public void EnterEmail(string email)
        {
            _driver
                .FindElement(_emailField)
                .SendKeys(email);
        }

        // Preenche o campo de senha.
        public void EnterPassword(string password)
        {
            _driver
                .FindElement(_passwordField)
                .SendKeys(password);
        }

        // Realiza o clique no botão de login.
        // Primeiro tenta o clique padrão do Selenium.
        // Caso algum anúncio ou overlay bloqueie o clique,
        // utiliza JavaScript como alternativa.
        public void ClickLogin()
        {
            IWebElement loginButton =
                _driver.FindElement(_loginButton);

            try
            {
                loginButton.Click();
            }
            catch (ElementClickInterceptedException)
            {
                IJavaScriptExecutor js =
                    (IJavaScriptExecutor)_driver;

                js.ExecuteScript(
                    "arguments[0].click();",
                    loginButton
                );
            }
        }

        // Executa o fluxo completo de autenticação.
        public void Login(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            ClickLogin();
        }

        // Realiza o logout do usuário autenticado.
        public void Logout()
        {
            IWebElement logoutButton =
                _driver.FindElement(_logoutButton);

            try
            {
                logoutButton.Click();
            }
            catch (ElementClickInterceptedException)
            {
                IJavaScriptExecutor js =
                    (IJavaScriptExecutor)_driver;

                js.ExecuteScript(
                    "arguments[0].click();",
                    logoutButton
                );
            }
        }

        // Retorna a mensagem de erro exibida para login inválido.
        public string GetLoginErrorMessage()
        {
            return _driver
                .FindElement(_loginErrorMessage)
                .Text;
        }

        // Verifica se o usuário está autenticado.
        public bool IsUserLoggedIn()
        {
            return _driver
                .FindElement(_loggedInMessage)
                .Displayed;
        }


        // Verifica se a página de login está sendo exibida.
        public bool IsLoginPageDisplayed()
        {
            return _driver.Url.Contains("/login")
                || _driver.FindElements(_loginTitle).Count > 0
                || _driver.FindElements(_emailField).Count > 0;
        }
    }
}