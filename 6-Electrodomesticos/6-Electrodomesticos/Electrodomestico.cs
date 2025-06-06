using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Electrodomesticos
{
    class Electrodomestico
    {
        // Atributos
        private double precioBase;
        private string color;
        private char consumoEnergetico;
        private double peso;

        // Colores 
        // letras 
        private static readonly string[] COLORES = { "blanco", "negro", "rojo", "azul", "gris" };
        private static readonly char[] CONSUMO_ENERGETICO_VALIDO = { 'A', 'B', 'C', 'D', 'E', 'F' };

        //readonly sirve para asignarle un valor a algo y no se lo podes cambiar despues 


        // Constructor por defecto 

        public Electrodomestico()
        {
            precioBase = 100;
            color = "blanco";
            consumoEnergetico = 'F';
            peso = 5;
        }

        // Constructor con precio y peso
        public Electrodomestico(double PrecioBase, double Peso)
        {
            precioBase = PrecioBase;
            peso = Peso;
            color = "blanco";
            consumoEnergetico = 'F';
        }

        // Constructor con todos los atributos
        public Electrodomestico(double PrecioBase, string Color, char ConsumoEnergetico, double Peso)
        {
            precioBase = PrecioBase;
            color = comprobarColor(Color);
            consumoEnergetico = comprobarConsumoEnergetico(ConsumoEnergetico);
            peso = Peso;
        }

        // Propiedades get
        public double PrecioBase
        {
            get { return precioBase; }
        }
        public string Color
        {
            get { return color; }
        }
        public char ConsumoEnergetico
        {
            get { return consumoEnergetico; }
        }
        public double Peso
        {
            get { return peso; }
        }

        //////////////////////////////////////////////////////////////////////////
        // Método para comprobar el consumo energético
        private char comprobarConsumoEnergetico(char letra)
        {
            foreach (char c in CONSUMO_ENERGETICO_VALIDO)
            {                                                       //hecho por blackbox
                if (char.ToUpper(letra) == c)
                {
                    return char.ToUpper(letra);
                }
            }
            return 'F'; // Retorna 'F' si la letra no es válida
        }

        //////////////////////////////////////////////////////////////////////////
        // Método para comprobar el color
        private string comprobarColor(string Color)
        {
            Color = Color.ToLower();
            foreach (var c in COLORES)
            {
                if (c == Color)                                     //hecho por blackbox
                {
                    return Color;
                }
            }
            return "blanco"; // Retorna "blanco" si el color no es válido
        }

        ////////////////////////////////////////////////////////////////////////


        // Método para calcular el precio final
        public double PrecioFinal()
        {
            double precioFinal = precioBase;

            // Aumento por consumo energético
            switch (consumoEnergetico)
            {
                case 'A':
                    precioFinal += 100;
                    break;
                case 'B':
                    precioFinal += 80;
                    break;
                case 'C':
                    precioFinal += 60;
                    break;
                case 'D':
                    precioFinal += 50;
                    break;
                case 'E':
                    precioFinal += 30;
                    break;
                case 'F':
                    precioFinal += 10;
                    break;
            }

            // Aumento por peso
            if (peso > 0 && peso < 20)
            {
                precioFinal += 10;
            }
            else if (peso >= 20 && peso < 50)
            {
                precioFinal += 50;
            }
            else if (peso >= 50 && peso < 80)
            {
                precioFinal += 80;
            }
            else if (peso >= 80)
            {
                precioFinal += 100;
            }

            return precioFinal;
        }
    }
}
