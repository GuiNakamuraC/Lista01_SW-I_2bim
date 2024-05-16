using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica(); // Cria uma instância da AgendaTelefonica

            while (true) // Loop principal do programa
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Remover Contato");
                Console.WriteLine("3. Buscar Contato");
                Console.WriteLine("4. Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao) // Executa a opção escolhida pelo usuário
                {
                    case 1: // Adicionar
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        agenda.AdicionarContato(new Contato(nome, telefone, email)); // Adiciona o contato na agenda
                        break;
                    case 2: // Remover
                        Console.Write("Nome do contato para remover: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover); // Remove o contato da agenda
                        break;
                    case 3: // Buscar
                        Console.Write("Nome do contato para buscar: ");
                        string nomeBuscar = Console.ReadLine();
                        Contato contatoEncontrado = agenda.BuscarContato(nomeBuscar); // Busca o contato na agenda
                        if (contatoEncontrado != null)
                        {
                            // Exibe as informações do contato se encontrado
                            Console.WriteLine($"Nome: {contatoEncontrado.Nome}, Telefone: {contatoEncontrado.Telefone}, Email: {contatoEncontrado.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 4: // Sair
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default: // Opção inválida
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}