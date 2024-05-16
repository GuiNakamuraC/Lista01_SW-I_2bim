using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistroDeCompras registroDeCompras = new RegistroDeCompras();

            registroDeCompras.AdicionarCompra(new DateTime(2025, 5, 1), "Arroz", 50.0);
            registroDeCompras.AdicionarCompra(new DateTime(2024, 10, 20), "Leite", 4.99);
            registroDeCompras.AdicionarCompra(new DateTime(2025, 5, 5), "Caviar", 99.99);

            registroDeCompras.ListarCompras();
        }
    }
}