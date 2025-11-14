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
        private static Random rnd = new Random();

        // Constructor por defecto (8 caracteres)
        public Password()
        {
            this.longitud = 8;
            this.contraseña = GenerarPassword();
        }

        // Constructor con longitud personalizada
        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = GenerarPassword();
        }

        // Genera una contraseña aleatoria
        private string GenerarPassword()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] password = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                password[i] = caracteres[rnd.Next(caracteres.Length)];
            }

            return new string(password);
        }

        // Verifica si la contraseña es fuerte (2 mayúsculas, 1 minúscula, 5 números)
        public bool EsFuerte()
        {
            int mayusculas = 0, minusculas = 0, numeros = 0;

            foreach (char c in contraseña)
            {
                if (char.IsUpper(c)) mayusculas++;
                else if (char.IsLower(c)) minusculas++;
                else if (char.IsDigit(c)) numeros++;
            }

            return mayusculas >= 2 && minusculas >= 1 && numeros >= 5;
        }

        // Propiedades
        public string Contraseña
        {
            get { return contraseña; }
        }

        public int Longitud
        {
            get { return longitud; }
        }
    }
}
