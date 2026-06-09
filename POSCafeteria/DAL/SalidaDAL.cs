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
    }
}
