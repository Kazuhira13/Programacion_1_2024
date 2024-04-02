using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7desafio1
{
    internal class Calculadora
    {
        public string Marca {  get; set; }
        public string Serie { get; set;}

        public double sumar (double a , double b)
        {
            return a + b;
        }

        public double restar (double a, double b)
        {
            return a - b;
        }
        public double multiplicar (double a, double b)
        {
            return a * b;
        }

        public double dividir (double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }
}
