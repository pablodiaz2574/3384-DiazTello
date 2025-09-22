using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de datos

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Cálculo de Promedio Ponderado ===");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Ingrese la Nota 1 (20%): ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Nota 2 (30%): ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Nota 3 (40%): ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Nota 4 (10%): ");
            double nota4 = double.Parse(Console.ReadLine());

            // Proceso

            double promedioPonderado = (nota1 * 0.20) + (nota2 * 0.30) + (nota3 * 0.40) + (nota4 * 0.10);

            // Salida de datos

            Console.WriteLine();
            Console.WriteLine($"El promedio ponderado es: {promedioPonderado:F2}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
