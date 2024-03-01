internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido");
        Console.WriteLine("Ingresa tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingresa ganancias de los ultimos tres meses.");
        Console.WriteLine("ingrese numero 1");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese numero 2");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese numero 3");
        int n3 = int.Parse(Console.ReadLine());
        int total = n1 + n2+ n3;
        int promedio = total / 3;
        Console.WriteLine($"Hola {nombre} en total son: {total} y el promedio es:{promedio}" );



    }

}