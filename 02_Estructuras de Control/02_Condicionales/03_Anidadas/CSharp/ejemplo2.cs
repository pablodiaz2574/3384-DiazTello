using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2Anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa para Determinar el Estado Académico de un Alumno con Indicadores Visuales por Rango de Desempeño
             */

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("===== DETERMINACIÓN DEL ESTADO ACADÉMICO DEL ALUMNO =====");
            Console.ResetColor();
            Console.WriteLine();

            // Entrada datos

            Console.Write("Ingrese la primera nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            // Proceso

            double promedio = (nota1 + nota2 + nota3) / 3;

            string estado;

            if (promedio >= 10.0)
            {
                estado = "Fuera de rango";
            }
            else if (promedio >= 7.0)
            {
                estado = "Promocionado";
            }
            else if (promedio >= 4.0)
            {
                estado = "Regular";
            }
            else
            {
                estado = "Reprobado";
            }

            // Salida de resultados

            Console.WriteLine();
            Console.WriteLine($"Resultados:");
            Console.WriteLine($"Nota 1: {nota1}");
            Console.WriteLine($"Nota 2: {nota2}");
            Console.WriteLine($"Nota 3: {nota3}");
            Console.WriteLine();
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine();
            Console.WriteLine($"Estado académico: {estado}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}