using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Printzone.DAL;
using Printzone.Entidades;

namespace Printzone
{
    public partial class FormEntradas : Form
    {
        public FormEntradas()
        {
            InitializeComponent();
        }

        private void CargarProveedores()
        {
            ProveedorDAL proveedorDAL = new ProveedorDAL();

            cmbProveedor.DataSource = proveedorDAL.ObtenerProveedores();

            cmbProveedor.DisplayMember = "nombre_empresa";
            cmbProveedor.ValueMember = "id_proveedor";
        }

        private void CargarProductos()
        {
            ProductoDAL productoDAL = new ProductoDAL();

            cmbProducto.DataSource = productoDAL.ObtenerProductos();

            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "id_producto";
        }

        private void FormEntradas_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarProductos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();

            entrada.cantidad = Convert.ToInt32(txtCantidad.Text);
            entrada.costo_lote = Convert.ToDecimal(txtCostoLote.Text);

            entrada.id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
            entrada.id_producto = Convert.ToInt32(cmbProducto.SelectedValue);

            EntradaDAL entradaDAL = new EntradaDAL();

            bool resultadoEntrada = entradaDAL.RegistrarEntrada(entrada);

            if (resultadoEntrada)
            {
                ProductoDAL productoDAL = new ProductoDAL();

                bool resultadoStock = productoDAL.ActualizarStock(
                    entrada.id_producto,
                    entrada.cantidad
                );

                if (resultadoStock)
                {
                    MessageBox.Show("Entrada registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("La entrada se registró, pero no se actualizó el stock.");
                }
            }
            else
            {
                MessageBox.Show("No se pudo registrar la entrada.");
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto formNuevoProducto = new FormNuevoProducto();
            formNuevoProducto.ShowDialog();

        }
    }
}
