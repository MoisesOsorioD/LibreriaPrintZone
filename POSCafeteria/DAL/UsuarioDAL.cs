using Microsoft.Data.SqlClient;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.DAL
{
    public class UsuarioDAL
    {
        public Usuario? ValidarLogin(string nombreUsuario, string clave)
        {
            Usuario? usuarioAutenticado = null;

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT id_usuario, nombre_usuario, nombre_completo, clave, rol, activo, fecha_creacion 
                                 FROM Usuarios 
                                 WHERE nombre_usuario = @NombreUsuario 
                                 AND clave = @Clave 
                                 AND activo = 1";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                try
                {
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioAutenticado = new Usuario
                            {
                                id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                nombre_usuario = reader["nombre_usuario"].ToString()!,
                                nombre_completo = reader["nombre_completo"].ToString()!,
                                clave = reader["clave"].ToString()!,
                                rol = reader["rol"].ToString()!,
                                activo = Convert.ToBoolean(reader["activo"]),
                                FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return usuarioAutenticado;
        }

        // Método para Leer (SELECT)
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT id_usuario, nombre_usuario, nombre_completo, clave, rol, activo, fecha_creacion 
                                 FROM Usuarios";

                SqlCommand cmd = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                nombre_usuario = reader["nombre_usuario"].ToString()!,
                                nombre_completo = reader["nombre_completo"].ToString()!,
                                clave = reader["clave"].ToString()!,
                                rol = reader["rol"].ToString()!,
                                activo = Convert.ToBoolean(reader["activo"]),
                                FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los usuarios: " + ex.Message);
                }
            }

            return lista;
        }

        // Método para Crear (INSERT)
        public bool Insertar(Usuario obj)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"INSERT INTO Usuarios 
                                (nombre_usuario, nombre_completo, clave, rol, activo, fecha_creacion) 
                                VALUES 
                                (@NombreUsuario, @NombreCompleto, @Clave, @Rol, @Activo, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@NombreUsuario", obj.nombre_usuario);
                cmd.Parameters.AddWithValue("@NombreCompleto", obj.nombre_completo);
                cmd.Parameters.AddWithValue("@Clave", obj.clave);
                cmd.Parameters.AddWithValue("@Rol", obj.rol);
                cmd.Parameters.AddWithValue("@Activo", obj.activo);

                try
                {
                    conexion.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el usuario: " + ex.Message);
                }
            }
        }

        // Método para Actualizar (UPDATE)
        public bool Actualizar(Usuario obj)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"UPDATE Usuarios 
                                 SET nombre_usuario = @nombre_usuario,
                                     nombre_completo = @nombre_completo,
                                     clave = @clave,
                                     rol = @rol,
                                     activo = @activo
                                 WHERE id_usuario = @id_usuario";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario);
                cmd.Parameters.AddWithValue("@nombre_usuario", obj.nombre_usuario);
                cmd.Parameters.AddWithValue("@nombre_completo", obj.nombre_completo);
                cmd.Parameters.AddWithValue("@clave", obj.clave);
                cmd.Parameters.AddWithValue("@rol", obj.rol);
                cmd.Parameters.AddWithValue("@activo", obj.activo);

                try
                {
                    conexion.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el usuario: " + ex.Message);
                }
            }
        }

        // Método para Eliminar (Borrado lógico - UPDATE Activo = 0)
        public bool Eliminar(int idUsuario)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"UPDATE Usuarios 
                                 SET activo = 0 
                                 WHERE id_usuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                try
                {
                    conexion.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }
    }
}