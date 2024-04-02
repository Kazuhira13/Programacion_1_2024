using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Semana7._0Desafio2.Interfaz;

namespace Semana7._0Desafio2
{
    internal class Clase
    {
        public class NotificacionEmail : INotificable
        {
            public string DireccionCorreo { get; set; }

            public void Notifica()
            {
                Console.WriteLine($"Enviando notificación por correo electrónico a: {DireccionCorreo}");
            }
        }
        
        public class NotificacionWhatsapp : INotificable
        {
            public string NumeroTelefono { get; set; }

            public void Notifica()
            {
                Console.WriteLine($"Enviando notificación por WhatsApp al número: {NumeroTelefono}");
            }

            public class NotificacionSMS : INotificable
            {
                public string NumeroTelefono { get; set; }

                public void Notifica()
                {
                    Console.WriteLine($"Enviando notificación por SMS al número: {NumeroTelefono}");
                }
            }
        }
    }
}
