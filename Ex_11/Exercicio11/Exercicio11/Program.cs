using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Fusca", 1970);

            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Ano: {carro.Ano}");
            Console.WriteLine($"Velocidade inicial: {carro.Velocidade}");

            // Acelerando o carro
            carro.Acelerar();
            Console.WriteLine($"Velocidade após acelerar: {carro.Velocidade}");

            // Freando o carro
            carro.Frear();
            Console.WriteLine($"Velocidade após frear: {carro.Velocidade}");

            // Freando o carro novamente para teste negativo
            carro.Frear();
            Console.WriteLine($"Velocidade após frear novamente: {carro.Velocidade}");
        }
    }
}
