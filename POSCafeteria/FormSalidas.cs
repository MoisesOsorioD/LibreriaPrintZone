using Printzone.BLL;
using Printzone.Entidades;
using System;
using System.Windows.Forms;

namespace Printzone
{
    public partial class FormSalidas : Form
    {
        private Usuario _usuarioSesion;
        private FormPrincipal _frmPrincipal;

        public FormSalidas(Usuario usuario, FormPrincipal frmPrincipal)
        {
            InitializeComponent();
            _usuarioSesion = usuario;
            _frmPrincipal = frmPrincipal;
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
            CargarSalidas();
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
                        CargarSalidas();

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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void CargarSalidas()
        {
            SalidaBLL salidaBLL =
                new SalidaBLL();

            dgvSalidas.DataSource =
                salidaBLL.ObtenerSalidas();

            dgvSalidas.Columns["id_salida"].Visible = false;
            dgvSalidas.Columns["id_usuario"].Visible = false;
            dgvSalidas.Columns["id_producto"].Visible = false;

            dgvSalidas.Columns["fecha_salida"].HeaderText = "Fecha";
            dgvSalidas.Columns["cantidad"].HeaderText = "Cantidad";
            dgvSalidas.Columns["motivo"].HeaderText = "Motivo";
            dgvSalidas.Columns["nombre_producto"].HeaderText = "Producto";
            dgvSalidas.Columns["nombre_usuario"].HeaderText = "Usuario";
        }
    }
}