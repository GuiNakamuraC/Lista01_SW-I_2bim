using System;
using System.Collections.Generic;

namespace Exercicío05
{
    internal class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas; // Lista para armazenar as tarefas

        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>(); // Inicializa a lista de tarefas no construtor
        }

        // Método para adicionar uma tarefa à lista
        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa); // Adiciona a tarefa à lista
        }

        // Método para remover uma tarefa da lista
        public void RemoverTarefa(string descricao)
        {
            // Busca a tarefa na lista pelo nome
            Tarefa tarefa = tarefas.Find(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
            if (tarefa != null) // Se a tarefa foi encontrada
            {
                tarefas.Remove(tarefa); // Remove a tarefa da lista
                Console.WriteLine($"Tarefa '{descricao}' removida com sucesso.");
            }
            else // Se a tarefa não foi encontrada
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Método para listar todas as tarefas
        public void ListarTarefas()
        {
            if (tarefas.Count == 0) // Se não houver tarefas na lista
            {
                Console.WriteLine("Não há tarefas cadastradas.");
            }
            else // Se houver tarefas na lista
            {
                Console.WriteLine("Lista de Tarefas:");
                foreach (var tarefa in tarefas) // Itera sobre cada tarefa na lista
                {
                    // Exibe a descrição da tarefa e sua data de vencimento
                    Console.WriteLine($"- {tarefa.Descricao} (Vencimento: {tarefa.DataVencimento.ToShortDateString()})");
                }
            }
        }

        // Método para verificar se há tarefas para serem executadas hoje
        public void VerificarTarefaHoje()
        {
            Console.WriteLine("Tarefas para hoje:");
            foreach (var tarefa in tarefas) // Itera sobre cada tarefa na lista
            {
                // Verifica se a data de vencimento da tarefa é igual à data atual
                if (tarefa.DataVencimento.Date == DateTime.Today)
                {
                    // Se for, exibe a descrição da tarefa
                    Console.WriteLine($"- {tarefa.Descricao}");
                }
            }
        }
    }

    // Classe para representar uma tarefa
    internal class Tarefa
    {
        public string Descricao { get; set; } // Descrição da tarefa
        public DateTime DataVencimento { get; set; } // Data de vencimento da tarefa

        // Construtor para inicializar os atributos da tarefa
        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
    }
}