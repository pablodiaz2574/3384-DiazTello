using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp
{
    public class Ejercicio1
    {
        public void main areatriangulo() {
            //Definir Variables
         
            //Solicitar Datos
            Console.WriteLine("Ingrese Lado a: ");
            // Guardar Datos
            var a= int.Parse(Console.ReadLine());
            //Solicitar Datos
            Console.WriteLine("Ingrese Lado b: ");
            // Guardar Datos
            var b = int.Parse(Console.ReadLine());
            //Solicitar Datos
            Console.WriteLine("Ingrese Lado c: ");
            // Guardar Datos
            var c = int.Parse(Console.ReadLine());

            //Proceso

            //s = (a + b + c)/2; //s= semiperimetro
            var s = (a + b + c) / 2; // s = semiperimetro
            //area = Math.Sqrt(s * (s - a) * (s - b) - (s - c));
            var area = Math.Sqrt(s * (s - a) * (s - b) - (s - c));

            //Salida Datos

            Console.WriteLine($"El area del triangulo es segun lados {a},{b},{c} es:{area} m²");

            Console.WriteLine(); //Salto de Linea
            Console.WriteLine("Algoritmo Area Triangulo");

            Ejercicio1 ej1 = new Ejercicio1();
            ej1.areatriangulo();

            //Detener pantalla para ver resultados

            Console.ReadKey(); 
        }

    }
}
