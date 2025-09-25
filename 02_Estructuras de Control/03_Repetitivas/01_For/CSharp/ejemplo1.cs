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
            Console.WriteLine("Ingrese la cantidad de alumnos: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int menor12 = 0;
            int mayor = 0;
            int menor = 0;

            Console.WriteLine("Ingrese la nota del alumno 1:");
            int nota = int.Parse(Console.ReadLine());

            mayor = nota;
            menor = nota;

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Ingrese la nota del alumno {i}");
                nota = int.Parse(Console.ReadLine());

                if (nota < 12)
                {
                    menor12++;
                }
                if (nota > mayor)
                {
                    mayor = nota;
                }
                if (nota < menor)
                {
                    menor = nota;
                }
            }

            Console.WriteLine();
            Console.WriteLine("===== RESULTADOS =====");
            Console.WriteLine();
            Console.WriteLine($"Cantidad de alumnos con notas menor a 12: {menor12}");
            Console.WriteLine($"Nota mayor: {mayor}");
            Console.WriteLine($"Nota menor: {menor}");
            Console.ReadKey();
        }
    }
}