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
    public partial class FormUsuarios : Form
    {

        private Usuario usuario;
        private UsuarioBLL _usuarioBLL = new UsuarioBLL();
        // Variable para saber qué usuario estamos editando
        private int _idUsuarioSeleccionado = 0;
        public FormUsuarios(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // Desactivar el estilo visual por defecto del DataGridView
            dgvUsuarios.EnableHeadersVisualStyles = false;

            // Asignar el color de fondo y de texto al encabezado del DataGridView
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgvUsuarios.DataSource = _usuarioBLL.ListarUsuarios();
                // Ocultamos la columna de la contraseña por seguridad
                if (dgvUsuarios.Columns["Clave"] != null)
                {
                    dgvUsuarios.Columns["Clave"].Visible = false;
                    dgvUsuarios.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            _idUsuarioSeleccionado = 0;
            txtNombreUsuario.Clear();
            txtNombreCompleto.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;
            chkActivo.Checked = true;

            // Regresar el foco al primer campo
            txtNombreUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    id_usuario = _idUsuarioSeleccionado, // Si es 0 inserta, si tiene número actualiza
                    nombre_usuario = txtNombreUsuario.Text,
                    nombre_completo = txtNombreCompleto.Text,
                    clave = txtClave.Text,
                    rol = cmbRol.Text,
                    activo = chkActivo.Checked
                };
                bool exito = _usuarioBLL.GuardarUsuario(nuevoUsuario);

                if (exito)
                {
                    MessageBox.Show("Operación realizada con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDatos(); // Refresca el dgvUsuarios
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se haya hecho clic en una fila válida y no en los encabezados
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                _idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["id_usuario"].Value);
                txtNombreUsuario.Text = fila.Cells["nombre_usuario"].Value.ToString();
                txtNombreCompleto.Text = fila.Cells["nombre_completo"].Value.ToString();
                txtClave.Text = fila.Cells["clave"].Value.ToString();
                cmbRol.Text = fila.Cells["rol"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(fila.Cells["activo"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el DataGridView tenga al menos una fila seleccionada
            if (dgvUsuarios.CurrentRow == null || dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario directamente de la lista para eliminarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Extraer el ID directamente de la fila seleccionada en el DataGridView
            int idParaEliminar = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id_usuario"].Value);
            string nombreUsuario = dgvUsuarios.CurrentRow.Cells["nombre_usuario"].Value.ToString()!;

            // 3. Pedir confirmación (siempre es buena práctica mostrar a quién van a borrar)
            DialogResult resultado = MessageBox.Show($"¿Está seguro de desactivar al usuario '{nombreUsuario}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (_usuarioBLL.EliminarUsuario(idParaEliminar))
                    {
                        MessageBox.Show("Usuario desactivado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Llamamos a LimpiarCampos por si el usuario había hecho doble clic antes 
                        // y tenía datos a medio editar en las cajas de texto
                        LimpiarCampos();

                        CargarDatos(); // Refrescamos la cuadrícula
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
