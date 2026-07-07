using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_automation_selenium_xunit.Drivers
{
    // Responsável por criar, configurar e encerrar
    // instâncias do navegador utilizadas nos testes.
    public class DriverFactory
    {
        private IWebDriver? _driver;

        // Retorna uma instância configurada do ChromeDriver.
        // Caso ainda não exista, uma nova instância será criada.
        public IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                ChromeOptions options =
                    new ChromeOptions();

                // Define estratégia de carregamento Eager.
                // Permite continuar a execução quando o HTML principal
                // estiver carregado, sem aguardar completamente
                // imagens, anúncios, iframes e outros recursos externos.
                options.PageLoadStrategy =
                    PageLoadStrategy.Eager;

                // Inicia o navegador maximizado.
                options.AddArgument(
                    "--start-maximized"
                );

                // Desabilita notificações do navegador.
                options.AddArgument(
                    "--disable-notifications"
                );

                // Desabilita pop-ups.
                options.AddArgument(
                    "--disable-popup-blocking"
                );

                // Desabilita extensões do navegador.
                options.AddArgument(
                    "--disable-extensions"
                );

                // Melhora o desempenho
                // em algumas máquinas.
                options.AddArgument(
                    "--disable-gpu"
                );

                // Desabilita o carregamento de imagens.
                // Estratégia utilizada para reduzir
                // interferências visuais e carregamentos externos.
                options.AddArgument(
                    "--blink-settings=imagesEnabled=false"
                );

                // Cria e configura o serviço responsável
                // pela comunicação com o ChromeDriver.
                ChromeDriverService service =
                    ChromeDriverService.CreateDefaultService();

                // Cria uma nova instância do ChromeDriver.
                // O timeout de 120 segundos é aplicado
                // à comunicação entre Selenium e ChromeDriver.
                _driver =
                    new ChromeDriver(
                        service,
                        options,
                        TimeSpan.FromSeconds(120)
                    );

                // Define o tempo máximo para
                // localização implícita de elementos.
                _driver.Manage()
                    .Timeouts()
                    .ImplicitWait =
                        TimeSpan.FromSeconds(5);

                // Define o tempo máximo permitido
                // para carregamento das páginas.
                _driver.Manage()
                    .Timeouts()
                    .PageLoad =
                        TimeSpan.FromSeconds(60);
            }

            return _driver;
        }

        // Encerra a instância atual do navegador
        // e libera os recursos utilizados.
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