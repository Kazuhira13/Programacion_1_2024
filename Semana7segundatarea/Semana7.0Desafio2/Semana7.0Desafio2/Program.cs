using System.Security.Cryptography.X509Certificates;
using Semana7._0Desafio2;
using static Semana7._0Desafio2.Clase.NotificacionWhatsapp;
using static Semana7._0Desafio2.Clase;

internal class program
{
    public static void Main(string[] args)
    {
       
        NotificacionEmail notificacionEmail = new NotificacionEmail();
        notificacionEmail.DireccionCorreo = "Carlos1314@gmail.com";
        notificacionEmail.Notifica();

       
        NotificacionWhatsapp notificacionWhatsapp = new NotificacionWhatsapp();
        notificacionWhatsapp.NumeroTelefono = "+502 4891-3258";
        notificacionWhatsapp.Notifica();

        
        NotificacionSMS notificacionSMS = new NotificacionSMS();
        notificacionSMS.NumeroTelefono = "+502 5535-8790";
        notificacionSMS.Notifica();
    }

}
