using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7desafio1
{
    internal class Calculadora_cientifica: Calculadora
    {
        public double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Raiz(double a)
        {
            return Math.Sqrt(a);
        }

        public double Modulo(double a, double b)
        {
            return a % b;
        }

        public double Logaritmo(double a, double b)
        {
            return Math.Log(a, b);
        }
    }
}
