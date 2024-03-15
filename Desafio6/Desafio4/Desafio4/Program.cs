using Desafio4;

class MiClase
{
    private double alto;
    private double largo;

    public double Alto
    {
        get { return alto; }
        set { alto = value; }
    }

    public double Largo
    {
        get { return largo; }
        set { largo = value; }
    }

    public double SuperficieFrontal
    {
        get { return Alto * Largo; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SuperficieFrontal objeto = new SuperficieFrontal();
        objeto.Alto = 10;
        objeto.Largo = 5;
        double rec = objeto.rec;
        //Console.WriteLine($"La superficie frontal del rectángulo es: {rec}");

    }
}
