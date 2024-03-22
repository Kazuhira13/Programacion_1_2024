

internal class program
{
    static void Main(string[] args)
    {
        
        double[,] compras = {
            { 50.0, 75.0, 120.0, 80.0, 90.0 },   
            { 100.0, 200.0, 300.0, 400.0, 500.0 }, 
            { 1000.0, 2000.0, 3000.0, 4000.0, 10000.0 }, 
            { 10.0, 20.0, 30.0, 40.0, 50.0 },   
            { 1100.0, 1300.0, 900.0, 1400.0, 1200.0 } 
        };

        CalcularTotalComprasConDescuento(compras);
    }
    public static void CalcularTotalComprasConDescuento(double[,] compras)
    {
        const int numClientes = 5;
        const int numCompras = 5;
        double[] totalesCompras = new double[numClientes];
        double[] totalesConDescuento = new double[numClientes];


        for (int i = 0; i < numClientes; i++)
        {
            for (int j = 0; j < numCompras; j++)
            {
                totalesCompras[i] += compras[i, j];
            }
        }


        for (int i = 0; i < numClientes; i++)
        {
            if (totalesCompras[i] < 100)
            {
                totalesConDescuento[i] = totalesCompras[i];
            }
            else if (totalesCompras[i] < 1000)
            {
                totalesConDescuento[i] = totalesCompras[i] * 0.9;
            }
            else
            {
                totalesConDescuento[i] = totalesCompras[i] * 0.8;
            }
        }


        for (int i = 0; i < numClientes; i++)
        {
            Console.WriteLine($"Cliente {i + 1}:");
            Console.WriteLine($"Total de compras: ${totalesCompras[i]}");
            Console.WriteLine($"Total con descuento: ${totalesConDescuento[i]}");
            Console.WriteLine();
        }
    }
}