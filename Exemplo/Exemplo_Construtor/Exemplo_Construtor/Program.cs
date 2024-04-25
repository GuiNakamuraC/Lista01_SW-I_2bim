namespace Exemplo_Construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXEMPLO CONSTRUTOR DE UMA CLASSE");

            Cliente cliente = new Cliente();

            //cliente.Nome = "GUILHERME";
            //cliente.Email = "guincarvalho08@gmail.com";
            //cliente.Senha = 1234;

            cliente.MostraDados();
        }
    }
}