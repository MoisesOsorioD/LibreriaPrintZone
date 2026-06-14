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
    public partial class FormCategorias : Form
    {

        private int idCategoriaSeleccionada = 0;
        public FormCategorias()
        {
            InitializeComponent();
        }


        private void CargarCategorias()
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();

            dgvCategorias.DataSource =
                categoriaBLL.ObtenerCategorias();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvCategorias.Rows[e.RowIndex];

                idCategoriaSeleccionada =
                    Convert.ToInt32(
                        fila.Cells["id_categoria"].Value);

                txtNombreCategoria.Text =
                    fila.Cells["nombre_categoria"]
                    .Value
                    .ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();

                categoria.nombre_categoria =
                    txtNombreCategoria.Text.Trim();

                CategoriaBLL categoriaBLL =
                    new CategoriaBLL();

                bool resultado =
                    categoriaBLL.InsertarCategoria(categoria);

                if (resultado)
                {
                    MessageBox.Show(
                        "Categoría registrada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtNombreCategoria.Clear();

                    CargarCategorias();

                    idCategoriaSeleccionada = 0;
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar la categoría.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();

                categoria.id_categoria =
                    idCategoriaSeleccionada;

                categoria.nombre_categoria =
                    txtNombreCategoria.Text.Trim();

                CategoriaBLL categoriaBLL =
                    new CategoriaBLL();

                bool resultado =
                    categoriaBLL.ActualizarCategoria(categoria);

                if (resultado)
                {
                    MessageBox.Show(
                        "Categoría actualizada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtNombreCategoria.Clear();

                    idCategoriaSeleccionada = 0;

                    CargarCategorias();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar la categoría.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
                DialogResult respuesta = MessageBox.Show(
                    "¿Eliminar esta categoría?",
                    "Categorías",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                CategoriaBLL categoriaBLL = new CategoriaBLL();

                bool resultado =
                    categoriaBLL.EliminarCategoria(
                        idCategoriaSeleccionada);

                if (resultado)
                {
                    MessageBox.Show(
                        "Categoría eliminada correctamente.");

                    txtNombreCategoria.Clear();

                    idCategoriaSeleccionada = 0;

                    CargarCategorias();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("REFERENCE") ||
                    ex.Message.Contains("FK_Productos_Categorias") ||
                    ex.Message.Contains("DELETE"))
                {
                    MessageBox.Show(
                        "No se puede eliminar la categoría porque tiene productos asociados.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
