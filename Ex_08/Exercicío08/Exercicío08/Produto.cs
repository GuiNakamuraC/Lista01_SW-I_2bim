using System;

namespace Exercicío_08
{
    public class Produto
    {
        private string nome;
        private double preco;
        private Fabricante fabricante;

        public string Nome
        {
            get { return nome; }
            set // Define o valor do atributo nome, aplicando validação para garantir que não seja vazio ou nulo
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
                }
                nome = value;
            }
        }

        public double Preco
        {
            get { return preco; }
            set // Define o valor do atributo preco, aplicando validação para garantir que seja positivo
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço do produto não pode ser negativo.");
                }
                preco = value;
            }
        }

        public Fabricante Fabricante { get; set; }
    }
}
