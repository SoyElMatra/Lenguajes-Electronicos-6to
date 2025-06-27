using Examen_Martin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen_Martin
{
    class taxis_premium : taxis
    {
        private bool bebidas;
        private bool conductor_bilingue;

        public bool Conductor_bilingue
        {
            get
            {
                return conductor_bilingue;
            }
            set
            {
                conductor_bilingue = value;
            }
        }

        public bool Bebidas
        {
            get
            {
                return bebidas;
            }
            set
            {
                bebidas = value;
            }
        }

        public taxis_premium(bool bebidas, bool conductor_bilingue, int licencia, int valor_bandera, int precio_por_kilometro, string patente, string marca, int potencia_motor, bool estado, bool disponible) : base(licencia, valor_bandera, precio_por_kilometro, patente, marca, potencia_motor, estado, disponible)
        {
            Bebidas = bebidas;
            Conductor_bilingue = conductor_bilingue;
            Patente = patente;
            Marca = marca;
            Potencia = potencia;
            Estado = estado;
        }

        override public int costo_viaje(int kilometros)
        {
            int costo = base.costo_viaje(kilometros);
            costo += 5000;
            if (bebidas == true && conductor_bilingue == true)
            {
                costo += 2500;
            }
            return costo;
        }

        public bool lujo()
        {
            if (bebidas == true && conductor_bilingue == true)
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
            return $"\nPatente: {patente}\nMarca: {marca}\nPotencia: {potencia}\nEstado: {estado}\nPrecio p/ KM: {precio_kilometro}\nValor p/ bandera{valor_bandera}\nLicencia: {licencia}\nConductor bilingue: {conductor_bilingue}\nBebidas {bebidas}";
        }
    }
}
