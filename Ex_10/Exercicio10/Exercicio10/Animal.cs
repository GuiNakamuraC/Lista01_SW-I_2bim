using System;

namespace Exercicio10
{
    public class Animal
    {
        private string nome;
        private string especie;
        private int idade;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do animal não pode ser vazio.");
                }
                // Atribui o valor à variável privada
                nome = value;
            }
        }

        public string Especie
        {
            get { return especie; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A espécie do animal não pode ser vazia.");
                }
                // Atribui o valor à variável privada
                especie = value;
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                // Verifica se a idade é um valor válido (não negativo)
                if (value < 0)
                {
                    throw new ArgumentException("A idade do animal não pode ser negativa.");
                }
                // Atribui o valor à variável privada
                idade = value;
            }
        }

        // Construtor da classe Animal, recebe o nome, a espécie e a idade como parâmetros
        public Animal(string nome, string especie, int idade)
        {
            // Define o nome, a espécie e a idade chamando os setters, que fazem a validação
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        // Método para emitir som do animal
        public void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }
}

