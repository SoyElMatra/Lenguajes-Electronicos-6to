using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(30);
            Persona p2 = new Persona(15);
            Console.Write("Edad 1: ");
            p1.MostrarEdad();
            Console.Write("Edad 2: ");
            p2.MostrarEdad();
        }
    }
}
