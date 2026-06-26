namespace QA_automation_selenium_xunit.Models
{
    /// <summary>
    /// Modelo genérico utilizado para representar
    /// uma massa de dados de testes.
    /// </summary>
    public class TestDataModel
    {
        /// <summary>
        /// Identificador do cenário de teste.
        /// </summary>
        public string TestCase { get; set; } = string.Empty;

        /// <summary>
        /// Indica se o cenário deve ser executado.
        /// </summary>
        public bool Execute { get; set; }

        /// <summary>
        /// Descrição da massa de dados.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}