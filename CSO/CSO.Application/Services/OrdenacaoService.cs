using CSO.CSO.Domain.Entities;
using CSO.CSO.Domain.Interfaces;


namespace CSO.CSO.Application.Services
{
    public class OrdenacaoService : IOrdenacaoService
    {
        private readonly List<CriterioOrdenacao> _criterioOrdenacao;

        public OrdenacaoService(List<CriterioOrdenacao> criterioOrdenacao)
        {
            _criterioOrdenacao = criterioOrdenacao;
        }

        public List<Livro> OrdenacaoLivros(List<Livro> livros)
        {
            var livrosOrdenados = livros.AsQueryable();

            foreach (var criterio in _criterioOrdenacao)
            {

                if (criterio.ordenacao == OrdemDeOrdenacao.ascendente)
                {
                    livrosOrdenados = livrosOrdenados.OrderBy(criterio.propriedade).AsQueryable(); ;
                }
                else
                {
                    livrosOrdenados = livrosOrdenados.OrderByDescending(criterio.propriedade).AsQueryable(); ;
                }
            }

            return livrosOrdenados.ToList();
        }
    }
}
