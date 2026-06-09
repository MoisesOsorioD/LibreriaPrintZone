using Printzone.BLL;
using Printzone.DAL;
using Printzone.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Printzone
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
        }

        private void CargarCategorias()
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();

            List<Categoria> categorias = categoriaDAL.ObtenerCategorias();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "nombre_categoria";
            cmbCategoria.ValueMember = "id_categoria";
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();

                producto.nombre = txtNombre.Text;
                producto.descripcion = txtDescripcion.Text;
                producto.marca = txtMarca.Text;

                producto.precio_compra = Convert.ToDecimal(txtPrecioCompra.Text);
                producto.precio_venta = Convert.ToDecimal(txtPrecioVenta.Text);

                producto.codigo_barras = txtCodigoBarras.Text;

                producto.stock_minimo = Convert.ToInt32(txtStockMinimo.Text);

                producto.id_categoria = Convert.ToInt32(cmbCategoria.SelectedValue);

                ProductoBLL productoBLL = new ProductoBLL();

                bool resultado = productoBLL.GuardarProducto(producto);

                if (resultado)
                {
                    MessageBox.Show(
                        "Producto registrado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtMarca.Clear();
                    txtPrecioCompra.Clear();
                    txtPrecioVenta.Clear();
                    txtCodigoBarras.Clear();
                    txtStockMinimo.Clear();

                    cmbCategoria.SelectedIndex = 0;

                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar el producto.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Debe ingresar valores numéricos válidos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}