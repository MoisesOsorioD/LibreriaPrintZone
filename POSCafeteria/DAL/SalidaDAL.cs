using Microsoft.Data.SqlClient;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.DAL
{
    public class SalidaDAL
    {
        public bool RegistrarSalida(Salida salida)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"INSERT INTO Salidas
                   (cantidad, motivo, id_usuario, id_producto)
                   VALUES
                   (@cantidad, @motivo, @id_usuario, @id_producto)";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@cantidad", salida.cantidad);
                comando.Parameters.AddWithValue("@motivo", salida.motivo);
                comando.Parameters.AddWithValue("@id_usuario", salida.id_usuario);
                comando.Parameters.AddWithValue("@id_producto", salida.id_producto);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }



        public List<Salida> ObtenerUltimasSalidas()
        {
            List<Salida> lista = new List<Salida>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"
            SELECT TOP 4
                   s.cantidad,
                   s.fecha_salida,
                   p.nombre
            FROM Salidas s
            INNER JOIN Productos p
                ON s.id_producto = p.id_producto
            ORDER BY s.fecha_salida DESC";

                SqlCommand comando =
                    new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader =
                    comando.ExecuteReader();

                while (reader.Read())
                {
                    Salida salida =
                        new Salida();

                    salida.cantidad =
                        (int)reader["cantidad"];

                    salida.fecha_salida =
                        Convert.ToDateTime(
                            reader["fecha_salida"]);

                    salida.nombre_producto =
                        reader["nombre"].ToString();

                    lista.Add(salida);
                }
            }

            return lista;
        }





        public List<Salida> ObtenerSalidas()
        {
            List<Salida> lista = new List<Salida>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"
        SELECT
            s.id_salida,
            s.fecha_salida,
            s.cantidad,
            s.motivo,
            s.id_usuario,
            s.id_producto,
            p.nombre AS producto,
            u.nombre_usuario
        FROM Salidas s
        INNER JOIN Productos p
            ON s.id_producto = p.id_producto
        INNER JOIN Usuarios u
            ON s.id_usuario = u.id_usuario
        ORDER BY s.fecha_salida DESC";

                SqlCommand comando =
                    new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader =
                    comando.ExecuteReader();

                while (reader.Read())
                {
                    Salida salida = new Salida();

                    salida.id_salida =
                        Convert.ToInt32(reader["id_salida"]);

                    salida.fecha_salida =
                        Convert.ToDateTime(reader["fecha_salida"]);

                    salida.cantidad =
                        Convert.ToInt32(reader["cantidad"]);

                    salida.motivo =
                        reader["motivo"].ToString();

                    salida.id_usuario =
                        Convert.ToInt32(reader["id_usuario"]);

                    salida.id_producto =
                        Convert.ToInt32(reader["id_producto"]);

                    salida.nombre_producto =
                        reader["producto"].ToString();

                    salida.nombre_usuario =
                        reader["nombre_usuario"].ToString();

                    lista.Add(salida);
                }
            }

            return lista;
        }
    }
}
