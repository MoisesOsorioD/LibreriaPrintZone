using Printzone.DAL;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.BLL
{
    public class ProveedorBLL
    {
        private readonly ProveedorDAL _proveedorDAL = new ProveedorDAL();

        public List<Proveedor> ObtenerProveedores()
        {
            return _proveedorDAL.ObtenerProveedores();
        }
    }
}
