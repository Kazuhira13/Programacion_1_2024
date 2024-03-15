using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    internal class SuperficieFrontal
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

        public double rec
        {
            get { return Alto * Largo; }
        }
    }
}
