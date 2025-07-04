using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Serie___Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            series[0] = new Serie("Breaking Bad", 5, "Drama", "Vince Gilligan");
            series[1] = new Serie("Game of Thrones", 8, "Fantasy", "David Benioff");
            series[2] = new Serie("Stranger Things", 3, "Sci-Fi", "The Duffer Brothers");
            series[3] = new Serie("The Crown", 4, "Historical Drama", "Peter Morgan");
            series[4] = new Serie("The Mandalorian", 2, "Sci-Fi", "Jon Favreau");

            series[0].Entregar();
            series[2].Entregar();

            int seriesEntregadas = series.Count(s => s.IsEntregado());
            Console.WriteLine($"Número de Series entregadas: {seriesEntregadas}");

            Serie serieConMasTemporadas = series.OrderByDescending(s => s.GetTemporadas()).FirstOrDefault();
            Console.WriteLine($"Serie con más temporadas: {serieConMasTemporadas.ToString()}");

            Videojuego[] videojuegos = new Videojuego[5];
            videojuegos[0] = new Videojuego("The Witcher 3", 50, "RPG", "CD Projekt Red");
            videojuegos[1] = new Videojuego("God of War", 20, "Action", "Santa Monica Studio");
            videojuegos[2] = new Videojuego("Minecraft", 30, "Sandbox", "Mojang");
            videojuegos[3] = new Videojuego("The Legend of Zelda: Breath of the Wild", 60, "Adventure", "Nintendo");
            videojuegos[4] = new Videojuego("Cyberpunk 2077", 40, "RPG", "CD Projekt Red");

            videojuegos[0].Entregar();
            videojuegos[3].Entregar();

            int videojuegosEntregados = videojuegos.Count(v => v.IsEntregado());
            Console.WriteLine($"Número de Videojuegos entregados: {videojuegosEntregados}\n");

            Videojuego videojuegoConMasHoras = videojuegos.OrderByDescending(v => v.GetHorasEstimadas()).FirstOrDefault();
            Console.WriteLine($"Videojuego con más horas estimadas: {videojuegoConMasHoras.ToString()}\n");

            Console.WriteLine("Ordenando series por temporadas:");
            Array.Sort(series, (s1, s2) => s2.GetTemporadas().CompareTo(s1.GetTemporadas()));
            foreach (var serie in series)
            {
                Console.WriteLine(serie.ToString());
            }
            Console.WriteLine("\n\nOrdenando videojuegos por horas estimadas:");
            Array.Sort(videojuegos, (v1, v2) => v2.GetHorasEstimadas().CompareTo(v1.GetHorasEstimadas()));
            foreach (var videojuego in videojuegos)
            {
                Console.WriteLine(videojuego.ToString());
            }
        }
    }
}

