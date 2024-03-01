class Program
{
    static void Main(string[] args)
    {
        int recordCarlos = 1000;
        int recordJuan = 800;
        int recordJian = 400;
        string Jugador;
        int record = 0;
        Console.WriteLine("Bienvenido estas son los jugadores con las puntuaciones más altas");
        Console.WriteLine($"CARLOS {recordCarlos}");
        Console.WriteLine($"JUAN {recordJuan}");
        Console.WriteLine($"JIAN {recordJian}");
        Console.WriteLine("Coloque su nombre");
        Jugador = Console.ReadLine();
        Console.WriteLine("coloque su Record");
        //int.TryParse(input, out result): Intenta convertir la cadena de texto
        //(input) en un número entero (int). Si la conversión tiene éxito, asigna el valor convertido a la variable 
        int.TryParse(Console.ReadLine(), out record);

        if (record > recordCarlos)
        {
            Console.WriteLine($"¡Felicidades! {Jugador} Tienes un récord de {record} mayor que el de Carlos, que tiene un récord de {recordCarlos}.");
            Console.WriteLine($"Felicidades {Jugador} Tines la puntuacion Más alta de todos");
        }
        else if (record > recordJuan)
        {
            Console.WriteLine($" La mayor puntuacion la sigue teniendo Carlos {recordCarlos} \n¡Felicidades!  {Jugador} Tienes un récord de {record} mayor que el de Juan, que tiene un récord de {recordJuan}.");
        }
        else if (record > recordJian)
        {
            Console.WriteLine($"La mayor puntuacion la sigue teniendo Carlos {recordCarlos} \n¡Felicidades!  {Jugador} Tienes un récord de {record} mayor que el de Jian, que tiene un récord de {recordJian}.");
        }
        else
        {
            Console.WriteLine($"La mayor puntuacion la sigue teniendo Carlos {recordCarlos}");
            Console.WriteLine($" {Jugador} récord es menor que el de los demás jugadores.");
        }

        Console.WriteLine("¡Gracias por participar!");

    }
}

