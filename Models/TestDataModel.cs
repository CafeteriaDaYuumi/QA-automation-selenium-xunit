namespace QA_automation_selenium_xunit.Models
{
    /// Modelo genérico utilizado para representar
    /// uma massa de dados de testes.
    public class TestDataModel
    {
        /// Identificador do cenário de teste.
        public string TestCase { get; set; } = string.Empty;

        /// Indica se o cenário deve ser executado.
        public bool Execute { get; set; }


        /// Descrição da massa de dados.
        public string Description { get; set; } = string.Empty;
    }
}