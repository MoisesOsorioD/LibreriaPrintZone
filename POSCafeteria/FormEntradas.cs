using System;
using System.Windows.Forms;

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
            CargarEntradas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada entrada = new Entrada();

                entrada.cantidad = Convert.ToInt32(txtCantidad.Text);
                entrada.costo_lote = Convert.ToDecimal(txtCostoLote.Text);

                entrada.id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                entrada.id_producto = Convert.ToInt32(cmbProducto.SelectedValue);

                EntradaBLL entradaBLL = new EntradaBLL();

                bool resultadoEntrada = entradaBLL.RegistrarEntrada(entrada);

                if (resultadoEntrada)
                {
                    ProductoBLL productoBLL = new ProductoBLL();

                    bool resultadoStock = productoBLL.ActualizarStock(
                        entrada.id_producto,
                        entrada.cantidad
                    );

                    if (resultadoStock)
                    {
                        MessageBox.Show(
                            "Entrada registrada correctamente.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        txtCantidad.Clear();
                        txtCostoLote.Clear();

                        cmbProveedor.SelectedIndex = 0;
                        cmbProducto.SelectedIndex = 0;

                        CargarEntradas();
                    }
                    else
                    {
                        MessageBox.Show(
                            "La entrada se registró, pero no se actualizó el stock.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar la entrada.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Debe ingresar valores válidos.",
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

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto formNuevoProducto = new FormNuevoProducto();
            formNuevoProducto.ShowDialog();

            CargarProductos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void CargarEntradas()
        {
            EntradaBLL entradaBLL =
                new EntradaBLL();

            dgvEntradas.DataSource =
                entradaBLL.ObtenerEntradas();

            dgvEntradas.Columns["id_entrada"].Visible = false;
            dgvEntradas.Columns["id_proveedor"].Visible = false;
            dgvEntradas.Columns["id_producto"].Visible = false;

            dgvEntradas.Columns["fecha_entrada"].HeaderText = "Fecha";
            dgvEntradas.Columns["cantidad"].HeaderText = "Cantidad";
            dgvEntradas.Columns["costo_lote"].HeaderText = "Costo Lote";
            dgvEntradas.Columns["nombre_producto"].HeaderText = "Producto";
            dgvEntradas.Columns["nombre_proveedor"].HeaderText = "Proveedor";


            dgvEntradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvEntradas.Columns["fecha_entrada"].Width = 120;
            dgvEntradas.Columns["cantidad"].Width = 80;
            dgvEntradas.Columns["costo_lote"].Width = 100;
            dgvEntradas.Columns["nombre_producto"].Width = 150;

            dgvEntradas.Columns["nombre_proveedor"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}