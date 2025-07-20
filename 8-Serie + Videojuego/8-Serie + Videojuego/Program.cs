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
            string nombre, genero, creador;
            int numeroTemporadas, horasEstimadas;
            Serie[] series = new Serie[5];
            for(int i = 0; i < series.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la serie {i + 1}:");
                nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese el número de temporadas de la serie {i + 1}:");
                numeroTemporadas = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el género de la serie {i + 1}:");
                genero = Console.ReadLine();
                Console.WriteLine($"Ingrese el creador de la serie {i + 1}:");
                creador = Console.ReadLine();
                series[i] = new Serie(nombre, numeroTemporadas, genero, creador);
            }

            series[0].Entregar();
            series[2].Entregar();

            int seriesEntregadas = series.Count(s => s.IsEntregado());
            Console.WriteLine($"Número de Series entregadas: {seriesEntregadas}");

            Serie serieConMasTemporadas = series.OrderByDescending(s => s.GetTemporadas()).FirstOrDefault();
            Console.WriteLine($"Serie con más temporadas: {serieConMasTemporadas.ToString()}");

            Videojuego[] videojuegos = new Videojuego[5];
            for (int i = 0; i < videojuegos.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre del videojuego {i + 1}:");
                nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese las horas estimadas del videojuego {i + 1}:");
                horasEstimadas = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el género del videojuego {i + 1}:");
                genero = Console.ReadLine();
                Console.WriteLine($"Ingrese el creador del videojuego {i + 1}:");
                creador = Console.ReadLine();
                videojuegos[i] = new Videojuego(nombre, horasEstimadas, genero, creador);
            }

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

