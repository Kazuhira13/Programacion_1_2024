using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    internal class GestorCajas
    {
        private List<Caja> cajas = new List<Caja>();

        public void AgregarCaja(double largo, double ancho, double altura)
        {
            Caja nuevaCaja = new Caja
            {
                Largo = largo,
                Ancho = ancho,
                Altura = altura
            };
            cajas.Add(nuevaCaja);
        }

        public double CalcularVolumenTotal()
        {
            double volumenTotal = 0;
            foreach (Caja caja in cajas)
            {
                volumenTotal += caja.CalcularVolumen();
            }
            return volumenTotal;
        }

        public double CalcularVolumenPromedio()
        {
            if (cajas.Count == 0)
                return 0;

            double volumenTotal = CalcularVolumenTotal();
            return volumenTotal / cajas.Count;
        }
    }
}
