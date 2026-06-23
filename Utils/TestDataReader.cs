using Newtonsoft.Json.Linq;
using QA_automation_selenium_xunit.Models;

namespace QA_automation_selenium_xunit.Utils
{
    /// <summary>
    /// Responsável pela leitura das massas de dados
    /// utilizadas durante a execução dos testes.
    /// </summary>
    public static class TestDataReader
    {
        private static readonly JObject Data;

        /// <summary>
        /// Carrega o arquivo Users.json durante a inicialização da classe.
        /// </summary>
        static TestDataReader()
        {
            string path = Path.Combine(
                AppContext.BaseDirectory,
                "TestData",
                "Users.json"
            );

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    $"Arquivo de massa de dados não encontrado: {path}"
                );
            }

            string json = File.ReadAllText(path);

            Data = JObject.Parse(json);
        }

        /// <summary>
        /// Retorna um usuário da massa de dados.
        /// </summary>
        /// <param name="userType">
        /// Nome do usuário configurado no arquivo JSON.
        /// Exemplo: validUser ou invalidUser.
        /// </param>
        /// <returns>Objeto contendo e-mail e senha.</returns>
        public static UserData GetUser(string userType)
        {
            var user = Data[userType];

            if (user == null)
            {
                throw new Exception(
                    $"Usuário '{userType}' não encontrado no arquivo Users.json."
                );
            }

            return new UserData
            {
                Email = user["email"]?.ToString() ?? string.Empty,
                Password = user["password"]?.ToString() ?? string.Empty
            };
        }
    }
}