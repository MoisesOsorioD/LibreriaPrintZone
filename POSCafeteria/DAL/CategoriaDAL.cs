using Microsoft.Data.SqlClient;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.DAL
{
    public class CategoriaDAL
    {
        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = "SELECT * FROM Categorias";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria();

                    categoria.id_categoria = (int)reader["id_categoria"];
                    categoria.nombre_categoria = reader["nombre_categoria"].ToString();

                    lista.Add(categoria);
                }
            }

            return lista;
        }



        public bool InsertarCategoria(Categoria categoria)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"INSERT INTO Categorias
                            (nombre_categoria)
                            VALUES
                            (@nombre_categoria)";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue(
                    "@nombre_categoria",
                    categoria.nombre_categoria);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }




        public bool ActualizarCategoria(Categoria categoria)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"UPDATE Categorias
                            SET nombre_categoria = @nombre_categoria
                            WHERE id_categoria = @id_categoria";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue(
                    "@id_categoria",
                    categoria.id_categoria);

                comando.Parameters.AddWithValue(
                    "@nombre_categoria",
                    categoria.nombre_categoria);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }




        public bool EliminarCategoria(int idCategoria)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"DELETE FROM Categorias
                            WHERE id_categoria = @id_categoria";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue(
                    "@id_categoria",
                    idCategoria);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }
    }
}
