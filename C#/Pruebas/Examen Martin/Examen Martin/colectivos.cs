using Examen_Martin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen_Martin
{
    class colectivos : vehiculos
    {
        private int pasajeros_max;
        private int linea;
        private int paradas;

        public int Pasajeros_max
        {
            get
            {
                return pasajeros_max;
            }
            private set
            {
                pasajeros_max = value;
            }
        }

        public int Linea
        {
            get
            {
                return linea;
            }
            private set
            {
                linea = value;
            }
        }

        public int Paradas
        {
            get
            {
                return paradas;
            }
            private set
            {
                paradas = value;
            }
        }

        public colectivos(int pasajeros_max, int linea, int paradas, string patente, string marca, int potencia, bool estado) : base(patente, marca, potencia, estado)
        {
            Pasajeros_max = pasajeros_max;
            Linea = linea;
            Paradas = paradas;
            Patente = patente;
            Marca = marca;
            Potencia = potencia;
            Estado = estado;
        }

        public int costo_de_viaje()
        {
            int costo_por_parada = 500;
            int costo = costo_por_parada * Paradas;
            return costo;
        }

        public bool colectivolleno(int pasajeros)
        {
            if (pasajeros > Pasajeros_max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"\nPatente: {patente}\nMarca: {marca}\nPotencia: {potencia}\nEstado: {3}\nNumero de linea: {linea}\nParadas: {paradas}\nCantidad maxima de pasajeros: {pasajeros_max}";
        }

    }
}
