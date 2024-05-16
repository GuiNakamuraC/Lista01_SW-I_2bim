using System;
using System.Collections.Generic;

namespace Exercicio_01
{
    public class Produto
    {
        private static int proximoCodigo = 1; // Variável estática para gerar o próximo código de produto

        // Propriedades de somente leitura para Código, Nome e Preço
        public int Codigo { get; } = proximoCodigo++; // Cada novo produto recebe um código único incremental
        public string Nome { get; }
        public double Preco { get; }
        public int QuantidadeEmEstoque { get; private set; }

        // Construtor para inicializar um produto
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        // Método para adicionar produtos ao estoque
        public void AdicionarAoEstoque(int quantidade)
        {
            QuantidadeEmEstoque += quantidade; // Adiciona a quantidade especificada ao estoque do produto
            Console.WriteLine($"{quantidade} unidades de {Nome} adicionadas ao estoque.");
        }

        // Método para remover produtos do estoque
        public void RemoverDoEstoque(int quantidade)
        {
            if (quantidade > QuantidadeEmEstoque) // Verifica se a quantidade especificada é maior do que a disponível no estoque
                Console.WriteLine($"Não há {quantidade} unidades de {Nome} disponíveis no estoque.");
            else
            {
                QuantidadeEmEstoque -= quantidade; // Remove a quantidade especificada do estoque do produto
                Console.WriteLine($"{quantidade} unidades de {Nome} removidas do estoque."); 
            }
        }
    }

    public class ProdutoManager
    {
        private List<Produto> produtos = new(); // Lista para armazenar os produtos

        // Método para adicionar um produto à lista de produtos
        public void AdicionarProduto(Produto produto) => produtos.Add(produto);

        // Método para apresentar todos os produtos na tela
        public void ApresentarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos) // Itera sobre todos os produtos na lista
                Console.WriteLine($"Código: {produto.Codigo}, Produto: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
        }

        // Método para consultar um produto pelo código
        public void ConsultarProduto(int codigo)
        {
            var produto = produtos.Find(p => p.Codigo == codigo); // Busca o produto na lista pelo código especificado
            if (produto != null)
                Console.WriteLine($"Produto encontrado - Código: {produto.Codigo}, Produto: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
            else
                Console.WriteLine("Produto não encontrado.");
        }
    }
}
