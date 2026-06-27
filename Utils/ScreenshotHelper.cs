using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Utils
{
    /// <summary>
    /// Responsável pela captura e armazenamento de evidências
    /// durante a execução dos testes automatizados.
    /// </summary>
    public static class ScreenshotHelper
    {
        /// <summary>
        /// Nome da pasta utilizada para armazenar todas as evidências
        /// da execução atual dos testes.
        /// </summary>
        private static readonly string ExecutionFolder =
            DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

        /// <summary>
        /// Captura uma screenshot da página atual, salva a evidência
        /// no diretório do projeto e retorna o caminho completo da imagem.
        /// O caminho retornado pode ser utilizado em relatórios HTML,
        /// como o ExtentReports.
        /// </summary>
        /// <param name="driver">
        /// Instância do WebDriver responsável pela execução do teste.
        /// </param>
        /// <param name="testName">
        /// Nome do teste utilizado como nome da captura.
        /// </param>
        /// <returns>
        /// Caminho completo da imagem salva.
        /// </returns>
        public static string TakeScreenshot(
            IWebDriver driver,
            string testName)
        {
            // Obtém o diretório raiz do projeto.
            string projectPath = Directory
                .GetParent(AppContext.BaseDirectory)!
                .Parent!
                .Parent!
                .Parent!
                .FullName;

            // Define o diretório onde as evidências serão armazenadas.
            string evidenceDirectory = Path.Combine(
                projectPath,
                "Evidence",
                ExecutionFolder
            );

            // Cria o diretório caso ainda não exista.
            Directory.CreateDirectory(evidenceDirectory);

            // Define o caminho completo do arquivo.
            string screenshotPath = Path.Combine(
                evidenceDirectory,
                $"{testName}.png"
            );

            // Captura a tela atual.
            Screenshot screenshot =
                ((ITakesScreenshot)driver).GetScreenshot();

            // Salva a imagem.
            screenshot.SaveAsFile(screenshotPath);

            Console.WriteLine(
                $"Screenshot salvo em: {screenshotPath}"
            );

            // Retorna o caminho para utilização em relatórios.
            return screenshotPath;
        }
    }
}