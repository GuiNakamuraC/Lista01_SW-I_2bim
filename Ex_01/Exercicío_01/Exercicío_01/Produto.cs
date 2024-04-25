using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicío_01
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; private set; }

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public void AdicionarAoEstoque(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} adicionadas ao estoque.");
        }

        public void RemoverDoEstoque(int quantidade)
        {
            if (quantidade > QuantidadeEmEstoque)
            {
                Console.WriteLine($"Não há {quantidade} unidades de {Nome} disponíveis no estoque.");
            }
            else
            {
                QuantidadeEmEstoque -= quantidade;
                Console.WriteLine($"{quantidade} unidades de {Nome} removidas do estoque.");
            }
        }
    }
}
