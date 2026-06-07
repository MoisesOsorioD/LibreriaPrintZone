using Microsoft.Data.SqlClient;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.DAL
{
    public class ProveedorDAL
    {
        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = "SELECT * FROM Proveedores";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Proveedor proveedor = new Proveedor();

                    proveedor.id_proveedor = (int)reader["id_proveedor"];
                    proveedor.nombre_empresa = reader["nombre_empresa"].ToString();

                    lista.Add(proveedor);
                }
            }

            return lista;
        }
    }
}
