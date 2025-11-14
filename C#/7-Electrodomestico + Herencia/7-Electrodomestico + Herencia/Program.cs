using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Electrodomestico___Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];
            double totalElectrodomesticos = 0;
            double totalLavadoras = 0;
            double totalTelevisiones = 0;
            // Asignar objetos a cada posición
            electrodomesticos[0] = new Lavadora(300, 25, 30);
            electrodomesticos[1] = new Lavadora(200, 15, 20);
            electrodomesticos[2] = new Television(500, 10, 'A', 10, 42, true);
            electrodomesticos[3] = new Television(400, 8, 'B', 12, 32, false);
            electrodomesticos[4] = new Electrodomestico(100, "rojo", 'C', 10);
            electrodomesticos[5] = new Lavadora(250, 35, 40);
            electrodomesticos[6] = new Television(600, 20, 'A', 15, 50, true);
            electrodomesticos[7] = new Electrodomestico(150, "gris", 'D', 20);
            electrodomesticos[8] = new Lavadora(350, 45, 35);
            electrodomesticos[9] = new Television(700, 30, 'E', 25, 55, false);
            // Calcular precios finales y mostrar resultados
            foreach (var electrodomestico in electrodomesticos)
            {
                double precioFinal = electrodomestico.PrecioFinal();
                totalElectrodomesticos += precioFinal;
                if (electrodomestico is Lavadora)
                {
                    totalLavadoras += precioFinal;
                }
                else if (electrodomestico is Television)
                {
                    totalTelevisiones += precioFinal;
                }
                Console.WriteLine($"Precio final: {precioFinal}");
            }
            Console.WriteLine($"Total Electrodomésticos: {totalElectrodomesticos}");
            Console.WriteLine($"Total Lavadoras: {totalLavadoras}");
            Console.WriteLine($"Total Televisiones: {totalTelevisiones}");
        }
    }
}
