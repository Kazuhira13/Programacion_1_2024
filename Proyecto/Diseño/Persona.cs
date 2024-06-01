using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    public class Persona
    {
        
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set;}


        public Persona() { }

        public Persona(int id,string nombre,string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
        }


    }
}
