using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Fecha
{
    class Fecha
    {
        private int dias;
        private int meses;
        private int ano;

        public Fecha(int Dias, int Meses, int Ano)
        {
            dias = Dias;
            meses = Meses;
            ano = Ano;
        }

        public int Dias
        {
            get { return dias; }
            private set { dias = value; }
        }


        public int Meses
        {
            get { return meses; }
            private set { meses = value; }
        }

        public int Ano
        {
            get { return ano; }
            private set { ano = value; }
        }


        public override string ToString()
        {
            return string.Format("{0} {1} {2}", dias, meses, ano);
        }


        public int validar_dia()
        {
            int[] diasPorMes = { 31, esBisiesto() ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (meses < 1 || meses > 12)
            {
                dias = 1; // mes inválido, día inválido también
            }
            else if (dias < 1 || dias > diasPorMes[meses - 1])
            {
                dias = 1; // día fuera del rango para ese mes
            }

            return dias;
        }

        public int validar_mes()
        {
            if (meses < 1 || meses > 12)
            {
                meses = 1;
            }
            return meses;
        }

        public string validar_ano()
        {
            return esBisiesto() ? $"{ano} es un año bisiesto" : $"{ano} no es un año bisiesto";
        }

        private bool esBisiesto()
        {
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }


    }
}