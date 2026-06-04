using Printzone.DAL;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDAL = new UsuarioDAL();

        public Usuario? IniciarSesion(string nombre_usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(nombre_usuario) || string.IsNullOrWhiteSpace(clave))
            {
                throw new ArgumentException("El usuario y la constraseña son obligatorios.");
            }
            return _usuarioDAL.ValidarLogin(nombre_usuario, clave);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _usuarioDAL.ObtenerTodos();
        }

        public bool GuardarUsuario(Usuario obj)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(obj.nombre_usuario) || string.IsNullOrWhiteSpace(obj.clave) || string.IsNullOrWhiteSpace(obj.rol) || string.IsNullOrWhiteSpace(obj.nombre_completo))
            {
                throw new ArgumentException("El Nombre de Usuario, el Nombre Completo, la Contraseña y el Rol son obligatorios.");
            }

            if (obj.id_usuario == 0)
            {
                // Si el ID es 0, significa que es un usuario nuevo
                return _usuarioDAL.Insertar(obj);
            }
            else
            {
                // Si ya tiene ID, es una actualización
                return _usuarioDAL.Actualizar(obj);
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            if (idUsuario <= 0)
            {
                throw new ArgumentException("Debe seleccionar un usuario válido para eliminar.");
            }
            return _usuarioDAL.Eliminar(idUsuario);
        }
    }
}
