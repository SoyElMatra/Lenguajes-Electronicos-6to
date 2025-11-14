using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Electrodomestico___Herencia
{
    class Electrodomestico
    {
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected double peso;
        private static readonly string[] coloresDisponibles = { "blanco", "negro", "rojo", "azul", "gris" };
        private static readonly double[] preciosConsumo = { 100, 80, 60, 50, 30, 10 };
        private static readonly double[] preciosPeso = { 10, 50, 80, 100 };
        public Electrodomestico()
        {
            precioBase = 100;
            color = "blanco";
            consumoEnergetico = 'F';
            peso = 5;
            ComprobarConsumoEnergetico(consumoEnergetico);
            ComprobarColor(color);
        }
        public Electrodomestico(double precio, double peso)
        {
            this.precioBase = precio;
            this.peso = peso;
            color = "blanco";
            consumoEnergetico = 'F';
            ComprobarConsumoEnergetico(consumoEnergetico);
            ComprobarColor(color);
        }
        public Electrodomestico(double precio, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precio;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
            ComprobarConsumoEnergetico(consumoEnergetico);
            ComprobarColor(color);
        }
        public double PrecioBase => precioBase;
        public string Color => color;
        public char ConsumoEnergetico => consumoEnergetico;
        public double Peso => peso;
        private void ComprobarConsumoEnergetico(char letra)
        {
            if (letra < 'A' || letra > 'F')
            {
                consumoEnergetico = 'F';
            }
            else
            {
                consumoEnergetico = letra;
            }
        }
        private void ComprobarColor(string color)
        {
            if (Array.Exists(coloresDisponibles, c => c.Equals(color.ToLower())))
            {
                this.color = color.ToLower();
            }
            else
            {
                this.color = "blanco";
            }
        }
        public virtual double PrecioFinal()
        {
            double precioFinal = precioBase;
            // Aumento por consumo energético
            precioFinal += preciosConsumo[consumoEnergetico - 'A'];
            // Aumento por peso
            if (peso > 0 && peso < 20)
                precioFinal += preciosPeso[0];
            else if (peso >= 20 && peso < 50)
                precioFinal += preciosPeso[1];
            else if (peso >= 50 && peso < 80)
                precioFinal += preciosPeso[2];
            else if (peso >= 80)
                precioFinal += preciosPeso[3];
            return precioFinal;
        }
    }
}
