internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero Positivo");
        int dato =  int.Parse(Console.ReadLine());
        Console.WriteLine("estos son los numeros pares");
        for (int i = 1; i <= dato; i++)
        {
            if (i%2 == 0)
            {
                Console.WriteLine(i);
               
            }
        }
    }
}