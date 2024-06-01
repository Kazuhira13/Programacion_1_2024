using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using capa_datos;
using capa_entidades;

namespace capa_negocio
{
    public class Classnegocio
    {
        Classdatos objd = new Classdatos();
        public DataTable N_listar_clientes()
        {
            return objd.D_listar_clientes();
        }

        public DataTable N_buscar_clientes(Classentidades obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public String N_mantenimiento_clientes(Classentidades obje)
        {
            return objd.D_mantenimiento_clientes(obje);
        }
    }
}
