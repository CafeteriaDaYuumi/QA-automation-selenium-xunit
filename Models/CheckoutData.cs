namespace QA_automation_selenium_xunit.Models
{
    /// Representa os dados utilizados nos testes
    /// relacionados ao fluxo de checkout.
    public class CheckoutData
    {
        
        /// Identificador do produto utilizado no checkout.
        public string ProductId { get; set; } = string.Empty;

        /// Comentário adicionado ao pedido.
        public string Comment { get; set; } = string.Empty;

        /// Nome do titular informado no cartão.
        public string CardName { get; set; } = string.Empty;

        /// Número do cartão utilizado no pagamento.
        public string CardNumber { get; set; } = string.Empty;

        /// Código de segurança do cartão.
        public string Cvc { get; set; } = string.Empty;

        /// Mês de expiração do cartão.
        public string ExpirationMonth { get; set; } = string.Empty;

        /// Ano de expiração do cartão.
        public string ExpirationYear { get; set; } = string.Empty;
    }
}