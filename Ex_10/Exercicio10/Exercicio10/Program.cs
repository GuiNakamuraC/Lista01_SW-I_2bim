using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Animal animal = new Animal("Rex", "Cachorro", 3);

                Console.WriteLine($"Nome: {animal.Nome}");
                Console.WriteLine($"Espécie: {animal.Especie}");
                Console.WriteLine($"Idade: {animal.Idade}");

                // Emite o som do animal
                animal.EmitirSom();
            }
            catch (ArgumentException ex)
            {
                // Capturando a exceção caso o nome, a espécie ou a idade sejam inválidos
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
