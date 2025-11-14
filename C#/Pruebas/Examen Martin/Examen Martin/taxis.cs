using Examen_Martin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen_Martin
{
    class taxis : vehiculos
    {
        protected int licencia;
        protected int valor_bandera;
        protected int precio_kilometro;
        protected bool disponible;
        public int Licencia
        {
            get
            {
                return licencia;
            }
            private set
            {
                licencia = value;
            }
        }

        public int Valor_bandera
        {
            get
            {
                return valor_bandera;
            }
            private set
            {
                valor_bandera = value;
            }
        }

        public int Precio_kilometro
        {
            get
            {
                return precio_kilometro;
            }
            private set
            {
                precio_kilometro = value;
            }
        }

        public bool Disponible
        {
            get
            {
                return disponible;
            }
            set
            {
                disponible = value;
            }
        }

        public taxis(int licencia, int valor_bandera, int precio_kilometro, string patente, string marca, int potencia, bool estado, bool disponible) : base(patente, marca, potencia, estado)
        {
            Licencia = licencia;
            Valor_bandera = valor_bandera;
            Precio_kilometro = precio_kilometro;
            Disponible = disponible;
            Patente = patente;
            Marca = marca;
            Potencia = potencia;
            Estado = estado;
        }

        virtual public int costo_viaje(int kilometros)
        {
            int costo = Valor_bandera + (Precio_kilometro * kilometros);
            return costo;
        }


        public override string ToString()
        {
            return $"\nPatente: {patente}\nMarca: {marca}\nPotencia: {potencia}\nEstado: {estado}\nPrecio p/ KM {precio_kilometro}\nValor p/ bandera: {valor_bandera}\nLicencia: {licencia}";
        }
    }
}
