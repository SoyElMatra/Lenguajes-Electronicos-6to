using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Electrodomestico___Herencia
{
    class Lavadora : Electrodomestico
    {
        private double carga;
        public Lavadora() : base()
        {
            carga = 5;
        }
        public Lavadora(double precio, double peso) : base(precio, peso)
        {
            carga = 5;
        }
        public Lavadora(double precio, string color, char consumoEnergetico, double peso, double carga) : base(precio, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }
        public double Carga => carga;
        public override double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (carga > 30)
            {
                precioFinal += 50;
            }
            return precioFinal;
        }
    }
}
