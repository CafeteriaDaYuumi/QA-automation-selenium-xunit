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
            try
            {
                string projectPath = Directory
                    .GetParent(AppContext.BaseDirectory)!
                    .Parent!
                    .Parent!
                    .Parent!
                    .FullName;

                string evidenceDirectory = Path.Combine(
                    projectPath,
                    "Evidence",
                    ExecutionFolder
                );

                Directory.CreateDirectory(evidenceDirectory);

                string screenshotPath = Path.Combine(
                    evidenceDirectory,
                    $"{testName}.png"
                );

                Screenshot screenshot =
                    ((ITakesScreenshot)driver)
                        .GetScreenshot();

                screenshot.SaveAsFile(screenshotPath);

                Console.WriteLine(
                    $"Screenshot salvo em: {screenshotPath}"
                );

                return screenshotPath;
            }
            catch (WebDriverException ex)
            {
                Console.WriteLine(
                    $"Falha ao capturar screenshot do teste {testName}: {ex.Message}"
                );

                return string.Empty;
            }
        }
    }
}