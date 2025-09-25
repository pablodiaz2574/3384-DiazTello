using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1Anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa para Determinar el Nivel de Capacitación de un Postulante con Indicadores Visuales por Rango de Desempeño
             */
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("===== CLASIFICACIÓN DEL NIVEL DE CAPACITACIÓN =====");
            Console.ResetColor();
            Console.WriteLine();

            // Entrada datos

            Console.WriteLine("Ingrese la cantidad total de preguntas realizadas: ");
            int totalpreguntas = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ingrese la cantidad de preguntas contestadas correctamente: ");
            int correctas = int.Parse(Console.ReadLine());

            // Proceso

            if (totalpreguntas <= 0 || correctas < 0 || correctas > totalpreguntas)
            {
                Console.WriteLine("Error: Datos inválidos. Asegúrese de ingresar valores correctos. ");
                return;
            }

            double porcentaje = (double)correctas / totalpreguntas * 100;

            string nivel;

            if (porcentaje >= 90.0)
            {
                nivel = "Nivel máximo";
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else if (porcentaje >= 75.0)
            {
                nivel = "Nivle medio";
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            else if (porcentaje >= 50.0)
            {
                nivel = "Nivel regular";
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            else
            {
                nivel = "Fuera de nivel";
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine();
            Console.WriteLine($"Resultados:");
            Console.WriteLine($"Total de preguntas: {totalpreguntas}");
            Console.WriteLine($"Respuestas correctas: {correctas}");
            Console.WriteLine($"Porcentaje obtenido: {porcentaje:F2}%");
            Console.WriteLine($"Nivel asignado: {nivel}");

            Console.ResetColor();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}