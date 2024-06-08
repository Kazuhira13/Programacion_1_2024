using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FinalSerie2
{
    internal class DataAccess
    {
        public const string CADENA_SQL_SERVER = "Server= CONNOR\\SQLEXPRESS;Integrated Security=true;Initial Catalog= Datos";

        public List<Ventas> GetAllDapper()
        {
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombre, precio, existencias FROM Datos";
                ventas = conn.Query<Ventas>(query).ToList();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ventas;
        }

        public int Crear(Ventas ventas)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"INSERT INTO Datos (id, nombre, precio, existencias)
                                    VALUES(@id, @nombre, @precio, @existencias)";

                result = conn.Execute(query, new
                {
                    id = ventas.Id,
                    nombre = ventas.Nombre,
                    precio = ventas.Precio,
                    existencias = ventas.Existencias
                });
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public Ventas GetById(int idv)
        {
            Ventas ventas = new Ventas();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombre, precio, existencias FROM Datos WHERE id=@id";
                ventas = conn.QuerySingle<Ventas>(query, new { id = idv });
                conn.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ventas;
        } 

        public int update(Ventas ventas)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"UPDATE Datos SET nombre=@nombre, precio=@precio, existencias=@existencias WHERE id=@id";
                result = conn.Execute(query, new
                {
                    id = ventas.Id,
                    nombre = ventas.Nombre,
                    precio = ventas.Precio,
                    existencias = ventas.Existencias

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
            int resutl = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "DELETE FROM Datos WHERE id=@id";
                resutl = conn.Execute(query, new
                {
                    id = id,
                });
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return resutl;
        }
    }
}
