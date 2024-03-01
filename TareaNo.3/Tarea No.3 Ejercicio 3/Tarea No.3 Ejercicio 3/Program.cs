internal class program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("ingrese Primer numero ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo numero ");
            int n2 = int.Parse(Console.ReadLine());
            int suma = n1+ n2;
            Console.WriteLine($"La sumatoria es: {suma}");
        }
        catch (Exception ex)
        {
            //aqui vamos a ejecutar acciones
            Console.Error.WriteLine("algo salio mal");
            Console.Error.WriteLine(ex.Message);
        }
        finally
        {
            //esto siemre se va ejecutar
            Console.WriteLine("esto siempre se ejecuta");

        }
    }
}