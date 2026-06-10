using Printzone.DAL;
using Printzone.Entidades;
using System;
using System.Collections.Generic;

namespace Printzone.BLL
{
    public class ProductoBLL
    {
        private readonly ProductoDAL _productoDAL = new ProductoDAL();

        public bool GuardarProducto(Producto producto)
        {
            // Validaciones

            if (string.IsNullOrWhiteSpace(producto.nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(producto.descripcion))
            {
                throw new ArgumentException("La descripción es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(producto.marca))
            {
                throw new ArgumentException("La marca es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(producto.codigo_barras))
            {
                throw new ArgumentException("El código de barras es obligatorio.");
            }

            if (producto.precio_compra <= 0)
            {
                throw new ArgumentException("El precio de compra debe ser mayor que cero.");
            }

            if (producto.precio_venta <= 0)
            {
                throw new ArgumentException("El precio de venta debe ser mayor que cero.");
            }

            if (producto.precio_venta < producto.precio_compra)
            {
                throw new ArgumentException(
                    "El precio de venta no puede ser menor que el precio de compra.");
            }

            if (producto.stock_minimo < 0)
            {
                throw new ArgumentException("El stock mínimo no puede ser negativo.");
            }

            if (producto.id_categoria <= 0)
            {
                throw new ArgumentException("Debe seleccionar una categoría.");
            }

            return _productoDAL.InsertarProducto(producto);
        }

        public List<Producto> ObtenerProductos()
        {
            return _productoDAL.ObtenerProductos();
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            if (idProducto <= 0)
            {
                throw new ArgumentException("Producto inválido.");
            }

            return _productoDAL.ObtenerProductoPorId(idProducto);
        }

        public bool ActualizarStock(int idProducto, int cantidadEntrada)
        {
            if (idProducto <= 0)
            {
                throw new ArgumentException("Producto inválido.");
            }

            if (cantidadEntrada <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            }

            return _productoDAL.ActualizarStock(idProducto, cantidadEntrada);
        }

        public bool DisminuirStock(int idProducto, int cantidadSalida)
        {
            if (idProducto <= 0)
            {
                throw new ArgumentException("Producto inválido.");
            }

            if (cantidadSalida <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            }

            return _productoDAL.DisminuirStock(idProducto, cantidadSalida);
        }




        public bool ActualizarProducto(Producto producto)
        {
            if (producto.id_producto <= 0)
            {
                throw new ArgumentException("Producto inválido.");
            }

            if (string.IsNullOrWhiteSpace(producto.nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(producto.descripcion))
            {
                throw new ArgumentException("La descripción es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(producto.marca))
            {
                throw new ArgumentException("La marca es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(producto.codigo_barras))
            {
                throw new ArgumentException("El código de barras es obligatorio.");
            }

            if (producto.precio_compra <= 0)
            {
                throw new ArgumentException("El precio de compra debe ser mayor que cero.");
            }

            if (producto.precio_venta <= 0)
            {
                throw new ArgumentException("El precio de venta debe ser mayor que cero.");
            }

            if (producto.precio_venta < producto.precio_compra)
            {
                throw new ArgumentException("El precio de venta no puede ser menor que el precio de compra.");
            }

            if (producto.stock_minimo < 0)
            {
                throw new ArgumentException("El stock mínimo no puede ser negativo.");
            }

            if (producto.id_categoria <= 0)
            {
                throw new ArgumentException("Debe seleccionar una categoría.");
            }

            return _productoDAL.ActualizarProducto(producto);
        }



        public bool EliminarProducto(int idProducto)
        {
            if (idProducto <= 0)
            {
                throw new ArgumentException("Producto inválido.");
            }

            return _productoDAL.EliminarProducto(idProducto);
        }
    }
}