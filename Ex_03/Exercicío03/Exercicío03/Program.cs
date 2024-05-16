using System;

namespace Exercicío03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da corretora de imóveis
            CorretoraDeImóveis corretora = new CorretoraDeImóveis();

            while (true)
            {
                // Exibindo o menu de opções
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço do Imóvel");
                Console.WriteLine("3. Listar Todos os Imóveis");
                Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
                Console.WriteLine("5. Sair");

                // Solicitando ao usuário que escolha uma opção
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                // Executando a opção escolhida pelo usuário
                switch (opcao)
                {
                    case 1:
                        // Opção para inserir um novo imóvel
                        Console.Write("Endereço do imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do imóvel: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo do imóvel: ");
                        string tipo = Console.ReadLine();
                        corretora.InserirImovel(new Imovel(endereco, preco, tipo));
                        break;
                    case 2:
                        // Opção para alterar o preço de um imóvel
                        Console.Write("Endereço do imóvel para alterar o preço: ");
                        string enderecoAlterar = Console.ReadLine();
                        Console.Write("Novo preço: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPreco(enderecoAlterar, novoPreco);
                        break;
                    case 3:
                        // Opção para listar todos os imóveis disponíveis
                        corretora.ListarImoveis();
                        break;
                    case 4:
                        // Opção para calcular o valor médio dos imóveis
                        Console.WriteLine($"Valor médio dos imóveis: {corretora.CalcularValorMedio():C}");
                        break;
                    case 5:
                        // Encerrando o programa
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        // Mensagem de opção inválida
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}