using System;
using System.Collections.Generic;

namespace Ejercicios.Clases.Ejercicio4
{
    public class Ejercicio4
    {
        public static void Ejecutar()
        {
            // Ejercicio 1: ArchivoMultimedia
            List<ArchivoMultimedia> multimedia = new List<ArchivoMultimedia>
            {
                new Video(),
                new Cancion(),
                new AudioLibro()
            };
            Console.WriteLine("Reproduciendo archivos multimedia:");
            foreach (var archivo in multimedia)
            {
                archivo.Reproducir();
            }

            // Ejercicio 2: IValidador
            List<IValidador> validadores = new List<IValidador>
            {
                new ValidadorEmail(),
                new ValidadorTelefono(),
                new ValidadorDPI()
            };
            string[] datos = { "usuario@ejemplo.com", "1234567890", "1234567890123" };
            Console.WriteLine("\nValidando datos:");
            foreach (var dato in datos)
            {
                foreach (var validador in validadores)
                {
                    Console.WriteLine($"{validador.GetType().Name} - {dato}: {(validador.EsValido(dato) ? "Válido" : "No válido")}");
                }
            }

            // Ejercicio 3: DispositivoSalida
            List<DispositivoSalida> dispositivos = new List<DispositivoSalida>
            {
                new Pantalla(),
                new Proyector(),
                new Impresora()
            };
            string[] mensajes = { "Hola mundo", "Reunión a las 10", "Informe final" };
            Console.WriteLine("\nMostrando mensajes en dispositivos:");
            foreach (var dispositivo in dispositivos)
            {
                foreach (var mensaje in mensajes)
                {
                    dispositivo.MostrarMensaje(mensaje);
                }
            }
        }
    }

    // Ejercicio 1: ArchivoMultimedia
    public abstract class ArchivoMultimedia
    {
        public abstract void Reproducir();
    }

    public class Video : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo video...");
        }
    }

    public class Cancion : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo canción...");
        }
    }

    public class AudioLibro : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo audiolibro...");
        }
    }

    // Ejercicio 2: IValidador
    public interface IValidador
    {
        bool EsValido(string dato);
    }

    public class ValidadorEmail : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Contains("@") && dato.Contains(".");
        }
    }

    public class ValidadorTelefono : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Length == 10 && long.TryParse(dato, out _);
        }
    }

    public class ValidadorDPI : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Length == 13 && long.TryParse(dato, out _);
        }
    }

    // Ejercicio 3: DispositivoSalida
    public abstract class DispositivoSalida
    {
        public abstract void MostrarMensaje(string mensaje);
    }

    public class Pantalla : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

    public class Proyector : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"Lanzando proyección: {mensaje}");
        }
    }

    public class Impresora : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"Imprimiendo mensaje: {mensaje}");
        }
    }
}