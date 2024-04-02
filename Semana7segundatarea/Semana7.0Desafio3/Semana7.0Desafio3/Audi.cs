using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7._0Desafio3
{
    internal class Audi: auto
    {
        
        private string marca = "Audi";

        
        public string Modelo { get; set; }

        
        public Audi(int hp, string color, string modelo) : base(hp, color)
        {
            this.Modelo = modelo;
        }

        
        public void MostrarDetalles()
        {
            Console.WriteLine("Marca: {0} - Modelo: {1} - HP: {2} - Color: {3}", marca, Modelo, HP, Color);
        }

        public override void Reparar()
        {
            Console.WriteLine("El Audi {0} está reparado", Modelo);
        }
    }
}
    