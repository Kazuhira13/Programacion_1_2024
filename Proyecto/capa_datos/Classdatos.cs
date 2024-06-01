using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using capa_entidades;

namespace capa_datos
{
    public class Classdatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_clientes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_clientes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_clientes(Classentidades obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_clientes(Classentidades obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantinimento_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo",obje.codigo);
            cmd.Parameters.AddWithValue("@nombre",obje.nombre);
            cmd.Parameters.AddWithValue("@cantidad",obje.cantidad);
            cmd.Parameters.Add("@accion",SqlDbType.VarChar,50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
