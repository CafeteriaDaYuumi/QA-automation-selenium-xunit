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
        /// Captura uma screenshot da página atual e salva na pasta de evidências.
        /// </summary>
        /// <param name="driver">Instância do WebDriver.</param>
        /// <param name="testName">Nome do teste que gerou a evidência.</param>
        public static void TakeScreenshot(IWebDriver driver, string testName)
        {
            string projectPath = Directory
                .GetParent(AppContext.BaseDirectory)!
                .Parent!
                .Parent!
                .Parent!
                .FullName;

            string folderPath = Path.Combine(
                projectPath,
                "Evidence",
                "Screenshots"
            );

            // Cria a pasta caso ela não exista.
            Directory.CreateDirectory(folderPath);

            string fileName =
                $"{testName}_{DateTime.Now:yyyyMMdd_HHmmss}.png";

            string filePath = Path.Combine(folderPath, fileName);

            Screenshot screenshot =
                ((ITakesScreenshot)driver).GetScreenshot();

            screenshot.SaveAsFile(filePath);

            Console.WriteLine($"Screenshot salvo em: {filePath}");

             /*
             Planejamento para sprint 8

             Evidence
                │
                └── 2026-06-22_15-30-45
                        ├── LoginValido.png
                        ├── LoginInvalido.png
                        └── Checkout.png
             */

        }
    }
   
}