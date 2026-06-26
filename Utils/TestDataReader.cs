using Newtonsoft.Json;
using QA_automation_selenium_xunit.Models;

namespace QA_automation_selenium_xunit.Utils
{
    /// <summary>
    /// Classe responsável pela leitura dos arquivos JSON
    /// utilizados como massa de dados dos testes automatizados.
    /// </summary>
    public static class TestDataReader
    {
        public static List<T> GetDataList<T>(string fileName)
        {
            string filePath = Path.Combine(
                AppContext.BaseDirectory,
                "TestData",
                fileName
            );

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(
                    $"Arquivo de massa de dados não encontrado: {filePath}"
                );
            }

            string jsonContent = File.ReadAllText(filePath);

            List<T>? data = JsonConvert.DeserializeObject<List<T>>(jsonContent);

            if (data == null || data.Count == 0)
            {
                throw new InvalidOperationException(
                    $"O arquivo {fileName} não possui dados válidos."
                );
            }

            return data;
        }

        public static T GetFirstData<T>(string fileName)
        {
            return GetDataList<T>(fileName).First();
        }

        /// <summary>
        /// Retorna um usuário específico do arquivo Users.json
        /// a partir da chave informada.
        /// Mantido para compatibilidade com os testes de login existentes.
        /// </summary>
        public static UserData GetUser(string key)
        {
            List<UserData> users = GetDataList<UserData>("Users.json");

            UserData? user = users.FirstOrDefault(
                item => item.Key == key
            );

            if (user == null)
            {
                throw new InvalidOperationException(
                    $"Usuário com a chave '{key}' não encontrado em Users.json."
                );
            }

            return user;
        }
    }
}