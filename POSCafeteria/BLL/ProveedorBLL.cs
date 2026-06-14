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



        public bool InsertarProveedor(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.nombre_empresa))
            {
                throw new ArgumentException(
                    "Debe ingresar el nombre de la empresa.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.direccion))
            {
                throw new ArgumentException(
                    "Debe ingresar la dirección.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.correo))
            {
                throw new ArgumentException(
                    "Debe ingresar el correo.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.telefono))
            {
                throw new ArgumentException(
                    "Debe ingresar el teléfono.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.nombre_agente))
            {
                throw new ArgumentException(
                    "Debe ingresar el nombre del agente.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.telefono_agente))
            {
                throw new ArgumentException(
                    "Debe ingresar el teléfono del agente.");
            }

            if (proveedor.monto_minimo_compra <= 0)
            {
                throw new ArgumentException(
                    "El monto mínimo de compra debe ser mayor que cero.");
            }

            return _proveedorDAL.InsertarProveedor(proveedor);
        }



        public bool ActualizarProveedor(Proveedor proveedor)
        {
            if (proveedor.id_proveedor <= 0)
            {
                throw new ArgumentException(
                    "Debe seleccionar un proveedor.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.nombre_empresa))
            {
                throw new ArgumentException(
                    "Debe ingresar el nombre de la empresa.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.direccion))
            {
                throw new ArgumentException(
                    "Debe ingresar la dirección.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.correo))
            {
                throw new ArgumentException(
                    "Debe ingresar el correo.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.telefono))
            {
                throw new ArgumentException(
                    "Debe ingresar el teléfono.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.nombre_agente))
            {
                throw new ArgumentException(
                    "Debe ingresar el nombre del agente.");
            }

            if (string.IsNullOrWhiteSpace(proveedor.telefono_agente))
            {
                throw new ArgumentException(
                    "Debe ingresar el teléfono del agente.");
            }

            if (proveedor.monto_minimo_compra <= 0)
            {
                throw new ArgumentException(
                    "El monto mínimo de compra debe ser mayor que cero.");
            }

            return _proveedorDAL.ActualizarProveedor(
                proveedor);
        }



        public bool EliminarProveedor(int idProveedor)
        {
            if (idProveedor <= 0)
            {
                throw new ArgumentException(
                    "Debe seleccionar un proveedor.");
            }

            if (_proveedorDAL.TieneEntradasAsociadas(idProveedor))
            {
                throw new ArgumentException(
                    "No se puede eliminar el proveedor porque tiene entradas registradas.");
            }

            return _proveedorDAL.EliminarProveedor(idProveedor);
        }
    }
}
