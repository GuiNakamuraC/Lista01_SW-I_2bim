using System;

namespace Exercicío_08
{
    public class Fabricante
    {
        private string nome;
        private string endereco;
        private string cidade;

        public string Nome
        {
            get { return nome; } // Retorna o valor do atributo nome
            set // Define o valor do atributo nome, aplicando validação para garantir que não seja vazio ou nulo
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do fabricante não pode ser vazio ou nulo.");
                }
                nome = value;
            }
        }

        public string Endereco { get; set; }

        public string Cidade { get; set; }
    }
}