using Semana7._0Desafio3;

internal class program
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            var autos = new List<auto>
            {
                new Audi(200,"azul","A4"),
                new BMW(250, "rojo","M3")
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }

            auto auto1 = new BMW(200, "negro", "Z3");
            auto auto2 = new Audi(100, "verde", "A3");

            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            BMW bmwM5 = new BMW(330, "blanco", "M5");
            bmwM5.MostrarDetalles();

            auto autoB = (auto)bmwM5;
            autoB.MostrarDetalles();

            BMW bmw = new BMW(300, "Rojo", "Serie 3");
            bmw.Reparar();

            string[] reparacionesDesdeArchivo = File.ReadAllLines("reparaciones_bmw.txt");
            bmw.HistoriaDeReparaciones.AddRange(reparacionesDesdeArchivo);

            bmw.ImprimirHistoriaDeReparaciones();





            Console.Read();
        }
    }
}