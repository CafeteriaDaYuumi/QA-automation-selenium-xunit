using OpenQA.Selenium;

namespace QA_automation_selenium_xunit.Utils
{
    // Responsável pela captura e armazenamento de evidências
    // durante a execução dos testes automatizados.
    public static class ScreenshotHelper
    {
        // Nome da pasta utilizada para armazenar
        // todas as evidências da execução atual.
        private static readonly string ExecutionFolder =
            DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

        // Captura uma screenshot da página atual,
        // salva a evidência no diretório do projeto
        // e retorna o caminho completo da imagem.
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

            // Define o diretório onde
            // as evidências serão armazenadas.
            string evidenceDirectory = Path.Combine(
                projectPath,
                "Evidence",
                ExecutionFolder
            );

            // Cria o diretório caso ainda não exista.
            Directory.CreateDirectory(
                evidenceDirectory
            );

            // Define o caminho completo
            // do arquivo de evidência.
            string screenshotPath = Path.Combine(
                evidenceDirectory,
                $"{testName}.png"
            );

            // Captura a tela atual do navegador.
            Screenshot screenshot =
                ((ITakesScreenshot)driver)
                    .GetScreenshot();

            // Salva a imagem no diretório de evidências.
            screenshot.SaveAsFile(
                screenshotPath
            );

            Console.WriteLine(
                $"Screenshot salvo em: {screenshotPath}"
            );

            // Retorna o caminho completo
            // para utilização nos relatórios.
            return screenshotPath;
        }
    }
}