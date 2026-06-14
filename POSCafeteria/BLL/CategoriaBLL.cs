using Microsoft.Data.SqlClient;
using Printzone.DAL;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.BLL
{
    public class CategoriaBLL
    {
        private readonly CategoriaDAL _categoriaDAL = new CategoriaDAL();

        public List<Categoria> ObtenerCategorias()
        {
            return _categoriaDAL.ObtenerCategorias();
        }

        public bool InsertarCategoria(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.nombre_categoria))
            {
                throw new ArgumentException(
                    "Debe ingresar el nombre de la categoría.");
            }

            return _categoriaDAL.InsertarCategoria(categoria);
        }

        public bool ActualizarCategoria(Categoria categoria)
        {
            if (categoria.id_categoria <= 0)
            {
                throw new ArgumentException(
                    "Debe seleccionar una categoría válida.");
            }

            if (string.IsNullOrWhiteSpace(categoria.nombre_categoria))
            {
                throw new ArgumentException(
                    "Debe ingresar el nombre de la categoría.");
            }

            return _categoriaDAL.ActualizarCategoria(categoria);
        }

        public bool EliminarCategoria(int idCategoria)
        {
            if (idCategoria <= 0)
            {
                throw new ArgumentException(
                    "Debe seleccionar una categoría válida.");
            }

            if (_categoriaDAL.TieneProductosAsociados(idCategoria))
            {
                throw new ArgumentException(
                    "No se puede eliminar la categoría porque tiene productos asociados.");
            }

            return _categoriaDAL.EliminarCategoria(idCategoria);
        }




    }
}