using System;
using System.Collections.Generic;

namespace Exercicio12
{
    public class Agenda
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public float Altura { get; set; }

            // Construtor da classe Pessoa
            public Pessoa(string nome, int idade, float altura)
            {
                Nome = nome;
                Idade = idade;
                Altura = altura;
            }

            // Sobrescrevendo o método ToString para formatar a exibição dos dados da pessoa
            public override string ToString()
            {
                return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}";
            }
        }

        // Lista para armazenar as pessoas na agenda
        private List<Pessoa> pessoas = new List<Pessoa>();

        // Método para armazenar uma pessoa na agenda
        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            pessoas.Add(new Pessoa(nome, idade, altura));
        }

        // Método para remover uma pessoa da agenda pelo nome
        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);
            if (pessoa != null)
                pessoas.Remove(pessoa);
        }

        // Método para buscar uma pessoa na agenda pelo nome
        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome == nome);
        }

        // Método para imprimir os dados de todas as pessoas da agenda
        public void ImprimeAgenda()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}