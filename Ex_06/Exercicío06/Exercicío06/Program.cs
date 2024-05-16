using System;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização da classe Produto
            var produtoManager = new ProdutoManager();

            produtoManager.AdicionarProduto(new Produto("Camiseta", 19.99, 50));
            produtoManager.AdicionarProduto(new Produto("Calça Jeans", 39.99, 30));
            produtoManager.AdicionarProduto(new Produto("Tênis", 59.99, 20));

            produtoManager.ApresentarProdutos(); // Mostra todos os produtos na tela

            // Solicitar ao usuário o código do produto a ser consultado
            Console.Write("Digite o código do produto que deseja consultar: ");
            int codigoProduto = int.Parse(Console.ReadLine());

            // Consultando um produto pelo código inserido pelo usuário
            produtoManager.ConsultarProduto(codigoProduto);
        }
    }
}