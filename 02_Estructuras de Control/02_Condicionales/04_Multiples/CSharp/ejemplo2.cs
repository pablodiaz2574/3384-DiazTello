using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Mostrar mes y número de días =====");
            Console.WriteLine();

            // Entrada

            Console.Write("Ingrese un número del 1 al 12: ");
            int numero = int.Parse(Console.ReadLine());

            // Proceso + Salida

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Enero - 31 días");
                    break;
                case 2:
                    Console.WriteLine("Febrero - 28 días (29 en bisiesto)");
                    break;
                case 3:
                    Console.WriteLine("Marzo - 31 días");
                    break;
                case 4:
                    Console.WriteLine("Abril - 30 días");
                    break;
                case 5:
                    Console.WriteLine("Mayo - 31 días");
                    break;
                case 6:
                    Console.WriteLine("Junio - 30 días");
                    break;
                case 7:
                    Console.WriteLine("Julio - 31 días");
                    break;
                case 8:
                    Console.WriteLine("Agosto - 31 días");
                    break;
                case 9:
                    Console.WriteLine("Septiembre - 30 días");
                    break;
                case 10:
                    Console.WriteLine("Octubre - 31 días");
                    break;
                case 11:
                    Console.WriteLine("Noviembre - 30 días");
                    break;
                case 12:
                    Console.WriteLine("Diciembre - 31 días");
                    break;
                default:
                    Console.WriteLine("Número fuera de rango (1-12)");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}