using Semana7desafio1;

internal class program
{
    public static void  Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();
        calculadora.Marca = "Casio";
        calculadora.Serie = "FX-991EX";

        Calculadora_cientifica CalCien = new Calculadora_cientifica();
        CalCien.Marca = "Casio";
        CalCien.Serie = "FX-878EX";

        Console.WriteLine("suma:" + calculadora.sumar(5, 3));
        Console.WriteLine("Potencia:" + CalCien.Potencia(10,2));
    }
}