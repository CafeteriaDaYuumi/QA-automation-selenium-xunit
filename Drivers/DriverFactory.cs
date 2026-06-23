using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_automation_selenium_xunit.Drivers
{
    /// <summary>
    /// Responsável por criar, configurar e encerrar instâncias do navegador
    /// utilizadas durante a execução dos testes automatizados.
    /// </summary>
    public class DriverFactory
    {
        private IWebDriver? _driver;

        /// <summary>
        /// Retorna uma instância configurada do ChromeDriver.
        /// Caso o navegador ainda não exista, ele será criado.
        /// </summary>
        /// <returns>Instância do IWebDriver.</returns>
        public IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                ChromeOptions options = new ChromeOptions();

                // Inicia o navegador maximizado.
                options.AddArgument("--start-maximized");

                // Desabilita notificações.
                options.AddArgument("--disable-notifications");

                // Desabilita pop-ups.
                options.AddArgument("--disable-popup-blocking");

                // Desabilita extensões do navegador.
                options.AddArgument("--disable-extensions");

                // Melhora desempenho em algumas máquinas.
                options.AddArgument("--disable-gpu");

                // Desabilita carregamento de imagens.
                options.AddArgument("--blink-settings=imagesEnabled=false");

                _driver = new ChromeDriver(options);

                // Tempo para localizar elementos.
                _driver.Manage().Timeouts().ImplicitWait =
                    TimeSpan.FromSeconds(5);

                // Tempo máximo de carregamento da página.
                _driver.Manage().Timeouts().PageLoad =
                    TimeSpan.FromSeconds(30);
            }

            return _driver;
        }

        /// <summary>
        /// Encerra a instância do navegador e libera os recursos utilizados.
        /// </summary>
        public void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}