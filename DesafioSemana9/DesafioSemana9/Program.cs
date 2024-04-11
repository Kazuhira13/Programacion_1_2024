using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string texto = "Este es mi correo electrónico: juan_perez.23@gmail.com. Por favor, envíeme un correo con sus comentarios.";
        string texto2 = "Este es otro correo Carlos1314@gmail.com que debes enviarme el documento.";
        string patron = @"\b[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}\b";
        MatchCollection coincidencias = Regex.Matches(texto, patron);
        MatchCollection coincidencias2 = Regex.Matches(texto2, patron);
       

        Console.WriteLine("Direcciones de correo electrónico encontradas:");
        foreach (Match coincidencia in coincidencias)
        {
            Console.WriteLine(coincidencia.Value);
        }
        foreach (Match coincidencia2 in coincidencias2)
        {
            Console.WriteLine(coincidencia2.Value);
        }
    }
}
