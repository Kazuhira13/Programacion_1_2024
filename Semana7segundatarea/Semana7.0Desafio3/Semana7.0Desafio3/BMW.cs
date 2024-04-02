using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7._0Desafio3
{
    internal class BMW : auto
    {
        
        private string marca = "BMW";

        
        public string Modelo { get; set; }

        
        public BMW(int hp, string color, string modelo) : base(hp, color)
        {
            this.Modelo = modelo;
        }

        
        public new void MostrarDetalles()
        {
            Console.WriteLine("Marca: {0} - Modelo: {1} - HP: {2} - Color: {3}", marca, Modelo, HP, Color);
        }

        public override void Reparar()
        {
            string reparacion = $"El BMW {Modelo} está reparado";
            Console.WriteLine(reparacion);
            HistoriaDeReparaciones.Add(reparacion);
            File.AppendAllText("reparaciones_bmw.txt", reparacion + Environment.NewLine);
        }
    }
}
