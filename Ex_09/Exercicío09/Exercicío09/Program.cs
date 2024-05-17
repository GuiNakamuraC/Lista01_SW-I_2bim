using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Livro livro = new Livro("Harry Potter", "J.K. Rowling");

                // Exibindo as informações do livro
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
            }
            catch (ArgumentException ex)
            {
                // Capturando a exceção caso o título ou o autor sejam vazios
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}