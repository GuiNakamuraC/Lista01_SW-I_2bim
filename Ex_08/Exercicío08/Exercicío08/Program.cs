using System;

namespace Exercicío_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização
            Fabricante fabricante = new Fabricante(); // Cria um novo fabricante
            fabricante.Nome = "Empresa XYZ"; // Define o nome do fabricante
            fabricante.Endereco = "Rua ABC, 123"; // Define o endereço do fabricante
            fabricante.Cidade = "Cidade ABC"; // Define a cidade do fabricante

            Produto produto = new Produto(); // Cria um novo produto
            produto.Nome = "Produto A"; // Define o nome do produto
            produto.Preco = 19.99; // Define o preço do produto
            produto.Fabricante = fabricante; // Define o fabricante do produto

            Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}, Fabricante: {produto.Fabricante.Nome}");
        }
    }
}
