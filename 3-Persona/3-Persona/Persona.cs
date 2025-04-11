using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_Persona
{
    class Persona
    {
        private float peso, altura;
        private int edad, dni;
        private string nombre;
        private char sexo;
        public Persona()
        {
            nombre = "\0";
            edad = 0;
            dni = generarDNI();
            sexo = 'H'; //Hombre por defecto
            peso = 0;
            altura = 0;
        }
        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
            dni = generarDNI();
            peso = 0;
            altura = 0;
        }
        public Persona(string nombre, int edad, char sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
            dni = generarDNI();
            this.peso = peso;
            this.altura = altura;
        }
        public int calcularIMC()
        {
            if(altura == 0)
            {
                return 0;
            }
            float imc = peso / (altura * altura);
            if(imc < 20)
            {
                return -1;
            }else if(imc >= 20 && imc <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public string esMayordeEdad()
        {
            if(edad >= 18)
            {
                return "si";
            }
            else
            {
                return "no";
            }
        }
        private char comprobarSexo(char sexo)
        {
            if(sexo != 'H' && sexo != 'M')
            {
                return 'H'; //por defecto hombre
            }
            return sexo;
        }
        private int generarDNI()
        {
            Random random = new Random();
            return random.Next(1000000, 100000000);
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = comprobarSexo(value);
            }
        }
        public float Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }
        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }
        public int DNI
        {
            get
            {
                return dni;
            }
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, DNI: {dni}, Sexo: {sexo}, Peso: {peso}, Altura: {altura}";
        }
    }
}