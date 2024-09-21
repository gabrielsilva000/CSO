using CSO.CSO.Domain.Configuration;
using System.Text.Json;

namespace CSO.CSO.Infrastructure.Configuration
{
    public class CarregaLivroConfig
    {
        public ConfiguracaoLivro CarregaConfiguracao(string caminhoDoArquivo)
        {
            var json = File.ReadAllText(caminhoDoArquivo);
            return JsonSerializer.Deserialize<ConfiguracaoLivro>(json);
        }
    }
}
