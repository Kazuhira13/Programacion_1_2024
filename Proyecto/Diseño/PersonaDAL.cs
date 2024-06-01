using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    public class PersonaDAL
    {

        public static int AgregarPersona(Persona persona)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "insert into persona (nombre,telefono) values ('"+persona.nombre+"','"+persona.telefono+"')";
                SqlCommand comando = new SqlCommand(query,conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Persona> PresentarRegistro()
        {
            List<Persona> lista = new List<Persona>();
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select *from persona";
                SqlCommand comando = new SqlCommand(query,conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.id = reader.GetInt32(0);
                    persona.nombre = reader.GetString(1);
                    persona.telefono = reader.GetString(2);
                    lista.Add(persona);
                }
                
                conexion.Close();
                return lista;
            }
        }

        public static int ModificarPersona(Persona persona)
        {
            int result = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "update persona set nombre='"+persona.nombre+"',telefono='"+persona.telefono+"' where id="+persona.id+"  ";
                SqlCommand comando = new SqlCommand(query,conexion);
                result = comando.ExecuteNonQuery();

            }
            return result;
        }


        public static int EliminarPersona(int id)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "delete from persona where id="+id+" ";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

    }
}
