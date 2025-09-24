using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2Doble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verificación de mayoría de edad");
            
            // Entrada

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===== Verificación de Mayoría de Edad =====");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            // Proceso + Salida

            if (edad >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usted es menor de edad.");
            }

            Console.ResetColor();
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}