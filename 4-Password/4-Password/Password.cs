using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Password
{
    class Password
    {
        private int longitud;
        private string contraseña;

        public Password()
        {
            longitud = 0;
            contraseña = "\0";
        }
        public Password(int longitud)
        {
            this.longitud = longitud;
        }

        private string generarContraseña()
        {
            string caracteres = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
            string nuevacontra = "";

            for (int i = 0;i < longitud; i++)
            {
                int posicion = random.Next(caracteres.Length);
                nuevacontraseña += caracteres[posicion];
            }
        }

        public bool esFuerte()
        {
            int mayus = 0, int minus = 0, int nums = 0;
            foreach (char letra in contraseña)
            {
                if (char.IsUpper(letra))
                {
                    mayus++;
                }else if (char.IsLower(letra))
                {
                    minus++;
                }else if (char.IsDigit(letra))
                {
                    nums++;
                }
            }
        }
        public string Contraseña
        {
            get
            {
                return contraseña;
            }
        }
        public int Longitud
        {
            get
            {
                return longitud;
            }
        }
    }
}
