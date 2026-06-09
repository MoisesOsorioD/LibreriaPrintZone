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
    }
}
