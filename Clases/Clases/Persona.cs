using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Persona
    {
        private string nombre;
        private int edad;
         Persona(int e)
        {
            edad = e;
        }

        public void MostrarEdad()
        {
            Console.WriteLine(edad);
        }
        public void AsignarEdad(int e)
        {
            edad = e;
        }
    }
}
