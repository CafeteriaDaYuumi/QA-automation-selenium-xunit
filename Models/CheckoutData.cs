namespace QA_automation_selenium_xunit.Models
{
    /// <summary>
    /// Representa os dados utilizados nos testes
    /// relacionados ao fluxo de checkout.
    /// </summary>
    public class CheckoutData
    {
        public string ProductId { get; set; } = string.Empty;

        public string Comment { get; set; } = string.Empty;

        public string CardName { get; set; } = string.Empty;

        public string CardNumber { get; set; } = string.Empty;

        public string Cvc { get; set; } = string.Empty;

        public string ExpirationMonth { get; set; } = string.Empty;

        public string ExpirationYear { get; set; } = string.Empty;
    }
}