using System;

class Program
{
    static void Main(string[] args)
    {
        int Puntos = 0;
        int cantidad = 0;

        Console.WriteLine("Ingrese los puntajes del estudiante (ingrese 'fin' para terminar):");

        while (true)
        {
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
            {
                if (cantidad == 0)
                {
                    Console.WriteLine("No se ingresaron puntajes.");
                }
                else
                {
                    double promedio = (double)Puntos / cantidad;
                    Console.WriteLine($"El promedio de los puntajes del estudiante es: {promedio}");
                }
                break;
            }

            if (int.TryParse(entrada, out int puntaje) && puntaje >= 1 && puntaje <= 10)
            {
                Puntos += puntaje;
                cantidad++;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un puntaje válido (entre 1 y 10) o 'fin' para terminar.");
            }
        }
    }
}
