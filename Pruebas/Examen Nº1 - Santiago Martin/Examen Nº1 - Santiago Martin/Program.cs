using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Nº1___Santiago_Martin
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] marca = new string[10];
            int[] diasvtv = new int[5];
            float[] rendimiento = new float[10];
            float[] recorrido = new float[10];
            int[] carga = new int[5];
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la marca de su vehiculo:");
                marca[i] = Console.ReadLine();

                Console.WriteLine("Ingrese los dias que faltan para el vencimiento de la VTV de su vehiculo:");
                diasvtv[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el rendimiento (kilometros por litro) de su vehiculo:");
                rendimiento[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el recorrido en kilometros que quiere hacer:");
                recorrido[i] = float.Parse(Console.ReadLine());
            }

            VehiculosLivianos L1 = new VehiculosLivianos(marca[0], diasvtv[0], rendimiento[0], recorrido[0]);
            VehiculosLivianos L2 = new VehiculosLivianos(marca[1], diasvtv[1], rendimiento[1], recorrido[1]);
            VehiculosLivianos L3 = new VehiculosLivianos(marca[2], diasvtv[2], rendimiento[2], recorrido[2]);
            VehiculosLivianos L4 = new VehiculosLivianos(marca[3], diasvtv[3], rendimiento[3], recorrido[3]);
            VehiculosLivianos L5 = new VehiculosLivianos(marca[4], diasvtv[4], rendimiento[4], recorrido[4]);

            for (i = 5; i < 10; i++)
            {
                Console.WriteLine("Ingrese la marca de su vehiculo:");
                marca[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el rendimiento (kilometros por litro) de su vehiculo:");
                rendimiento[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el recorrido en kilometros que quiere hacer:");
                recorrido[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la carga en kilos que llevara el camion:");
                carga[i - 5] = int.Parse(Console.ReadLine());
            }
            VehiculosPesados P1 = new VehiculosPesados(marca[5], rendimiento[5], recorrido[5], carga[0]);
            VehiculosPesados P2 = new VehiculosPesados(marca[6], rendimiento[6], recorrido[6], carga[1]);
            VehiculosPesados P3 = new VehiculosPesados(marca[7], rendimiento[7], recorrido[7], carga[2]);
            VehiculosPesados P4 = new VehiculosPesados(marca[8], rendimiento[8], recorrido[8], carga[3]);
            VehiculosPesados P5 = new VehiculosPesados(marca[9], rendimiento[9], recorrido[9], carga[4]);

            Console.WriteLine(L1.ToString());
            Console.WriteLine(L2.ToString());
            Console.WriteLine(L3.ToString());
            Console.WriteLine(L4.ToString());
            Console.WriteLine(L5.ToString());
            Console.WriteLine("\nVehiculos Pesados:");
            Console.WriteLine(P1.ToString());
            Console.WriteLine(P2.ToString());
            Console.WriteLine(P3.ToString());
            Console.WriteLine(P4.ToString());
            Console.WriteLine(P5.ToString());
        }
    }
}
