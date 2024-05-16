using System;
using System.Collections.Generic;

namespace Exercicío03
{
    internal class CorretoraDeImóveis
    {
        // Lista para armazenar os imóveis
        private List<Imovel> imoveis;

        // Construtor para inicializar a lista de imóveis
        public CorretoraDeImóveis()
        {
            imoveis = new List<Imovel>();
        }

        // Método para inserir um imóvel na lista
        public void InserirImovel(Imovel imovel)
        {
            imoveis.Add(imovel);
        }

        // Método para alterar o preço de um imóvel
        public void AlterarPreco(string endereco, double novoPreco)
        {
            foreach (var imovel in imoveis)
            {
                if (imovel.Endereco == endereco)
                {
                    imovel.Preco = novoPreco;
                    Console.WriteLine($"Preço do imóvel no endereço {endereco} alterado para {novoPreco:C}");
                    return;
                }
            }
            Console.WriteLine("Imóvel não encontrado.");
        }

        // Método para listar todos os imóveis disponíveis
        public void ListarImoveis()
        {
            Console.WriteLine("Imóveis disponíveis:");
            // Laço de repetição que percorre todos os imóveis na lista.
            foreach (var imovel in imoveis)
            {
                Console.WriteLine($"Endereço: {imovel.Endereco} | Preço: {imovel.Preco:C} | Tipo: {imovel.Tipo}");
            }
        }

        // Método para calcular o valor médio dos imóveis
        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Não há imóveis disponíveis para calcular o valor médio.");
                return 0.0;
            }

            double somaPrecos = 0.0;
            foreach (var imovel in imoveis)
            {
                somaPrecos += imovel.Preco;
            }

            return somaPrecos / imoveis.Count;
        }
    }

    // Classe representando um imóvel
    internal class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        // Construtor para inicializar os atributos do imóvel
        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }
    }
}
