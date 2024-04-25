namespace Exercicío_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("01. Crie uma classe Produto com atributos como nome, preço e quantidade em estoque. Implemente um construtor e métodos para adicionar e remover itens do estoque.");
            Console.WriteLine("-----------------------------------------------------------");

            // Exemplo de utilização da classe Produto
            Produto produto = new Produto("Camiseta", 19.99, 50);

            Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");

            produto.AdicionarAoEstoque(20);
            Console.WriteLine($"Novo estoque: {produto.QuantidadeEmEstoque}");

            produto.RemoverDoEstoque(10);
            Console.WriteLine($"Novo estoque: {produto.QuantidadeEmEstoque}");

            produto.RemoverDoEstoque(80);
            Console.WriteLine($"Novo estoque: {produto.QuantidadeEmEstoque}");
        }
    }
}