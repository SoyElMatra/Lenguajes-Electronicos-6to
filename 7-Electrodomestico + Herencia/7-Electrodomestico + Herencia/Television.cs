using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Electrodomestico___Herencia
{
    class Television : Electrodomestico
    {
        private double resolucion;
        private bool sintonizadorTDT;
        public Television() : base()
        {
            resolucion = 20;
            sintonizadorTDT = false;
        }
        public Television(double precio, double peso) : base(precio, peso)
        {
            resolucion = 20;
            sintonizadorTDT = false;
        }
        public Television(double precio, string color, char consumoEnergetico, double peso, double resolucion, bool sintonizadorTDT) : base(precio, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }
        public double Resolucion => resolucion;
        public bool SintonizadorTDT => sintonizadorTDT;
        public override double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (resolucion > 40)
            {
                precioFinal *= 1.3; // Aumento del 30%
            }
            if (sintonizadorTDT)
            {
                precioFinal += 50;
            }
            return precioFinal;
        }
    }
}
