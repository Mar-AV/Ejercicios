using System;

namespace Ejercicios.Clases.Ejercicio1
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            // Ejercicio 1: Clase Empleado
            Empleado empleado = new Empleado("Juan Pérez", 5000);
            Console.WriteLine($"Empleado: {empleado.Nombre}, Salario: {empleado.Salario}");

            try
            {
                Empleado empleadoVacio = new Empleado("", 3000); // Debería fallar
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                Empleado empleadoNegativo = new Empleado("María", -1000); // Debería fallar
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class Empleado
    {
        private string _nombre;
        private double _salario;

        public string Nombre
        {
            get => _nombre;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar en blanco.");
                _nombre = value;
            }
        }

        public double Salario
        {
            get => _salario;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("El salario no puede ser negativo.");
                _salario = value;
            }
        }

        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }
    }
}