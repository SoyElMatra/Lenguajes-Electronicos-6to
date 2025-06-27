using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Martin
{
    class vehiculos
    {
        protected string patente;
        protected string marca;
        protected int potencia;
        protected bool estado;

        public string Patente
        {
            get
            {
                return patente;
            }
            protected set
            {
                patente = value;
            }
        }
        public string Marca
        {
            get
            {
                return marca;
            }
            protected set
            {
                marca = value;
            }
        }

        public int Potencia
        {
            get
            {
                return potencia;
            }
            protected set
            {
                potencia = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public vehiculos(string patente, string marca, int potencia, bool estado)
        {
            Patente = patente;
            Marca = marca;
            Potencia = potencia;
            Estado = estado;
        }

        public bool checkEsVeloz()
        {
            if (Potencia > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"\nPatente: {patente}\nMarca: {marca}\nPotencia: {potencia}\nEstado: {estado}";
        }

    }
}