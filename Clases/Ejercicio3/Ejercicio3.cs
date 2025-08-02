using System;
using System.Collections.Generic;

namespace Ejercicios.Clases.Ejercicio3
{
    public class Ejercicio3
    {
        public static void Ejecutar()
        {
            // Ejercicio 1: Notificaciones
            List<Notificacion> notificaciones = new List<Notificacion>
            {
                new NotificacionEmail(),
                new NotificacionSMS(),
                new NotificacionPush()
            };
            Console.WriteLine("Ejecutando notificaciones:");
            foreach (var notificacion in notificaciones)
            {
                notificacion.Enviar();
            }

            // Ejercicio 2: Comandos de voz
            List<ComandoVoz> comandos = new List<ComandoVoz>
            {
                new EncenderLuces(),
                new ReproducirMusica(),
                new MostrarClima()
            };
            Console.WriteLine("\nEjecutando comandos de voz:");
            EjecutarComandos(comandos);

            // Ejercicio 3: Pagos
            List<Pago> pagos = new List<Pago>
            {
                new PagoConTarjeta(),
                new PagoConEfectivo(),
                new PagoConTransferencia()
            };
            Console.WriteLine("\nProcesando pagos en la caja registradora:");
            foreach (var pago in pagos)
            {
                pago.ProcesarPago();
            }
        }

        private static void EjecutarComandos(List<ComandoVoz> comandos)
        {
            foreach (var comando in comandos)
            {
                comando.Ejecutar();
            }
        }
    }

    // Ejercicio 1: Notificaciones
    public abstract class Notificacion
    {
        public abstract void Enviar();
    }

    public class NotificacionEmail : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando correo electrónico...");
        }
    }

    public class NotificacionSMS : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando SMS...");
        }
    }

    public class NotificacionPush : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando notificación push...");
        }
    }

    // Ejercicio 2: Comandos de voz
    public abstract class ComandoVoz
    {
        public abstract void Ejecutar();
    }

    public class EncenderLuces : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Encendiendo las luces...");
        }
    }

    public class ReproducirMusica : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Reproduciendo música...");
        }
    }

    public class MostrarClima : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Mostrando el clima actual...");
        }
    }

    // Ejercicio 3: Pagos
    public abstract class Pago
    {
        public abstract void ProcesarPago();
    }

    public class PagoConTarjeta : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Procesando pago con tarjeta...");
        }
    }

    public class PagoConEfectivo : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Recibiendo efectivo...");
        }
    }

    public class PagoConTransferencia : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Iniciando transferencia bancaria...");
        }
    }
}