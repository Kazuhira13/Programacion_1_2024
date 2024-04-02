using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7._0Desafio3
{
    internal class auto
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public List<string> HistoriaDeReparaciones { get; set; }

        public auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0} - Color: {1}", HP, Color);
        } 

        public virtual void Reparar()
        {
            Console.WriteLine("el auto ya esta reparado");
        }

        public void ImprimirHistoriaDeReparaciones()
        {
            Console.WriteLine("Historia de Reparaciones:");
            foreach (string reparacion in HistoriaDeReparaciones)
            {
                Console.WriteLine(reparacion);
            }
        }
    }
}
