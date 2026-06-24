using QA_automation_selenium_xunit.Pages;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar o fluxo de cadastro
    /// de usuário na aplicação.
    /// </summary>
    [Collection("Sequential Tests")]
    public class CadastroTests : BaseTest
    {
        /// <summary>
        /// Valida se a área de cadastro pode ser acessada.
        /// </summary>
        [Fact]
        public void CT005_DeveAcessarAreaDeCadastro()
        {
            Console.WriteLine(
                "Executando CT005 - Deve acessar área de cadastro"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CadastroPage cadastroPage = new CadastroPage(Driver);

            cadastroPage.OpenCadastroPage();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT005_AcessarAreaDeCadastro"
            );

            Assert.True(cadastroPage.IsCadastroAreaDisplayed());
        }

        /// <summary>
        /// Valida se o sistema permite iniciar o cadastro
        /// utilizando nome e e-mail válidos.
        /// </summary>
        [Fact]
        public void CT006_DeveIniciarCadastroComDadosValidos()
        {
            Console.WriteLine(
                "Executando CT006 - Deve iniciar cadastro com dados válidos"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CadastroPage cadastroPage = new CadastroPage(Driver);

            cadastroPage.OpenCadastroPage();

            cadastroPage.StartSignup(
                "Usuario Teste",
                $"usuario.teste.{DateTime.Now.Ticks}@gmail.com"
            );

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT006_IniciarCadastroComDadosValidos"
            );

            Assert.True(cadastroPage.IsAccountInformationDisplayed());
        }

        /// <summary>
        /// Valida se o sistema exibe mensagem de erro
        /// ao tentar cadastrar um e-mail já existente.
        /// </summary>
        [Fact]
        public void CT007_DeveValidarEmailJaCadastrado()
        {
            Console.WriteLine(
                "Executando CT007 - Deve validar e-mail já cadastrado"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CadastroPage cadastroPage = new CadastroPage(Driver);

            cadastroPage.OpenCadastroPage();

            cadastroPage.StartSignup(
                "Usuario Existente",
                "QA-automation-selenium-xunit@gmail.com"
            );

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT007_EmailJaCadastrado"
            );

            Assert.Equal(
                "Email Address already exist!",
                cadastroPage.GetEmailAlreadyExistsMessage()
            );
        }

        /// <summary>
        /// Valida o comportamento do sistema quando o usuário
        /// tenta iniciar o cadastro sem preencher os campos obrigatórios.
        /// </summary>
        [Fact]
        public void CT008_DeveValidarCamposObrigatoriosNoCadastro()
        {
            Console.WriteLine(
                "Executando CT008 - Deve validar campos obrigatórios no cadastro"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CadastroPage cadastroPage = new CadastroPage(Driver);

            cadastroPage.OpenCadastroPage();

            cadastroPage.ClickSignup();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT008_CamposObrigatoriosCadastro"
            );

            Assert.True(cadastroPage.IsCadastroAreaDisplayed());
        }

        /// <summary>
        /// Valida o fluxo completo de criação e exclusão de conta.
        /// </summary>
        [Fact]
        public void CT009_DeveCriarEExcluirContaComSucesso()
        {
            Console.WriteLine(
                "Executando CT009 - Deve criar e excluir conta com sucesso"
            );

            Driver.Navigate().GoToUrl(ConfigReader.GetBaseUrl());

            CadastroPage cadastroPage = new CadastroPage(Driver);

            cadastroPage.OpenCadastroPage();

            cadastroPage.StartSignup(
                "Usuario Teste",
                $"usuario.teste.{DateTime.Now.Ticks}@gmail.com"
            );

            cadastroPage.FillAccountInformation("123456");
            cadastroPage.FillAddressInformation();
            cadastroPage.ClickCreateAccount();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT009_ContaCriada"
            );

            Assert.True(cadastroPage.IsAccountCreated());

            cadastroPage.ClickContinue();

            // Aguarda o carregamento após a criação da conta.
            // Solução temporária até a implementação de WaitHelper.
            Thread.Sleep(2000);

            cadastroPage.DeleteAccount();

            ScreenshotHelper.TakeScreenshot(
                Driver,
                "CT009_ContaExcluida"
            );

            Assert.True(cadastroPage.IsAccountDeleted());
        }
    }
} 