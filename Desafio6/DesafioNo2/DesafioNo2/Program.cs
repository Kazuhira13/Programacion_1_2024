using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool Primo = true;
        if (numero <= 1)
        {
            Console.WriteLine("El número ingresado no es primo.");
            return;
        }


        for (int i = 2; i <= numero / 2; i++)
        {
            if (numero % i == 0)
            {
                Primo = false;
                break;
            }
        }

        if (Primo)
        {
            Console.WriteLine("El número ingresado es primo.");
        }
        else
        {
            Console.WriteLine("El número ingresado no es primo.");
        }
    }
}

