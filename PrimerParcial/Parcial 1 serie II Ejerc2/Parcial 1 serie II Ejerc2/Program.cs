internal class program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[4];
        int sumaPares = 0;
        int sumaImpares = 0;
         for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Ingrese los datos",i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("numeros pares");
        foreach (int num in numeros)
        {
            if (num % 2 == 0)
            {
                sumaPares += num;
                Console.WriteLine(num);
            }
        }

        Console.WriteLine("numeros impares");
        foreach (int num in numeros)
        {
            if (num % 2 == 1)
            {
                sumaImpares += num;
                Console.WriteLine(num);
            }
        }
        Console.WriteLine("Suma de numeros pares:" + sumaPares);
        Console.WriteLine("Suma de numeros impares:" +sumaImpares);

 


    }
}
