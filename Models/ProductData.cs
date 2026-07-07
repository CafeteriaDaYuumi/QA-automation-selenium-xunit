namespace QA_automation_selenium_xunit.Models
{
    /// Representa os dados utilizados nos testes
    /// relacionados à pesquisa de produtos.
    public class ProductData
    {
        /// Nome de um produto existente utilizado
        /// nos cenários positivos de pesquisa.
        public string ExistingProduct { get; set; } = string.Empty;

        /// Nome de um produto inexistente utilizado
        /// nos cenários negativos de pesquisa.
        public string NonExistingProduct { get; set; } = string.Empty;
    }
}