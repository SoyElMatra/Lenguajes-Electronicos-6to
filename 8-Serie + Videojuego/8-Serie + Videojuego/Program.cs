/*Crear una clase llamada Serie con las siguientes características:

Sus atributos son titulo, numero de temporadas, entregado, genero y creador.

Por defecto, el numero de temporadas es de 3 temporadas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.

Los constructores que se implementaran serán:

Un constructor por defecto (sin parámetros).
Un constructor con el titulo y creador. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Sobrescribe los métodos toString.
Entregar(): cambia el atributo entregado a true.
Devolver(): cambia el atributo entregado a false.
IsEntregado(): devuelve el estado del atributo entregado.
Crear una clase Videojuego con las siguientes características:
Sus atributos son titulo, horas estimadas, entregado, genero y compañia.

Por defecto, las horas estimadas serán de 10 horas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.

Los constructores que se implementaran serán:

Un constructor por defecto (sin parámetros).
Un constructor con el titulo y horas estimadas. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Sobrescribe los métodos toString.
Entregar(): cambia el atributo entregadoa true.
Devolver(): cambia el atributo entregadoa false.
IsEntregado(): devuelve el estado del atributo entregado.
------

Realizar lo siguiente:

Crear dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno.
Crear un objeto en cada posición del array, con valores, se pueden usar distintos constructores.
Entregar algunos Videojuegos y Series con el método entregar().
Contar e informar cuantas Series y Videojuegos hay entregados.
Indicar el Videojuego tiene más horas estimadas y la serie con más temporadas. Mostrarlos en pantalla con toda su información (usar el método toString()).*/
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
            // Crear un array de Series
            Serie[] series = new Serie[5];
            series[0] = new Serie("Breaking Bad", 5, "Drama", "Vince Gilligan");
            series[1] = new Serie("Game of Thrones", 8, "Fantasy", "David Benioff");
            series[2] = new Serie("Stranger Things", 3, "Sci-Fi", "The Duffer Brothers");
            series[3] = new Serie("The Crown", 4, "Historical Drama", "Peter Morgan");
            series[4] = new Serie("The Mandalorian", 2, "Sci-Fi", "Jon Favreau");
            // Entregar algunas Series
            series[0].Entregar();
            series[2].Entregar();
            // Contar Series entregadas
            int seriesEntregadas = series.Count(s => s.IsEntregado());
            Console.WriteLine($"Número de Series entregadas: {seriesEntregadas}");
            // Encontrar la Serie con más temporadas
            Serie serieConMasTemporadas = series.OrderByDescending(s => s.GetTemporadas()).FirstOrDefault();
            Console.WriteLine($"Serie con más temporadas: {serieConMasTemporadas.ToString()}");
            // Crear un array de Videojuegos
            Videojuego[] videojuegos = new Videojuego[5];
            videojuegos[0] = new Videojuego("The Witcher 3", 50, "RPG", "CD Projekt Red");
            videojuegos[1] = new Videojuego("God of War", 20, "Action", "Santa Monica Studio");
            videojuegos[2] = new Videojuego("Minecraft", 30, "Sandbox", "Mojang");
            videojuegos[3] = new Videojuego("The Legend of Zelda: Breath of the Wild", 60, "Adventure", "Nintendo");
            videojuegos[4] = new Videojuego("Cyberpunk 2077", 40, "RPG", "CD Projekt Red");
            // Entregar algunos Videojuegos
            videojuegos[0].Entregar();
            videojuegos[3].Entregar();
            // Contar Videojuegos entregados
            int videojuegosEntregados = videojuegos.Count(v => v.IsEntregado());
            Console.WriteLine($"Número de Videojuegos entregados: {videojuegosEntregados}");
            // Encontrar el Videojuego con más horas estimadas
            Videojuego videojuegoConMasHoras = videojuegos.OrderByDescending(v => v.GetHorasEstimadas()).FirstOrDefault();
            Console.WriteLine($"Videojuego con más horas estimadas: {videojuegoConMasHoras.ToString()}");
        }
    }
}

