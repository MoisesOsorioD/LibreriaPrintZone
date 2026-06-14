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

                SqlCommand comando = new SqlCommand(
                    consulta,
                    conexion);

                conexion.Open();

                SqlDataReader reader =
                    comando.ExecuteReader();

                while (reader.Read())
                {
                    Proveedor proveedor =
                        new Proveedor();

                    proveedor.id_proveedor =
                        (int)reader["id_proveedor"];

                    proveedor.nombre_empresa =
                        reader["nombre_empresa"].ToString();

                    proveedor.direccion =
                        reader["direccion"].ToString();

                    proveedor.correo =
                        reader["correo"].ToString();

                    proveedor.telefono =
                        reader["telefono"].ToString();

                    proveedor.nombre_agente =
                        reader["nombre_agente"].ToString();

                    proveedor.telefono_agente =
                        reader["telefono_agente"].ToString();

                    proveedor.monto_minimo_compra =
                        Convert.ToDecimal(
                            reader["monto_minimo_compra"]);

                    lista.Add(proveedor);
                }
            }

            return lista;
        }



        public bool InsertarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"INSERT INTO Proveedores
                           (
                               nombre_empresa,
                               direccion,
                               correo,
                               telefono,
                               nombre_agente,
                               telefono_agente,
                               monto_minimo_compra
                           )
                           VALUES
                           (
                               @nombre_empresa,
                               @direccion,
                               @correo,
                               @telefono,
                               @nombre_agente,
                               @telefono_agente,
                               @monto_minimo_compra
                           )";

                SqlCommand comando = new SqlCommand(
                    consulta,
                    conexion);

                comando.Parameters.AddWithValue(
                    "@nombre_empresa",
                    proveedor.nombre_empresa);

                comando.Parameters.AddWithValue(
                    "@direccion",
                    proveedor.direccion);

                comando.Parameters.AddWithValue(
                    "@correo",
                    proveedor.correo);

                comando.Parameters.AddWithValue(
                    "@telefono",
                    proveedor.telefono);

                comando.Parameters.AddWithValue(
                    "@nombre_agente",
                    proveedor.nombre_agente);

                comando.Parameters.AddWithValue(
                    "@telefono_agente",
                    proveedor.telefono_agente);

                comando.Parameters.AddWithValue(
                    "@monto_minimo_compra",
                    proveedor.monto_minimo_compra);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }




        public bool ActualizarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"UPDATE Proveedores
                            SET nombre_empresa = @nombre_empresa,
                                direccion = @direccion,
                                correo = @correo,
                                telefono = @telefono,
                                nombre_agente = @nombre_agente,
                                telefono_agente = @telefono_agente,
                                monto_minimo_compra = @monto_minimo_compra
                            WHERE id_proveedor = @id_proveedor";

                SqlCommand comando = new SqlCommand(
                    consulta,
                    conexion);

                comando.Parameters.AddWithValue(
                    "@id_proveedor",
                    proveedor.id_proveedor);

                comando.Parameters.AddWithValue(
                    "@nombre_empresa",
                    proveedor.nombre_empresa);

                comando.Parameters.AddWithValue(
                    "@direccion",
                    proveedor.direccion);

                comando.Parameters.AddWithValue(
                    "@correo",
                    proveedor.correo);

                comando.Parameters.AddWithValue(
                    "@telefono",
                    proveedor.telefono);

                comando.Parameters.AddWithValue(
                    "@nombre_agente",
                    proveedor.nombre_agente);

                comando.Parameters.AddWithValue(
                    "@telefono_agente",
                    proveedor.telefono_agente);

                comando.Parameters.AddWithValue(
                    "@monto_minimo_compra",
                    proveedor.monto_minimo_compra);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }




        public bool EliminarProveedor(int idProveedor)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"DELETE FROM Proveedores
                            WHERE id_proveedor = @id_proveedor";

                SqlCommand comando = new SqlCommand(
                    consulta,
                    conexion);

                comando.Parameters.AddWithValue(
                    "@id_proveedor",
                    idProveedor);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }





        public bool TieneEntradasAsociadas(int idProveedor)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"SELECT COUNT(*)
                            FROM Entradas
                            WHERE id_proveedor = @id_proveedor";

                SqlCommand comando =
                    new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue(
                    "@id_proveedor",
                    idProveedor);

                conexion.Open();

                int cantidad =
                    (int)comando.ExecuteScalar();

                return cantidad > 0;
            }
        }
    }
}