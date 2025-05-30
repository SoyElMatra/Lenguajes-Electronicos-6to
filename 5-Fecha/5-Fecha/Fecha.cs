using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Fecha
{
    class Fecha
    {
        private int dia;
        private int mes;
        private int año;
        private int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Fecha(int dia, int mes, int año)
        {
            this.mes = mes;  
            this.dia = dia;  
            this.año = año;
        }

        public int Dia
        {
            get { return dia; }
            private set
            {
                int maxDias = diasPorMes[Mes];
                if (EsBisiesto() == true)
                {
                    Console.WriteLine("Es Bisiesto");
                    if (Mes == 2)
                    {
                        maxDias = 29;
                    }
                }                

                if (value >= 1 && value <= maxDias)
                {
                    dia = value;
                }
                else
                {
                    if (value > maxDias)
                    {
                        dia = maxDias;
                    }
                    else
                    {
                        dia = 1;
                    }
                }
            }
        }

        public int Mes
        {
            get { return mes; }
            private set
            {
                if (value >= 1 && value <= 12)
                {
                    mes = value;
                }
                else
                    mes = 1;
            }
        }

        public int Año
        {
            get { return año; }
            private set { año = value; }
        }

        public bool EsBisiesto()
        {
            Console.WriteLine();
            return (año % 4 == 0);
        }

        public override string ToString()
        {
            return $"{Mes.ToString("D2")}/{Dia.ToString("D2")}/{año}";
        }
    }
}