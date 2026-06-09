using Printzone.BLL;
using Printzone.Entidades;
using System;
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
            ProductoBLL productoBLL = new ProductoBLL();

            cmbProducto.DataSource = productoBLL.ObtenerProductos();

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
            try
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                Producto productoSeleccionado = (Producto)cmbProducto.SelectedItem;

                int stockActual = productoSeleccionado.stock_actual;

                if (cantidad > stockActual)
                {
                    MessageBox.Show(
                        "No hay suficiente stock disponible.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Salida salida = new Salida();

                salida.cantidad = cantidad;
                salida.motivo = txtMotivo.Text;
                salida.id_producto = productoSeleccionado.id_producto;
                salida.id_usuario = _usuarioSesion.id_usuario;

                SalidaBLL salidaBLL = new SalidaBLL();

                bool salidaRegistrada = salidaBLL.RegistrarSalida(salida);

                if (salidaRegistrada)
                {
                    ProductoBLL productoBLL = new ProductoBLL();

                    bool stockActualizado = productoBLL.DisminuirStock(
                        salida.id_producto,
                        salida.cantidad);

                    if (stockActualizado)
                    {
                        MessageBox.Show(
                            "Salida registrada correctamente.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        txtCantidad.Clear();
                        txtMotivo.Clear();

                        CargarProductos();

                        lblStockActual.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(
                            "La salida se registró, pero no se pudo actualizar el stock.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar la salida.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Debe ingresar una cantidad válida.",
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