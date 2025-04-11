using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el sexo(H/M): ");
            char sexo = char.ToUpper(char.Parse(Console.ReadLine()));

            Console.Write("Ingrese el peso (kg): ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura (m): ");
            float altura = float.Parse(Console.ReadLine());

            Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona persona2 = new Persona(nombre, edad, sexo);
            Persona persona3 = new Persona();

            comprobarIMC(persona1);

            Console.WriteLine("\nInformacion de la pipol:");
            Console.WriteLine(persona1.ToString());
        }
        private static void comprobarIMC(Persona persona)
        {
            int imcResultado = persona.calcularIMC();
            string estadoIMC;

            if (imcResultado == -1)
            {
                estadoIMC = "Esta en su peso ideal.";
            }
            else if (imcResultado == 0)
            {
                estadoIMC = "Esta por debajo de su peso ideal.";
            }
            else
            {
                estadoIMC = "Tiene sobrepeso.";
            }
            Console.WriteLine($"{persona.Nombre} {estadoIMC}");
            Console.WriteLine($"{persona.Nombre} es mayor de edad: {persona.esMayordeEdad()}");
        }
    }
}
