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
        /// Nome da pasta utilizada para armazenar as evidências
        /// da execução atual.
        /// </summary>
        private static readonly string ExecutionFolder =
            DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

        /// <summary>
        /// Captura uma screenshot da página atual e salva na pasta
        /// de evidências da execução.
        /// </summary>
        /// <param name="driver">Instância do WebDriver.</param>
        /// <param name="testName">Nome do teste que gerou a evidência.</param>
        public static void TakeScreenshot(
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

            // Cria o caminho da pasta onde as evidências serão armazenadas.
            string folderPath = Path.Combine(
                projectPath,
                "Evidence",
                ExecutionFolder
            );

            // Cria a pasta caso ela não exista.
            Directory.CreateDirectory(folderPath);

            // Define o nome do arquivo da evidência.
            string fileName = $"{testName}.png";

            string filePath = Path.Combine(
                folderPath,
                fileName
            );

            // Captura a imagem da tela atual.
            Screenshot screenshot =
                ((ITakesScreenshot)driver).GetScreenshot();

            // Salva a evidência no diretório definido.
            screenshot.SaveAsFile(filePath);

            Console.WriteLine(
                $"Screenshot salvo em: {filePath}"
            );
        }
    }
}