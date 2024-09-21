using CSO.CSO.Application.Services;
using CSO.CSO.Domain.Entities;

namespace CSO.CSO.Domain.Configuration
{
    public class ConfiguracaoLivro
    {
        public List<Livro> livros { get; set; }
        public List<CriterioOrdenacao> criterioOrdenacao { get; set; }
    }
}
