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
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            p1.AsignarEdad(20);
            p2.AsignarEdad(18);
            Console.Write("Edad 1: ");
            p1.MostrarEdad();
            Console.Write("Edad 2: ");
            p2.MostrarEdad();
        }
    }
}
