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
    }
}
