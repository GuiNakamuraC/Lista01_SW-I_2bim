using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a agenda
            Agenda agenda = new Agenda();
            string opcao;

            // Loop principal do menu
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Armazenar Pessoa");
                Console.WriteLine("2 - Remover Pessoa");
                Console.WriteLine("3 - Buscar Pessoa");
                Console.WriteLine("4 - Imprimir Agenda");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Armazena
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case "2":
                        // Remove
                        Console.Write("Nome: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case "3":
                        // Busca
                        Console.Write("Nome: ");
                        string nomeBuscar = Console.ReadLine();
                        Agenda.Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                            Console.WriteLine($"Pessoa encontrada: {pessoaEncontrada}");
                        else
                            Console.WriteLine("Pessoa não encontrada.");
                        break;
                    case "4":
                        // Imprime
                        Console.WriteLine("Agenda:");
                        agenda.ImprimeAgenda();
                        break;
                    case "0":
                        // Sai do programa
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        // Opção inválida
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != "0"); // Continuar o loop enquanto a opção for diferente de 0
        }
    }
}