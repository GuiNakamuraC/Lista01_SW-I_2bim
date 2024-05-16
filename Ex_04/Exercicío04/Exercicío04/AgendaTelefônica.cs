using System;
using System.Collections.Generic;

namespace Exercicio04
{
    internal class AgendaTelefonica
    {
        private List<Contato> contatos; // Lista para armazenar os contatos

        // Construtor para inicializar a lista de contatos
        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        // Método para adicionar um contato na lista
        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        // Método para remover um contato da lista
        public void RemoverContato(string nome)
        {
            // Busca o contato pelo nome
            Contato contato = BuscarContato(nome);
            if (contato != null)
            {
                contatos.Remove(contato); // Remove o contato da lista se encontrado
                Console.WriteLine($"Contato {nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        // Método para buscar um contato na lista
        public Contato BuscarContato(string nome)
        {
            foreach (var contato in contatos)
            {
                // Compara o nome do contato ignorando maiúsculas e minúsculas
                if (contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    return contato; // Retorna o contato se encontrado
                }
            }
            return null; // Retorna null se o contato não for encontrado
        }
    }

    internal class Contato
    {
        // Atributos do contato
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Construtor para inicializar os atributos do contato
        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}