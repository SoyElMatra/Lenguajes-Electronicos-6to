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
        private int[] diasPorMes = { 30, 27, 30, 29, 30, 29, 30, 30, 29, 30, 29, 30 };

        public Fecha(int dia, int mes, int año)
        {
            Mes = mes;  // Primero, establecemos el mes
            Dia = dia;  // Luego, establecemos el día
            Año = año;
        }

        public int Dia
        {
            get { return dia; }
            private set
            {
                int maxDias = diasPorMes[Mes];

                // Si es febrero y es un año bisiesto, febrero tiene 29 días
                if (Mes == 2 && EsBisiesto())
                    maxDias = 29;

                if (value >= 1 && value <= maxDias)
                {
                    dia = value;
                }
                else
                {
                    // Si el día es mayor al máximo, ajustamos al último día del mes
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
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }

        public override string ToString()
        {
            return $"{Mes.ToString("D2")}/{Dia.ToString("D2")}/{año}";
        }
    }
}