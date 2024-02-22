using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_clases_Tarea
{
    public class Alumno: Persona
    {
        private string v;
        private DateTime dateTime;

        public string Carnet { get; set; }
        public string FechaIngreso { get; set; }

        public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string carnet, string fechaIngreso) : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            Carnet = carnet;
            fechaIngreso = fechaIngreso;

        }

        public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string v, DateTime dateTime) : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            this.v = v;
            this.dateTime = dateTime;
        }
    }
}
