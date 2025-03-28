using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            float agg = 300.14f;
            string chusco;
            Cuenta acc1 = new Cuenta(agg);
            Console.WriteLine("Puede usar los comandos 'agregar' y 'mostrar' para agregar y mostrar saldo");
            acc1.mostrarSaldo();
            for (; ; )
            {
                chusco = Console.ReadLine();
                if (chusco == "agregar")
                {
                    Console.WriteLine("Ingrese la cantidad de saldo que quiere ingresar: ");
                    chusco = Console.ReadLine();
                    agg = Convert.ToSingle(chusco);
                    if (agg > 0)
                    {
                        acc1.agregarSaldo(agg);
                        acc1.mostrarSaldo();
                    }
                    else
                    {
                        Console.WriteLine("Error: el valor a acreditar es menor o igual a 0");
                    }
                }
                if (chusco == "mostrar")
                {
                    acc1.mostrarSaldo();
                }
            }
        }
    }
}