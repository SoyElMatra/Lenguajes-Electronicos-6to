using Examen_Martin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen_Martin
{
    class camion_carga : vehiculos
    {
        private int carga_maxima;
        private int cantidad_ejes;

        public int Carga_maxima
        {
            get
            {
                return carga_maxima;
            }
            set
            {
                carga_maxima = value;
            }
        }
        public int Cantidad_ejes
        {
            get
            {
                return cantidad_ejes;
            }
            set
            {
                cantidad_ejes = value;
            }
        }

        public camion_carga(int carga_maxima, int cantidad_ejes, string patente, string marca, int potencia_motor, bool estado) : base(patente, marca, potencia_motor, estado)
        {
            Carga_maxima = carga_maxima;
            Cantidad_ejes = cantidad_ejes;
            Patente = patente;
            Marca = marca;
            Potencia = potencia;
            Estado = estado;
        }

        public bool cargado_o_no()
        {
            if (Carga_maxima > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int costo_viaje()
        {
            switch (Cantidad_ejes)
            {
                case 1:
                    return 100;
                    break;
                case 2:
                    return 200;
                    break;
                case 3:
                    return 300;
                    break;
                case 4:
                    return 400;
                    break;
                default:
                    return 0;
            }
        }

        public override string ToString()
        {
            return $"\nPatente: {patente}\nMarca: {marca}\nPotencia: {potencia}\nEstado: {estado}\nEjes: {cantidad_ejes}";
        }
    }
}
