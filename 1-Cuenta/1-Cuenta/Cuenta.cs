using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Cuenta
{
    class Cuenta
    {
        float saldo;
        public Cuenta(float e)
        {
            saldo = e;
        }
        public void agregarSaldo(float e)
        {
            saldo += e;
        }
        public void mostrarSaldo()
        {
            Console.WriteLine("Su saldo es: {0}", saldo);
        }
    }
}
