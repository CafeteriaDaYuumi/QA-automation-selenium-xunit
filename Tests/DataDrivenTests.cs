using QA_automation_selenium_xunit.Models;
using QA_automation_selenium_xunit.Pages;
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
        /// <summary>
        /// Valida a leitura da massa de usuários.
        /// </summary>
        [Fact]
        public void CT021_DeveLerMassaDeUsuarios()
        {
            Console.WriteLine(
                "Executando CT021 - Deve ler massa de usuários"
            );

            List<UserData> users =
                TestDataReader.GetDataList<UserData>("Users.json");

            Assert.NotEmpty(users);
            Assert.Contains(users, user => user.Key == "validUser");
        }

        /// <summary>
        /// Valida a leitura da massa de produtos.
        /// </summary>
        [Fact]
        public void CT022_DeveLerMassaDeProdutos()
        {
            Console.WriteLine(
                "Executando CT022 - Deve ler massa de produtos"
            );

            List<ProductData> products =
                TestDataReader.GetDataList<ProductData>("Products.json");

            Assert.NotEmpty(products);
            Assert.Contains(
                products,
                product => !string.IsNullOrWhiteSpace(product.ExistingProduct)
            );
        }

        /// <summary>
        /// Valida a leitura da massa de carrinho.
        /// </summary>
        [Fact]
        public void CT023_DeveLerMassaDeCarrinho()
        {
            Console.WriteLine(
                "Executando CT023 - Deve ler massa de carrinho"
            );

            List<CartData> cartItems =
                TestDataReader.GetDataList<CartData>("CartItems.json");

            Assert.NotEmpty(cartItems);
            Assert.Contains(
                cartItems,
                item => !string.IsNullOrWhiteSpace(item.ProductName)
            );
        }

        /// <summary>
        /// Valida a leitura da massa de checkout.
        /// </summary>
        [Fact]
        public void CT024_DeveLerMassaDeCheckout()
        {
            Console.WriteLine(
                "Executando CT024 - Deve ler massa de checkout"
            );

            List<CheckoutData> checkoutData =
                TestDataReader.GetDataList<CheckoutData>("CheckoutData.json");

            Assert.NotEmpty(checkoutData);
            Assert.Contains(
                checkoutData,
                data => !string.IsNullOrWhiteSpace(data.CardNumber)
            );
        }
    }
}