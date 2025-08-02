using Ejercicios.Clases.Ejercicio1;
using Ejercicios.Clases.Ejercicio2;
using Ejercicios.Clases.Ejercicio3;
using Ejercicios.Clases.Ejercicio4;
using System;

namespace Ejercicios
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el grupo de ejercicios a ejecutar:");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");

            string opcion = Console.ReadLine();

            if (string.IsNullOrEmpty(opcion))
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            switch (opcion)
            {
                case "1":
                    Ejercicio1.Ejecutar();
                    break;
                case "2":
                    Ejercicio2.Ejecutar();
                    break;
                case "3":
                    Ejercicio3.Ejecutar();
                    break;
                case "4":
                    Ejercicio4.Ejecutar();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}