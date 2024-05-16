using System;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização
            Playlist minhaPlaylist = new Playlist("João");

            minhaPlaylist.AdicionarMusica(new Musica("Bohemian Rhapsody", "Queen", "EMI"));
            minhaPlaylist.AdicionarMusica(new Musica("Stairway to Heaven", "Led Zeppelin", "Atlantic Records"));
            minhaPlaylist.AdicionarMusica(new Musica("Hotel California", "Eagles", "Asylum Records"));
            minhaPlaylist.AdicionarMusica(new Musica("Imagine", "John Lennon", "Apple Records"));

            minhaPlaylist.TocarMusicaAleatoria();
        }
    }
}
