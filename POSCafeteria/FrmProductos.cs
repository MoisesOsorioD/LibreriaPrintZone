using Printzone.BLL;
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
    public partial class FrmProductos : Form
    {
        private int idProductoSeleccionado = 0;
        private Usuario _usuarioSesion;

        public FrmProductos(Usuario usuario)
        {
            InitializeComponent();

            _usuarioSesion = usuario;
        }


        private void CargarCategorias()
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();

            cmbCategoria.DataSource = categoriaBLL.ObtenerCategorias();

            cmbCategoria.DisplayMember = "nombre_categoria";
            cmbCategoria.ValueMember = "id_categoria";
        }


        private void CargarProductos()
        {
            ProductoBLL productoBLL = new ProductoBLL();

            dgvProductos.DataSource = productoBLL.ObtenerProductos();

            dgvProductos.Columns["id_categoria"].Visible = false;
            dgvProductos.Columns["activo"].Visible = false;

            dgvProductos.Columns["nombre_categoria"].HeaderText = "Categoría";

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProductos();

            if (_usuarioSesion.rol == "Vendedor")
            {
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;

                txtNombre.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                txtMarca.ReadOnly = true;
                txtPrecioCompra.ReadOnly = true;
                txtPrecioVenta.ReadOnly = true;
                txtCodigoBarras.ReadOnly = true;
                txtStockMinimo.ReadOnly = true;

                cmbCategoria.Enabled = false;
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Producto producto =
                    (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                idProductoSeleccionado = producto.id_producto;

                txtNombre.Text = producto.nombre;
                txtDescripcion.Text = producto.descripcion;
                txtMarca.Text = producto.marca;

                txtPrecioCompra.Text =
                    producto.precio_compra.ToString();

                txtPrecioVenta.Text =
                    producto.precio_venta.ToString();

                txtCodigoBarras.Text =
                    producto.codigo_barras;

                lblStockActual.Text =
                    producto.stock_actual.ToString();

                txtStockMinimo.Text =
                    producto.stock_minimo.ToString();

                cmbCategoria.SelectedValue =
                    producto.id_categoria;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();

                producto.id_producto = idProductoSeleccionado;

                producto.nombre = txtNombre.Text;
                producto.descripcion = txtDescripcion.Text;
                producto.marca = txtMarca.Text;

                producto.precio_compra =
                    Convert.ToDecimal(txtPrecioCompra.Text);

                producto.precio_venta =
                    Convert.ToDecimal(txtPrecioVenta.Text);

                producto.codigo_barras =
                    txtCodigoBarras.Text;

                producto.stock_minimo =
                    Convert.ToInt32(txtStockMinimo.Text);

                producto.id_categoria =
                    Convert.ToInt32(cmbCategoria.SelectedValue);

                ProductoBLL productoBLL = new ProductoBLL();

                bool resultado =
                    productoBLL.ActualizarProducto(producto);

                if (resultado)
                {
                    MessageBox.Show(
                        "Producto actualizado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProductos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el producto.",
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProductoSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Debe seleccionar un producto.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar este producto?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    ProductoBLL productoBLL = new ProductoBLL();

                    bool resultado =
                        productoBLL.EliminarProducto(idProductoSeleccionado);

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Producto eliminado correctamente.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarProductos();

                        idProductoSeleccionado = 0;

                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtMarca.Clear();
                        txtPrecioCompra.Clear();
                        txtPrecioVenta.Clear();
                        txtCodigoBarras.Clear();
                        txtStockMinimo.Clear();

                        lblStockActual.Text = "";

                        if (cmbCategoria.Items.Count > 0)
                        {
                            cmbCategoria.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el producto.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
