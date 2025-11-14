using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Nº1___Santiago_Martin
{
    class VehiculosLivianos
    {
        private string marca;
        private float rendimiento;
        private float recorrido;
        private int preciototal;
        private int diasvtv;
        private int preciolitro = 1194;

        public VehiculosLivianos()
        {
            marca = "\0";
            rendimiento = 0;
            recorrido = 0;
        }
        public VehiculosLivianos(string marca, int diasvtv, float rendimiento, float recorrido)
        {
            this.marca = marca;
            this.diasvtv = diasvtv;
            this.rendimiento = rendimiento;
            this.recorrido = recorrido;
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
        private int Preciototal
        {
            set
            {
                preciototal = Convert.ToInt16((recorrido / rendimiento) * preciolitro);
            }
        }
        public override string ToString()
        {
            return $"Marca: {marca}\nRendimiento: {rendimiento}\nPuede hacer el viaje: {puedeviaje()}\nPrecio por litro: {preciolitro}\nRecorrido: {recorrido}\nPrecio total: {preciototal}\n";
        }
    }
}
