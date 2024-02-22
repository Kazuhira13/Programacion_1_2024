using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_clases_Tarea
{
    public class Profesor: Persona
    {
        public decimal Salario { get; set; }

        public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, decimal salario)
            : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            Salario = salario;
        }
    }
}
