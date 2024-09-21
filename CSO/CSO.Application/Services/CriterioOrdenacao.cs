using CSO.CSO.Domain.Entities;

namespace CSO.CSO.Application.Services
{
    public class CriterioOrdenacao
    {
        public Func<Livro, object> propriedade { get; set; }
        public OrdemDeOrdenacao ordenacao { get; set; }
    }
}
