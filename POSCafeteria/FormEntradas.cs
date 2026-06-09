using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Printzone.DAL;
using Printzone.BLL;
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
            ProveedorBLL proveedorBLL = new ProveedorBLL();

            cmbProveedor.DataSource = proveedorBLL.ObtenerProveedores();

            cmbProveedor.DisplayMember = "nombre_empresa";
            cmbProveedor.ValueMember = "id_proveedor";
        }

        private void CargarProductos()
        {
            ProductoBLL productoBLL = new ProductoBLL();

            cmbProducto.DataSource = productoBLL.ObtenerProductos();

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
                ProductoBLL productoBLL = new ProductoBLL();

                bool resultadoStock = productoBLL.ActualizarStock(
                    entrada.id_producto,
                    entrada.cantidad
                );

                if (resultadoStock)
                {
                    MessageBox.Show("Entrada registrada correctamente.");

                    txtCantidad.Clear();
                    txtCostoLote.Clear();

                    cmbProveedor.SelectedIndex = 0;
                    cmbProducto.SelectedIndex = 0;
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

            CargarProductos();
        }
    }
}