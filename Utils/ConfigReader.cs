using Newtonsoft.Json.Linq;

namespace QA_automation_selenium_xunit.Utils
{
    /// Responsável pela leitura das configurações da aplicação
    /// armazenadas no arquivo appsettings.json.
    public static class ConfigReader
    {
        private static readonly JObject Config;

        /// Carrega o arquivo de configuração durante a inicialização da classe.
        static ConfigReader()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    $"Arquivo de configuração não encontrado: {path}"
                );
            }

            string json = File.ReadAllText(path);

            Config = JObject.Parse(json);
        }

   
        /// Retorna a URL base configurada para execução dos testes.
        /// <returns>URL da aplicação.</returns>

        public static string GetValue(string key)
        {
            return Config[key]?.ToString()
                ?? throw new Exception($"Configuração '{key}' não encontrada.");
        }

        public static string GetBaseUrl()
        {
            return GetValue("BaseUrl");
        }
    }
}