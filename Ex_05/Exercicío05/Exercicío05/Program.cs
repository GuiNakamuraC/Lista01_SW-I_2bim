using System;

namespace Exercicío05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas(); // Instância do GerenciadorDeTarefas

            while (true) // Loop para exibir o menu e processar as opções do usuário
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Remover Tarefa");
                Console.WriteLine("3. Listar Tarefas");
                Console.WriteLine("4. Verificar Tarefa para Hoje");
                Console.WriteLine("5. Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao) // Switch para processar a escolha do usuário
                {
                    case 1: // Adicionar Tarefa
                        Console.Write("Descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Data de vencimento (dd/mm/aaaa): ");
                        DateTime dataVencimento = DateTime.Parse(Console.ReadLine());
                        gerenciador.AdicionarTarefa(new Tarefa(descricao, dataVencimento));
                        break;
                    case 2: // Remover
                        Console.Write("Descrição da tarefa para remover: ");
                        string descricaoRemover = Console.ReadLine();
                        gerenciador.RemoverTarefa(descricaoRemover);
                        break;
                    case 3: // Listar
                        gerenciador.ListarTarefas();
                        break;
                    case 4: // Verificar Tarefa para Hoje
                        gerenciador.VerificarTarefaHoje();
                        break;
                    case 5: // Sair
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
