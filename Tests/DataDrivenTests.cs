using QA_automation_selenium_xunit.Models;
using QA_automation_selenium_xunit.Utils;
using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    /// <summary>
    /// Testes responsáveis por validar a execução
    /// orientada a dados utilizando massas externas em JSON.
    /// </summary>
    [Collection("Sequential Tests")]
    public class DataDrivenTests : BaseTest
    {
        [Fact]
        public void CT021_DeveLerMassaDeUsuarios()
        {
            ReportHelper.CreateTest("CT021 - Deve ler massa de usuários");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT021 - Deve ler massa de usuários");

                List<UserData> users =
                    TestDataReader.GetDataList<UserData>("Users.json");

                Assert.NotEmpty(users);
                Assert.Contains(users, user => user.Key == "validUser");

                ReportHelper.LogPass("Massa de usuários carregada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");
                throw;
            }
        }

        [Fact]
        public void CT022_DeveLerMassaDeProdutos()
        {
            ReportHelper.CreateTest("CT022 - Deve ler massa de produtos");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT022 - Deve ler massa de produtos");

                List<ProductData> products =
                    TestDataReader.GetDataList<ProductData>("Products.json");

                Assert.NotEmpty(products);

                Assert.Contains(
                    products,
                    product => !string.IsNullOrWhiteSpace(product.ExistingProduct)
                );

                ReportHelper.LogPass("Massa de produtos carregada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");
                throw;
            }
        }

        [Fact]
        public void CT023_DeveLerMassaDeCarrinho()
        {
            ReportHelper.CreateTest("CT023 - Deve ler massa de carrinho");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT023 - Deve ler massa de carrinho");

                List<CartData> cartItems =
                    TestDataReader.GetDataList<CartData>("CartItems.json");

                Assert.NotEmpty(cartItems);

                Assert.Contains(
                    cartItems,
                    item => !string.IsNullOrWhiteSpace(item.ProductName)
                );

                ReportHelper.LogPass("Massa de carrinho carregada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");
                throw;
            }
        }

        [Fact]
        public void CT024_DeveLerMassaDeCheckout()
        {
            ReportHelper.CreateTest("CT024 - Deve ler massa de checkout");
            ReportHelper.LogInfo("Iniciando execução do teste.");

            try
            {
                Console.WriteLine("Executando CT024 - Deve ler massa de checkout");

                List<CheckoutData> checkoutData =
                    TestDataReader.GetDataList<CheckoutData>("CheckoutData.json");

                Assert.NotEmpty(checkoutData);

                Assert.Contains(
                    checkoutData,
                    data => !string.IsNullOrWhiteSpace(data.CardNumber)
                );

                ReportHelper.LogPass("Massa de checkout carregada com sucesso.");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Falha durante a execução: {ex.Message}");
                throw;
            }
        }
    }
}