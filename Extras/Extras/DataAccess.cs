using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Extras
{
    internal class DataAccess
    {
        public const string CADENA_SQL_SERVER = "Server= CONNOR\\SQLEXPRESS;Integrated Security=true;Initial Catalog= Ventas";
        public List<Ventas> GetAllDapper()
        {
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT Id, nombres, productos FROM Ventas";
                ventas = conn.Query<Ventas>(query).ToList();
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ventas;

        }
        public int Create(Ventas ventas)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection (CADENA_SQL_SERVER);
                conn.Open();
                string query = @"INSERT INTO Ventas (Id,nombres,productos) 
                                               VALUES(@Id,@nombres,@productos) 
";
                //para guardar datos execute para llamar datos query 
                result = conn.Execute(query, new
                {
                    Id = ventas.Id,
                    nombres = ventas.Nombres,
                    productos = ventas.Productos,
                });
                conn.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }


        public Ventas GetById(int idventa)
        {
            Ventas ventas = new Ventas();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT Id, nombres, productos FROM Ventas WHERE Id=@Id";
                ventas = conn.QuerySingle<Ventas>(query, new { Id=idventa });
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ventas;

        }


        public int Update(Ventas ventas)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"UPDATE Ventas SET nombres=@nombres,productos=@productos WHERE  Id=@Id";
                //para guardar datos execute para llamar datos query 
                result = conn.Execute(query, new
                {
                    Id = ventas.Id,
                    nombres = ventas.Nombres,
                    productos = ventas.Productos,
                });
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public int Delete(int id)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"DELETE FROM Ventas WHERE  Id=@Id";
                //Para guardar, actualizar o eliminar se usa execute.
                result = conn.Execute(query, new
                {
                    Id = id
                    
                });
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

    }
    

}
