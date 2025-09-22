using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hallar la hipotenusa de un triángulo rectángulo.
             */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===== Cálculo de la Hipotenusa de un Triángulo Rectángulo =====");
            Console.ResetColor();
            Console.WriteLine();
             
            // Entrada de datos

            Console.Write("Ingrese el valor del cateto 1: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double cateto1 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Ingrese el valor del cateto 2: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double cateto2 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            // Proceso

            double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            // Salida de datos

            Console.WriteLine();
            Console.WriteLine("La hipotenusa del triángulo rectángulo es: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{hipotenusa:F2} unidades");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
