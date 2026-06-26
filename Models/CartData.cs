namespace QA_automation_selenium_xunit.Models
{
    /// <summary>
    /// Representa os dados utilizados nos testes
    /// relacionados ao carrinho de compras.
    /// </summary>
    public class CartData
    {
        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Quantidade desejada.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Indica se o produto deve ser removido
        /// durante o cenário de teste.
        /// </summary>
        public bool RemoveAfterAdd { get; set; }
    }
}