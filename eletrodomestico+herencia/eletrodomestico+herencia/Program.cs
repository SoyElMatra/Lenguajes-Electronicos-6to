using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eletrodomestico_herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];
            // Asignar objetos a cada posición con valores deseados
            electrodomesticos[0] = new Electrodomestico();
            electrodomesticos[1] = new Electrodomestico(150, "negro", 'B', 25);
            electrodomesticos[2] = new Electrodomestico(300, "azul", 'C', 10);
            electrodomesticos[3] = new Electrodomestico(100, "gris", 'D', 30);
            electrodomesticos[4] = new Electrodomestico(250, "blanco", 'E', 5);
            electrodomesticos[5] = new Electrodomestico(400, "rojo", 'F', 80);
            electrodomesticos[6] = new Electrodomestico(350, "negro", 'A', 60);
            electrodomesticos[7] = new Electrodomestico(450, "azul", 'B', 20);
            electrodomesticos[8] = new Electrodomestico(500, "gris", 'C', 40);
            electrodomesticos[9] = new Electrodomestico(600, "blanco", 'D', 90);
            double sumaTotal = 0;
            // Mostrar el precio de cada Electrodomestico y la suma total
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                double precioFinal = electrodomesticos[i].PrecioFinal();
                Console.WriteLine($"Electrodoméstico {i + 1}: Precio final = ${precioFinal}");
                sumaTotal += precioFinal;
            }
            Console.WriteLine($"Suma total de todos los electrodomésticos: ${sumaTotal}");
        }
    }
}
