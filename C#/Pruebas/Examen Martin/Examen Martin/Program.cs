using Examen_Martin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Martin
{
    class Program
    {
        static void Main(string[] args)
        {

            vehiculos[] moviles = new vehiculos[8];

            moviles[0] = new taxis(414, 1200, 3500, "AF 716 SK", "Volkswagen", 255, false, false);
            moviles[1] = new taxis(515, 350, 6000, "PEF 804", "Nissan", 120, true, false);
            moviles[2] = new colectivos(50, 11513, 150, "JSA 233", "Mercedes", 500, false);
            moviles[3] = new colectivos(30, 417, 100, "KIV 450", "Agrale", 400, true);
            moviles[4] = new camion_carga(600, 4, "AA 330 FK", "Ivess", 1000, false);
            moviles[5] = new camion_carga(8000, 2, "DSA 343", "Scania", 1200, true);
            moviles[6] = new taxis_premium(true, false, 503, 1000, 150, "AE 349 JG", "Nissan", 500, false, true);
            moviles[7] = new taxis_premium(true, true, 430, 600, 100, "AG 642 FE", "Mitsubishi", 350, false, false);


            for (int i = 0; i < 8; i++)
            {

                if (moviles[i] is taxis a)
                {
                    Console.WriteLine(a.ToString());
                    a.Estado = false;
                    bool veloz = a.checkEsVeloz();
                    if (veloz == true)
                    {
                        Console.WriteLine("Es veloz: Si");
                    }
                    else
                    {
                        Console.WriteLine("Es veloz: No");
                    }
                    int costo = a.costo_viaje(50);
                    Console.WriteLine("Costo total: {0}", costo);
                }
                if (moviles[i] is colectivos b)
                {
                    Console.WriteLine(b.ToString());
                    b.Estado = false;
                    bool veloz = b.checkEsVeloz();
                    if (veloz == true)
                    {
                        Console.WriteLine("Es veloz: Si");
                    }
                    else
                    {
                        Console.WriteLine("Es veloz: No");
                    }
                    int costo = b.costo_de_viaje();
                    Console.WriteLine("Costo total: {0}", costo);
                }
                if (moviles[i] is camion_carga c)
                {
                    Console.WriteLine(c.ToString());
                    c.Estado = false;
                    bool veloz = c.checkEsVeloz();
                    if (veloz == true)
                    {
                        Console.WriteLine("Es veloz: Si");
                    }
                    else
                    {
                        Console.WriteLine("Es veloz: No");
                    }
                    bool cargado = c.cargado_o_no();
                    if (cargado == true)
                    {
                        Console.WriteLine("Tiene carga: Si");
                    }
                    else
                    {
                        Console.WriteLine("Tiene carga: No");
                    }
                    int costo = c.costo_viaje();
                    Console.WriteLine("Costo total: {0}", costo);
                }
                if (moviles[i] is taxis_premium d)
                {
                    Console.WriteLine(d.ToString());
                    d.Estado = false;
                    bool veloz = d.checkEsVeloz();
                    if (veloz == true)
                    {
                        Console.WriteLine("Es veloz: Si");
                    }
                    else
                    {
                        Console.WriteLine("Es veloz: No");
                    }
                    int costo = d.costo_viaje(80);
                    Console.WriteLine("Costo total: {0}", costo);
                }
            }


        }
    }
}

