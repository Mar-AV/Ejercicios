using System;

namespace Ejercicios.Clases.Ejercicio2
{
    public class Ejercicio2
    {
        public static void Ejecutar()
        {
            // Ejercicio 1: CuentaBancaria
            CuentaBancaria cuenta = new CuentaBancaria(1000, 500);
            Console.WriteLine($"Saldo inicial: {cuenta.MostrarSaldo()}");
            cuenta.Retirar(200);
            Console.WriteLine($"Saldo después de retirar 200: {cuenta.MostrarSaldo()}");
            try
            {
                cuenta.Retirar(600); // Supera el límite diario
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Ejercicio 2: Jerarquía de Vehículo
            Vehiculo auto = new Auto();
            Vehiculo moto = new Motocicleta();
            auto.Encender();
            auto.Avanzar();
            ((Auto)auto).EncenderRadio();
            auto.Apagar();
            moto.Encender();
            moto.Avanzar();
            ((Motocicleta)moto).HacerCaballito();
            moto.Apagar();
        }
    }

    // Ejercicio 1: CuentaBancaria
    public class CuentaBancaria
    {
        private double saldo;
        private double limiteRetiroDiario;

        public CuentaBancaria(double saldoInicial, double limite)
        {
            saldo = saldoInicial;
            limiteRetiroDiario = limite;
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > limiteRetiroDiario)
                throw new InvalidOperationException("El retiro excede el límite diario.");
            if (cantidad > saldo)
                throw new InvalidOperationException("Saldo insuficiente.");
            saldo -= cantidad;
            limiteRetiroDiario -= cantidad;
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }

    // Ejercicio 2: Jerarquía de Vehículo
    public class Vehiculo
    {
        private bool _encendido;

        public bool Encendido
        {
            get => _encendido;
            private set => _encendido = value;
        }

        public void Encender()
        {
            Encendido = true;
            Console.WriteLine("Vehículo encendido.");
        }

        public void Apagar()
        {
            Encendido = false;
            Console.WriteLine("Vehículo apagado.");
        }

        public virtual void Avanzar()
        {
            if (Encendido)
                Console.WriteLine("El vehículo está avanzando.");
            else
                Console.WriteLine("El vehículo debe estar encendido para avanzar.");
        }
    }

    public class Auto : Vehiculo
    {
        public void EncenderRadio()
        {
            if (Encendido)
                Console.WriteLine("Radio encendida.");
            else
                Console.WriteLine("El auto debe estar encendido para encender la radio.");
        }
    }

    public class Motocicleta : Vehiculo
    {
        public void HacerCaballito()
        {
            if (Encendido)
                Console.WriteLine("¡Haciendo caballito!");
            else
                Console.WriteLine("La motocicleta debe estar encendida para hacer caballito.");
        }
    }
}