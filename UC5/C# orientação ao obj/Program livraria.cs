using System;
using Livraria;

class Program
{
    static void Main()
    {
       Livro l1 = new Livro();
        l1.Titulo = "Senhor dos anéis";
        l1.Autor = "J.R.R.Tolkien";
        l1.Ano = 2020;

        Livro l2 = new Livro();
        l2.Titulo = "Vestido de Noiva";
        l2.Autor = "Nelson Rodrigues";
        l2.Ano = 1943;

        //Console.WriteLine($"{l1.Titulo} - {l1.Autor} - ({l1.Ano})");
        //Console.WriteLine($"{l2.Titulo} - {l2.Autor} - ({l2.Ano})");

        l1.Atualizacao(2025);
        l1.ExibirInformacoes();
        l2.ExibirInformacoes();

        Console.WriteLine($"Idade do livro '{l2.Titulo}': {l2.CalcularIdade()} anos.");




    }
}