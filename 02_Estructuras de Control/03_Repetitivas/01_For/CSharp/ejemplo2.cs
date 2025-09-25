using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  CONTADOR DE NÚMEROS IMPARES Y POSITIVOS");
            Console.WriteLine();

            Console.Write("Ingrese la cantidad de números (n): ");
            int n = int.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                int numero = int.Parse(Console.ReadLine());

                // Verificar si es positivo y impar
                if (numero > 0 && numero % 2 != 0)
                {
                    contador++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine($"RESULTADO: {contador} número(s) son impares y positivos.");
            Console.WriteLine("==================================");
            Console.ReadKey();
        }
    }
}