using System;
using System.Collections.Generic;

namespace Exercicio_07
{
    public class Playlist
    {
        private List<Musica> musicas; // Lista de músicas na playlist
        public string Dono { get; }

        // Construtor para inicializar uma nova playlist com um dono
        public Playlist(string dono)
        {
            Dono = dono;
            musicas = new List<Musica>(); // Inicializa a lista de músicas
        }

        // Método para adicionar uma nova música à playlist
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        // Método para tocar uma música aleatória da playlist
        public void TocarMusicaAleatoria()
        {
            if (musicas.Count == 0)
            {
                Console.WriteLine("Playlist vazia. Adicione músicas para tocar.");
                return;
            }

            Random random = new Random();
            int indiceAleatorio = random.Next(0, musicas.Count); // Gera um índice aleatório dentro do intervalo válido

            Musica musica = musicas[indiceAleatorio]; // Obtém a música correspondente ao índice aleatório
            Console.WriteLine($"Tocando a música: {musica.Nome}");
        }
    }
}
