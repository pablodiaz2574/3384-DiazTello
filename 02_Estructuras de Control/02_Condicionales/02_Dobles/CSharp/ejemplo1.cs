using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa para determirar si un número es impar y múltiplo de 5
             */

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===== Cálculo de un número si es impar y múltiplo de 5 =====");
            Console.ResetColor();
            Console.WriteLine();

            // Entrada

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            // Proceso + Salida

            if (numero % 2 != 0 && numero % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El número es impar y múltiplo de 5.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El número NO es impar y múltiplo de 5.");
                Console.ResetColor();
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}