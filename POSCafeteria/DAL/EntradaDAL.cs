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




        public List<Entrada> ObtenerEntradas()
        {
            List<Entrada> lista = new List<Entrada>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"
        SELECT
            e.id_entrada,
            e.fecha_entrada,
            e.cantidad,
            e.costo_lote,
            p.nombre AS producto,
            pr.nombre_empresa AS proveedor
        FROM Entradas e
        INNER JOIN Productos p
            ON e.id_producto = p.id_producto
        INNER JOIN Proveedores pr
            ON e.id_proveedor = pr.id_proveedor
        ORDER BY e.fecha_entrada DESC";

                SqlCommand comando =
                    new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader =
                    comando.ExecuteReader();

                while (reader.Read())
                {
                    Entrada entrada = new Entrada();

                    entrada.id_entrada =
                        Convert.ToInt32(reader["id_entrada"]);

                    entrada.fecha_entrada =
                        Convert.ToDateTime(reader["fecha_entrada"]);

                    entrada.cantidad =
                        Convert.ToInt32(reader["cantidad"]);

                    entrada.costo_lote =
                        Convert.ToDecimal(reader["costo_lote"]);

                    entrada.nombre_producto =
                        reader["producto"].ToString();

                    entrada.nombre_proveedor =
                        reader["proveedor"].ToString();

                    lista.Add(entrada);
                }
            }

            return lista;
        }
    }
}
