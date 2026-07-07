namespace QA_automation_selenium_xunit.Models
{
    /// Representa os dados utilizados nos testes
    /// relacionados ao cadastro de usuários.
    public class RegistrationData
    {
        /// Nome do usuário utilizado no cadastro.
        public string Name { get; set; } = string.Empty;

        /// E-mail do usuário utilizado no cadastro.
        public string Email { get; set; } = string.Empty;

        /// Senha do usuário utilizada no cadastro.
        public string Password { get; set; } = string.Empty;
    }
}