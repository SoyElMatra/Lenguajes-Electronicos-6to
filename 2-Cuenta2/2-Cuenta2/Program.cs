using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cuenta2
{
    class Program
    {
        static void Main(string[] args)
        {
            float cant;
            string texto;
            string texto2;
            Cuenta p1 = new Cuenta("Santiago", 314.15f);
            for (; ; )
            {
                texto = Console.ReadLine();
                if (texto == "ingresar")
                {
                    Console.WriteLine("Ingrese la cantidad que quiere ingresar: ");
                    texto2 = Console.ReadLine();
                    cant = Convert.ToSingle(texto2);
                    p1.ingresar(cant);
                }
                if (texto == "retirar")
                {
                    Console.WriteLine("Ingrese la cantidad que quiere retirar: ");
                    texto2 = Console.ReadLine();
                    cant = Convert.ToSingle(texto2);
                    p1.retirar(cant);
                }
                if (texto == "mostrar")
                {
                    Console.WriteLine(p1.ToString());
                }
            }
        }
    }
}
