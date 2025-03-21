using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuscochetta
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            float conv;
            Console.WriteLine("Ingrese un valor:");
            valor = Console.ReadLine();
            conv = Convert.ToSingle(valor);
            Console.WriteLine("Valor: {0}\nValor + 2: {1}", valor, conv + 2);
        }
    }
}
