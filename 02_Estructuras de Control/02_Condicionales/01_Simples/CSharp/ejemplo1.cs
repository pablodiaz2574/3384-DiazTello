using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa para Determinar el Impuesto a la Renta si Supera 4000 Soles.
             */

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("===== Cálculo del Impuesto a la Renta (5%) =====");
            Console.ResetColor();
            Console.WriteLine();

            // Entrada datos
            
            Console.WriteLine("Ingrese el monto de la renta ");
            Console.WriteLine();

            float renta = float.Parse(Console.ReadLine());
            Console.WriteLine();

            // Proceso + Salida de datos

            if (renta > 4000)
            {
                double impuesto = renta * 0.05;
                Console.WriteLine("El impuesto a pagar es: " + impuesto);
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

    }
}