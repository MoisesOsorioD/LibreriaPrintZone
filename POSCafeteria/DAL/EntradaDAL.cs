using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Printzone.Entidades;

namespace Printzone.DAL
{
    public class EntradaDAL
    {
        public bool RegistrarEntrada(Entrada entrada)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"INSERT INTO Entradas
                                   (
                                       cantidad,
                                       costo_lote,
                                       id_proveedor,
                                       id_producto
                                   )
                                   VALUES
                                   (
                                       @cantidad,
                                       @costo_lote,
                                       @id_proveedor,
                                       @id_producto
                                   )";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@cantidad", entrada.cantidad);
                comando.Parameters.AddWithValue("@costo_lote", entrada.costo_lote);
                comando.Parameters.AddWithValue("@id_proveedor", entrada.id_proveedor);
                comando.Parameters.AddWithValue("@id_producto", entrada.id_producto);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }



        public List<Entrada> ObtenerUltimasEntradas()
        {
            List<Entrada> lista = new List<Entrada>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"
            SELECT TOP 4
                   e.cantidad,
                   e.fecha_entrada,
                   p.nombre
            FROM Entradas e
            INNER JOIN Productos p
                ON e.id_producto = p.id_producto
            ORDER BY e.fecha_entrada DESC";

                SqlCommand comando =
                    new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader =
                    comando.ExecuteReader();

                while (reader.Read())
                {
                    Entrada entrada =
                        new Entrada();

                    entrada.cantidad =
                        (int)reader["cantidad"];

                    entrada.fecha_entrada =
                        Convert.ToDateTime(
                            reader["fecha_entrada"]);

                    entrada.nombre_producto =
                        reader["nombre"].ToString();

                    lista.Add(entrada);
                }
            }

            return lista;
        }
    }
}
