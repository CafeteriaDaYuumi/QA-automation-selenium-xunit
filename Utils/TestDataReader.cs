using Newtonsoft.Json;
using QA_automation_selenium_xunit.Models;

namespace QA_automation_selenium_xunit.Utils
{
    // Responsável pela leitura dos arquivos JSON
    // utilizados como massa de dados dos testes automatizados.
    public static class TestDataReader
    {
        // Carrega e desserializa uma lista de dados
        // a partir do arquivo JSON informado.
        public static List<T> GetDataList<T>(string fileName)
        {
            string filePath = Path.Combine(
                AppContext.BaseDirectory,
                "TestData",
                fileName
            );

            // Valida se o arquivo informado existe.
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(
                    $"Arquivo de massa de dados não encontrado: {filePath}"
                );
            }

            // Realiza a leitura completa
            // do conteúdo do arquivo JSON.
            string jsonContent =
                File.ReadAllText(filePath);

            // Desserializa o conteúdo JSON
            // para uma lista do tipo informado.
            List<T>? data =
                JsonConvert.DeserializeObject<List<T>>(
                    jsonContent
                );

            // Valida se o arquivo possui
            // uma massa de dados válida.
            if (data == null || data.Count == 0)
            {
                throw new InvalidOperationException(
                    $"O arquivo {fileName} não possui dados válidos."
                );
            }

            return data;
        }

        // Retorna o primeiro registro encontrado
        // no arquivo JSON informado.
        public static T GetFirstData<T>(string fileName)
        {
            return GetDataList<T>(fileName)
                .First();
        }

        // Retorna um usuário específico do arquivo Users.json
        // utilizando a chave informada.
        // Mantido para compatibilidade com os testes de login.
        public static UserData GetUser(string key)
        {
            List<UserData> users =
                GetDataList<UserData>(
                    "Users.json"
                );

            UserData? user =
                users.FirstOrDefault(
                    item => item.Key == key
                );

            // Valida se o usuário solicitado
            // foi encontrado na massa de dados.
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