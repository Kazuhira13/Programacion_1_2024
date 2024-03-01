using Tarena_No3_Ejeercicio_2;

internal class program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();
        Console.WriteLine("Ingrese el primer numero");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int x2 = int.Parse(Console.ReadLine());

        int suma = calculadora.suma(x1 , x2);
        int resta = calculadora.resta(x1 , x2);
        int multiplicacion = calculadora.Multiplicacion(x1 , x2);
        int division = calculadora.Division(x1 ,x2);

        Console.WriteLine($"La suma es: {suma} ");
        Console.WriteLine($"La resta es: {resta} ");
        Console.WriteLine($"La multiplicacion es: {multiplicacion} ");
        Console.WriteLine($"La division es: {division} ");

    }
}
