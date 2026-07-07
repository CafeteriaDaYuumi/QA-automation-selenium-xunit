namespace QA_automation_selenium_xunit.Models
{
    /// Representa os dados utilizados nos testes
    /// relacionados ao carrinho de compras.
    public class CartData
    {
        /// Nome do produto.
        public string ProductName { get; set; } = string.Empty;

        /// Quantidade desejada.
        public int Quantity { get; set; }

        /// Indica se o produto deve ser removido
        /// durante o cenário de teste.
        public bool RemoveAfterAdd { get; set; }
    }
}