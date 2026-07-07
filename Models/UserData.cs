namespace QA_automation_selenium_xunit.Models
{
    /// Representa os dados utilizados nos testes
    /// relacionados aos usuários da aplicação.
    public class UserData
    {
        /// Identificador do caso de teste associado aos dados.
        public string TestCase { get; set; } = string.Empty;

        /// Indica se o conjunto de dados deve ser utilizado
        /// durante a execução dos testes.
        public bool Execute { get; set; }

        /// Descrição da finalidade dos dados de teste.
        public string Description { get; set; } = string.Empty;

        /// Chave utilizada para identificar
        /// o conjunto de dados de teste.
        public string Key { get; set; } = string.Empty;

        /// E-mail utilizado durante os testes.
        public string Email { get; set; } = string.Empty;

    
        /// Senha utilizada durante os testes.
        public string Password { get; set; } = string.Empty;
    }
}