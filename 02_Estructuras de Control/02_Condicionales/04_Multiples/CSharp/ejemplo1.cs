using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Elaborar un programa que calcule el IMC

            // Entrada

            float Peso, Altura, IMC;
            Console.WriteLine("Ingrese su peso: ");
            Peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura: ");
            Altura = float.Parse(Console.ReadLine());

            // Proceso

            IMC = Peso / (float) Math.Pow(Altura, 2);

            // Salida

            if (IMC > 30) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OBESO");
                Console.ResetColor();
            }

            else if (IMC >=25) 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Sobre peso");
                Console.ResetColor();
            }

            else if (IMC >= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Normal");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bajo peso");
                Console.ResetColor();
            }

            Console.WriteLine("TU IMC es: " + IMC);

            Console.ReadKey();
        }
    }
}
