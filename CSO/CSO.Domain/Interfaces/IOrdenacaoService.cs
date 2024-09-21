using CSO.CSO.Domain.Entities;

namespace CSO.CSO.Domain.Interfaces
{
    public interface IOrdenacaoService
    {
        List<Livro> OrdenacaoLivros(List<Livro> livros);
    }
}
