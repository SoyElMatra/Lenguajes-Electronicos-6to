using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            Fecha fecha1 = new Fecha(29, 2, 2024);  // Año bisiesto
            Console.WriteLine(fecha1.ToString());  // Salida: 02/28/2024

            Fecha fecha2 = new Fecha(29, 2, 2023);  // Año no bisiesto
            Console.WriteLine(fecha2.ToString());  // Salida: 02/28/2023

            Fecha fecha3 = new Fecha(32, 5, 2023);  // Abril tiene 30 días
            Console.WriteLine(fecha3.ToString());  // Salida: 04/30/2023

            Fecha fecha4 = new Fecha(31, 1, 2023);  // Enero tiene 31 días
            Console.WriteLine(fecha4.ToString());  // Salida: 01/31/2023
        }
    }
}
