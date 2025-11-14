using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Nº1___Santiago_Martin
{
    class VehiculosPesados
    {
        private string marca;
        private float rendimiento;
        private float recorrido;
        private float preciototal;
        private int diasvtv;
        private int carga;
        private int preciolitro = 1194;
        private int extra;

        public VehiculosPesados()
        {
            marca = "\0";
            rendimiento = 0;
            recorrido = 0;
        }
        public VehiculosPesados(string marca, float rendimiento, float recorrido, int carga)
        {
            this.marca = marca;
            this.rendimiento = rendimiento;
            this.recorrido = recorrido;
            this.carga = carga;
            if (carga < 1000)
            {
                extra = 50000;
            }
            if (carga >= 1000 && carga < 10000)
            {
                extra = 180000;
            }
            if (carga >= 10000)
            {
                extra = 350000;
            }
            preciototal = Convert.ToSingle((recorrido / rendimiento) * preciolitro) + extra;
        }

        private string puedeviaje()
        {
            if (diasvtv <= 20)
            {
                return "No";
            }
            else
            {
                return "Si";
            }
        }
        public string Marca
        {
            get
            {
                return Marca;
            }
            set
            {
                marca = value;
            }
        }
        public float Rendimiento
        {
            get
            {
                return rendimiento;
            }
            set
            {
                rendimiento = value;
            }
        }
        public float Recorrido
        {
            get
            {
                return recorrido;
            }
            set
            {
                recorrido = value;
            }
        }
        public int Diasvtv
        {
            get
            {
                return diasvtv;
            }
            set
            {
                diasvtv = value;
            }
        }
        public int Carga
        {
            get
            {
                return carga;
            }
            set
            {
                carga = value;
            }
        }
        public override string ToString()
        {
            return $"Marca: {marca}\nRendimiento: {rendimiento}\nPrecio por litro: {preciolitro}\nRecorrido: {recorrido}\nCarga: {carga}\nPrecio total: {preciototal}\n";
        }
    }
}
