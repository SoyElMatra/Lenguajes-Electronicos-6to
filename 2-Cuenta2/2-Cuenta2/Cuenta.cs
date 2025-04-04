using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cuenta2
{
    class Cuenta
    {
        string titular;
        float cantidad;
        public Cuenta(string titular, float cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }

        public string Titular
        {
            get
            {
                return titular;
            }
            private set
            {
                titular = value;
            }
        }
        public float Cantidad
        {
            get
            {
                return cantidad;
            }
            private set
            {
                cantidad = value;
            }
        }

        public override string ToString()
        {
            return string.Format("El titular es {0} y la cantidad es {1}", Titular, Cantidad);
        }
        public void ingresar(float cantidad)
        {
            if (cantidad > 0)
            {
                Cantidad = cantidad + Cantidad;
            }
        }
        public void retirar(float cantidad)
        {
            if (Cantidad > cantidad)
            {
                Cantidad = Cantidad - cantidad;
            }
        }
    }
}
