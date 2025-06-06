using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de contraseñas");

            // Pedir cantidad de contraseñas
            Console.Write("Ingrese cantidad de contraseñas a generar: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Pedir longitud de las contraseñas
            Console.Write("Ingrese longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());

            // Crear array de passwords
            Password[] passwords = new Password[cantidad];

            // Generar contraseñas
            for (int i = 0; i < cantidad; i++)
            {
                passwords[i] = new Password(longitud);
            }

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            for (int i = 0; i < cantidad; i++)
            {
                string fortaleza = passwords[i].EsFuerte() ? "FUERTE" : "DÉBIL";
                Console.WriteLine($"La contraseña \"{passwords[i].Contraseña}\" es \"{fortaleza}\"");
            }
        }
    }
}
