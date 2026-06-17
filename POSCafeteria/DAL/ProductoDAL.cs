using Microsoft.Data.SqlClient;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.DAL
{
    public class ProductoDAL
    {

        public bool InsertarProducto(Producto producto)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"INSERT INTO Productos
                           (
                               nombre,
                               descripcion,
                               marca,
                               precio_compra,
                               precio_venta,
                               codigo_barras,
                               stock_actual,
                               stock_minimo,
                               id_categoria
                           )
                           VALUES
                           (
                               @nombre,
                               @descripcion,
                               @marca,
                               @precio_compra,
                               @precio_venta,
                               @codigo_barras,
                               @stock_actual,
                               @stock_minimo,
                               @id_categoria
                           )";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@nombre", producto.nombre);
                comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                comando.Parameters.AddWithValue("@marca", producto.marca);
                comando.Parameters.AddWithValue("@precio_compra", producto.precio_compra);
                comando.Parameters.AddWithValue("@precio_venta", producto.precio_venta);
                comando.Parameters.AddWithValue("@codigo_barras", producto.codigo_barras);
                comando.Parameters.AddWithValue("@stock_actual", producto.stock_actual);
                comando.Parameters.AddWithValue("@stock_minimo", producto.stock_minimo);
                comando.Parameters.AddWithValue("@id_categoria", producto.id_categoria);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        p.id_producto,
                        p.nombre,
                        p.descripcion,
                        p.marca,
                        p.precio_compra,
                        p.precio_venta,
                        p.codigo_barras,
                        p.stock_actual,
                        p.stock_minimo,
                        p.id_categoria,
                        p.activo,
                        c.nombre_categoria
                    FROM Productos p
                    INNER JOIN Categorias c
                        ON p.id_categoria = c.id_categoria
                    WHERE p.activo = 1";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();

                    producto.id_producto = (int)reader["id_producto"];
                    producto.nombre = reader["nombre"].ToString();
                    producto.descripcion = reader["descripcion"].ToString();
                    producto.marca = reader["marca"].ToString();
                    producto.precio_compra = Convert.ToDecimal(reader["precio_compra"]);
                    producto.precio_venta = Convert.ToDecimal(reader["precio_venta"]);
                    producto.codigo_barras = reader["codigo_barras"].ToString();
                    producto.stock_actual = (int)reader["stock_actual"];
                    producto.stock_minimo = (int)reader["stock_minimo"];
                    producto.id_categoria = (int)reader["id_categoria"];
                    producto.activo = (bool)reader["activo"];
                    producto.nombre_categoria = reader["nombre_categoria"].ToString();

                    lista.Add(producto);
                }
            }

            return lista;
        }


        public bool ActualizarStock(int idProducto, int cantidadEntrada)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"UPDATE Productos
                            SET stock_actual = stock_actual + @cantidad
                            WHERE id_producto = @idProducto";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@cantidad", cantidadEntrada);
                comando.Parameters.AddWithValue("@idProducto", idProducto);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }




        public bool DisminuirStock(int idProducto, int cantidadSalida)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"UPDATE Productos
                            SET stock_actual = stock_actual - @cantidad
                            WHERE id_producto = @idProducto";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@cantidad", cantidadSalida);
                comando.Parameters.AddWithValue("@idProducto", idProducto);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }



        public Producto ObtenerProductoPorId(int idProducto)
        {
            Producto producto = null;

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"SELECT *
                    FROM Productos
                    WHERE id_producto = @idProducto
                    AND activo = 1";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@idProducto", idProducto);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    producto = new Producto();

                    producto.id_producto = (int)reader["id_producto"];
                    producto.nombre = reader["nombre"].ToString();
                    producto.descripcion = reader["descripcion"].ToString();
                    producto.marca = reader["marca"].ToString();
                    producto.precio_compra = Convert.ToDecimal(reader["precio_compra"]);
                    producto.precio_venta = Convert.ToDecimal(reader["precio_venta"]);
                    producto.codigo_barras = reader["codigo_barras"].ToString();
                    producto.stock_actual = (int)reader["stock_actual"];
                    producto.stock_minimo = (int)reader["stock_minimo"];
                    producto.id_categoria = (int)reader["id_categoria"];
                    producto.activo = (bool)reader["activo"];
                }
            }

            return producto;
        }



        public bool ActualizarProducto(Producto producto)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"UPDATE Productos
                            SET nombre = @nombre,
                                descripcion = @descripcion,
                                marca = @marca,
                                precio_compra = @precio_compra,
                                precio_venta = @precio_venta,
                                codigo_barras = @codigo_barras,
                                stock_minimo = @stock_minimo,
                                id_categoria = @id_categoria
                            WHERE id_producto = @id_producto";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@id_producto", producto.id_producto);
                comando.Parameters.AddWithValue("@nombre", producto.nombre);
                comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                comando.Parameters.AddWithValue("@marca", producto.marca);
                comando.Parameters.AddWithValue("@precio_compra", producto.precio_compra);
                comando.Parameters.AddWithValue("@precio_venta", producto.precio_venta);
                comando.Parameters.AddWithValue("@codigo_barras", producto.codigo_barras);
                comando.Parameters.AddWithValue("@stock_minimo", producto.stock_minimo);
                comando.Parameters.AddWithValue("@id_categoria", producto.id_categoria);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }



        public bool EliminarProducto(int idProducto)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"UPDATE Productos
                            SET activo = 0
                            WHERE id_producto = @idProducto";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@idProducto", idProducto);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }



        public int ObtenerCantidadProductos()
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"
            SELECT COUNT(*)
            FROM Productos
            WHERE activo = 1";

                SqlCommand comando =
                    new SqlCommand(consulta, conexion);

                conexion.Open();

                return (int)comando.ExecuteScalar();
            }
        }



        public List<Producto> ObtenerProductosStockMinimo()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = @"
            SELECT *
            FROM Productos
            WHERE activo = 1
            AND stock_actual <= stock_minimo";

                SqlCommand comando =
                    new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader reader =
                    comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto =
                        new Producto();

                    producto.nombre =
                        reader["nombre"].ToString();

                    producto.stock_actual =
                        (int)reader["stock_actual"];

                    producto.stock_minimo =
                        (int)reader["stock_minimo"];

                    lista.Add(producto);
                }
            }

            return lista;
        }
    }
}
