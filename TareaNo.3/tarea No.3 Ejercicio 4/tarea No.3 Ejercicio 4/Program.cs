internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Comenzamos Registrando usuario");
        Console.WriteLine("Coloque Nombre");
        string Nick = Console.ReadLine();
        Console.WriteLine("Coloque su contraseña");
        int Pass = int.Parse(Console.ReadLine());
        Console.WriteLine("Excelente ya esta registrado quiere iniciar sesion? coloque si");
        string respusta = Console.ReadLine();
        if (respusta.ToLower() == "si")
        {
            Console.WriteLine("Hola Comenzaremos el inicio de sesio");
            Console.WriteLine("Coloque usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Coloque su contraseña");
            int password = int.Parse(Console.ReadLine());
            if (usuario == Nick && Pass == password)
            {
                Console.WriteLine($"Bienvenido {Nick} Como ha estado el login?");
            }
            else
            {
                Console.WriteLine("Usuario o Contraseña Incorrecta!!!!!!!!");
            }
        }
        else
        {
            Console.WriteLine("Que tenga un Buen dia");
        }

     }
}