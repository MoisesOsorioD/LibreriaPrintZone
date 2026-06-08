using Printzone.DAL;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Printzone
{
    public partial class FormSalidas : Form
    {
        private Usuario _usuarioSesion;
        public FormSalidas(Usuario usuario)
        {
            InitializeComponent();
            _usuarioSesion = usuario;
        }

        private void CargarProductos()
        {
            ProductoDAL productoDAL = new ProductoDAL();

            cmbProducto.DataSource = productoDAL.ObtenerProductos();

            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "id_producto";
        }

        private void FormSalidas_Load(object sender, EventArgs e)
        {
            CargarProductos();
            lblUsuario.Text = _usuarioSesion.nombre_completo;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is Producto producto)
            {
                lblStockActual.Text = producto.stock_actual.ToString();
            }
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            // Validar cantidad
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese una cantidad.");
                return;
            }

            // Validar motivo
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Ingrese un motivo.");
                return;
            }

            // Obtener datos
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            Producto productoSeleccionado = (Producto)cmbProducto.SelectedItem;

            int stockActual = productoSeleccionado.stock_actual;

            // Validar stock
            if (cantidad > stockActual)
            {
                MessageBox.Show("No hay suficiente stock disponible.");
                return;
            }

            Salida salida = new Salida();

            salida.cantidad = cantidad;
            salida.motivo = txtMotivo.Text;
            salida.id_producto = productoSeleccionado.id_producto;
            salida.id_usuario = _usuarioSesion.id_usuario;

            SalidaDAL salidaDAL = new SalidaDAL();

            salidaDAL.RegistrarSalida(salida);

            ProductoDAL productoDAL = new ProductoDAL();

            bool stockActualizado = productoDAL.DisminuirStock(
                salida.id_producto,
                salida.cantidad
            );

            if (stockActualizado)
            {
                MessageBox.Show("Salida registrada correctamente.");

                txtCantidad.Clear();
                txtMotivo.Clear();

                CargarProductos();

                lblStockActual.Text = "";
            }
            else
            {
                MessageBox.Show("La salida se registró, pero no se pudo actualizar el stock.");
            }
        }
    }
}
