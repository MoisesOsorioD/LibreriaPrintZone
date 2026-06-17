using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Printzone.BLL;
using Printzone.Entidades;

namespace Printzone
{
    public partial class FormProveedores : Form
    {
        private int idProveedorSeleccionado = 0;
        public FormProveedores()
        {
            InitializeComponent();
        }



        private void CargarProveedores()
        {
            ProveedorBLL proveedorBLL =
                new ProveedorBLL();

            dgvProveedores.DataSource =
                proveedorBLL.ObtenerProveedores();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvProveedores.Rows[e.RowIndex];

                idProveedorSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["id_proveedor"].Value);

                txtNombreEmpresa.Text =
                    fila.Cells["nombre_empresa"].Value.ToString();

                txtDireccion.Text =
                    fila.Cells["direccion"].Value.ToString();

                txtCorreo.Text =
                    fila.Cells["correo"].Value.ToString();

                txtTelefono.Text =
                    fila.Cells["telefono"].Value.ToString();

                txtNombreAgente.Text =
                    fila.Cells["nombre_agente"].Value.ToString();

                txtTelefonoAgente.Text =
                    fila.Cells["telefono_agente"].Value.ToString();

                txtMontoMinimoCompra.Text =
                    fila.Cells["monto_minimo_compra"].Value.ToString();
            }
        }



        private void LimpiarCampos()
        {
            txtNombreEmpresa.Clear();

            txtDireccion.Clear();

            txtCorreo.Clear();

            txtTelefono.Clear();

            txtNombreAgente.Clear();

            txtTelefonoAgente.Clear();

            txtMontoMinimoCompra.Clear();

            idProveedorSeleccionado = 0;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor();

                proveedor.nombre_empresa =
                    txtNombreEmpresa.Text;

                proveedor.direccion =
                    txtDireccion.Text;

                proveedor.correo =
                    txtCorreo.Text;

                proveedor.telefono =
                    txtTelefono.Text;

                proveedor.nombre_agente =
                    txtNombreAgente.Text;

                proveedor.telefono_agente =
                    txtTelefonoAgente.Text;

                proveedor.monto_minimo_compra =
                    Convert.ToDecimal(
                        txtMontoMinimoCompra.Text);

                ProveedorBLL proveedorBLL =
                    new ProveedorBLL();

                bool resultado =
                    proveedorBLL.InsertarProveedor(
                        proveedor);

                if (resultado)
                {
                    MessageBox.Show(
                        "Proveedor registrado correctamente.");

                    LimpiarCampos();

                    CargarProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor();

                proveedor.id_proveedor =
                    idProveedorSeleccionado;

                proveedor.nombre_empresa =
                    txtNombreEmpresa.Text;

                proveedor.direccion =
                    txtDireccion.Text;

                proveedor.correo =
                    txtCorreo.Text;

                proveedor.telefono =
                    txtTelefono.Text;

                proveedor.nombre_agente =
                    txtNombreAgente.Text;

                proveedor.telefono_agente =
                    txtTelefonoAgente.Text;

                proveedor.monto_minimo_compra =
                    Convert.ToDecimal(
                        txtMontoMinimoCompra.Text);

                ProveedorBLL proveedorBLL =
                    new ProveedorBLL();

                bool resultado =
                    proveedorBLL.ActualizarProveedor(
                        proveedor);

                if (resultado)
                {
                    MessageBox.Show(
                        "Proveedor actualizado correctamente.");

                    LimpiarCampos();

                    CargarProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorBLL proveedorBLL =
                    new ProveedorBLL();

                bool resultado =
                    proveedorBLL.EliminarProveedor(
                        idProveedorSeleccionado);

                if (resultado)
                {
                    MessageBox.Show(
                        "Proveedor eliminado correctamente.");

                    LimpiarCampos();

                    CargarProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
