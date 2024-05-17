using System;

namespace Exercicio11
{
    public class Carro
    {
        // Atributos do carro: modelo, ano e velocidade
        public string Modelo { get; set; }
        public int Ano { get; set; }
        private int velocidade;

        public int Velocidade
        {
            get { return velocidade; }
            private set
            {
                // A velocidade nunca deve ser negativa
                velocidade = Math.Max(value, 0);
            }
        }

        // Construtor da classe Carro
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0;
        }

        // Método para acelerar o carro
        public void Acelerar()
        {
            Velocidade += 10;
        }

        // Método para frear o carro
        public void Frear()
        {
            Velocidade -= 10;
        }
    }
}
