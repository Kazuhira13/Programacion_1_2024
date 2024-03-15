using Desafio5;

internal class program
{
    static void Main(string[] args)
    {
        GestorCajas gestor = new GestorCajas();

        Console.Write("Ingrese la cantidad de cajas: ");
        int cantidadCajas = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidadCajas; i++)
        {
            Console.WriteLine($"Ingrese los datos de la caja {i + 1}:");
            Console.Write("Largo: ");
            double largo = double.Parse(Console.ReadLine());
            Console.Write("Ancho: ");
            double ancho = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());

            gestor.AgregarCaja(largo, ancho, altura);
        }


        double volumenTotal = gestor.CalcularVolumenTotal();
        double volumenPromedio = gestor.CalcularVolumenPromedio();


        Console.WriteLine($"\nVolumen total de las cajas: {volumenTotal}");
        Console.WriteLine($"Volumen promedio de las cajas: {volumenPromedio}");

        Console.ReadLine();
    }
}