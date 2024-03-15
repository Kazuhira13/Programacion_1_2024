using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    internal class Caja
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Altura { get; set; }

        public double CalcularVolumen()
        {
            return Largo * Ancho * Altura;
        }
    }
}
