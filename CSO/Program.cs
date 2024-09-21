using CSO.CSO.Application.Services;
using CSO.CSO.Domain.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        var livros = new List<Livro>();

        while (true) {
            Console.WriteLine("Digite o título do livro (ou 'sair' para encerrar):");
            var titulo = Console.ReadLine();
            if (titulo.ToLower() == "sair") break;

            Console.WriteLine("Digite o autor do livro:");
            var autor = Console.ReadLine();

            Console.WriteLine("Digite o ano do livro:");
            if (!int.TryParse(Console.ReadLine(), out var edicao))
            {
                Console.WriteLine("Ano inválido. Tente novamente.");
                continue;
            }
            livros.Add(new Livro { titulo = titulo, autor = autor, edicao = edicao });
        }

        if (livros.Count == 0)
        {
            throw new Exception("Nenhum livro foi fornecido. Por favor, adicione pelo menos um livro.");
        }

        var ordenacaoService1 = new OrdenacaoService(new List<CriterioOrdenacao>
        {
            new CriterioOrdenacao { propriedade = livro => livro.titulo, ordenacao = OrdemDeOrdenacao.ascendente }
        });

        var ordenacaoService2 = new OrdenacaoService(new List<CriterioOrdenacao>
        {
            new CriterioOrdenacao { propriedade = livro => livro.titulo, ordenacao = OrdemDeOrdenacao.descendente },
            new CriterioOrdenacao { propriedade = livro => livro.autor, ordenacao = OrdemDeOrdenacao.ascendente }
        });

        var ordenacaoService3 = new OrdenacaoService(new List<CriterioOrdenacao>
        {
            new CriterioOrdenacao { propriedade = livro => livro.titulo, ordenacao = OrdemDeOrdenacao.ascendente },
            new CriterioOrdenacao { propriedade = livro => livro.autor, ordenacao = OrdemDeOrdenacao.descendente },
            new CriterioOrdenacao { propriedade = livro => livro.edicao, ordenacao = OrdemDeOrdenacao.descendente }
        });

        Console.WriteLine("\nLivros ordenados por título (ascendente):");
        PrintLivro(ordenacaoService1.OrdenacaoLivros(livros));

        Console.WriteLine("\nLivros ordenados por autor (ascendente) e título (descendente):");
        PrintLivro(ordenacaoService2.OrdenacaoLivros(livros));

        Console.WriteLine("\nLivros ordenados por ano (descendente), autor (descendente) e título (ascendente):");
        PrintLivro(ordenacaoService3.OrdenacaoLivros(livros));
    }

    private static void PrintLivro(List<Livro> livros)
    {
        foreach (var livro in livros)
        {
            Console.WriteLine($"Título: {livro.titulo}, Autor: {livro.autor}, Ano: {livro.edicao}");
        }
    }
}