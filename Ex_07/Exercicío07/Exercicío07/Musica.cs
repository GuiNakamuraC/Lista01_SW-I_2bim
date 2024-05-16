using System;

namespace Exercicio_07
{
    public class Musica
    {
        public string Nome { get; }
        public string Autor { get; }
        public string Gravadora { get; }

        // Construtor para inicializar os atributos da música
        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }
}
