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
    }
}
