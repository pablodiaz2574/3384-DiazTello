using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa para identificar si un número es par
             */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===== Verificación si un número es par =====");
            Console.ResetColor();
            Console.WriteLine();

            // Entrada de datos

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            // Proceso + Salida de datos

            if (numero % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El número es par");
                Console.ResetColor();
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}