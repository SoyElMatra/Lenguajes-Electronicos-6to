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
            Fecha f = new Fecha(29, 2, 2006);

            Console.WriteLine("{0} {1} {2}", f.validar_dia(), f.validar_mes(), f.validar_ano());
        }
    }
}
