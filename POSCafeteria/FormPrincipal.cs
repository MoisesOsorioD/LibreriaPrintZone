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
    public partial class FormPrincipal : Form
    {
        private Form _frmlogin;
        private Usuario _usuarioSesion;
        private bool cerrandoSesion = false;
        public FormPrincipal(Usuario user, Form frmlogin)
        {
            InitializeComponent();
            this._usuarioSesion = user;
            this._frmlogin = frmlogin;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = $"¡Bienvenido(a), {_usuarioSesion.nombre_completo}!";
            lblUsuario.Text = _usuarioSesion.nombre_usuario;
            lblRol.Text = _usuarioSesion.rol;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


            if (_usuarioSesion.rol == "Vendedor")
            {
                btnUsuarios.Visible = false;
                btnCategorias.Visible = false;
                btnProveedores.Visible = false;
                btnEntradas.Visible = false;
                btnSalidas.Top = btnProductos.Bottom + 15;
            }

            CargarCantidadProductos();
            CargarProductosStockMinimo();
            CargarUltimasEntradas();
            CargarUltimasSalidas();
        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUsuarios = new FormUsuarios(_usuarioSesion);
            frmUsuarios.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrandoSesion = true;
            // Cerrar la sesión actual y volver al formulario de inicio de sesión
            _frmlogin.Show();
            this.Close();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmProductos frmProductos = new FrmProductos(_usuarioSesion);

            frmProductos.ShowDialog();

            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuarios formUsuarios = new FormUsuarios(_usuarioSesion);
            formUsuarios.ShowDialog();
            this.Show();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEntradas formEntradas = new FormEntradas();
            formEntradas.ShowDialog();
            this.Show();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalidas frmSalidas = new FormSalidas(_usuarioSesion, this);
            frmSalidas.ShowDialog();

            this.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCategorias frmcategorias = new FormCategorias();
            frmcategorias.ShowDialog();
            this.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormProveedores frmProveedores = new FormProveedores();

            frmProveedores.ShowDialog();

            this.Show();
        }



        private void CargarCantidadProductos()
        {
            ProductoBLL productoBLL =
                new ProductoBLL();

            int cantidad =
                productoBLL.ObtenerCantidadProductos();

            txtCantidadProductos.Text =
                cantidad + " productos registrados";
        }



        private void CargarProductosStockMinimo()
        {
            ProductoBLL productoBLL =
                new ProductoBLL();

            List<Producto> lista =
                productoBLL.ObtenerProductosStockMinimo();

            txtStockMinimo.Clear();

            foreach (Producto producto in lista)
            {
                txtStockMinimo.AppendText(
                    producto.nombre +
                    " → Stock actual: " +
                    producto.stock_actual +
                    " | Mínimo: " +
                    producto.stock_minimo +
                    Environment.NewLine);
            }
        }



        private void CargarUltimasEntradas()
        {
            EntradaBLL entradaBLL =
                new EntradaBLL();

            List<Entrada> lista =
                entradaBLL.ObtenerUltimasEntradas();

            txtUltimaEntrada.Clear();

            foreach (Entrada entrada in lista)
            {
                txtUltimaEntrada.AppendText(
                    entrada.cantidad +
                    " " +
                    entrada.nombre_producto +
                    " - " +
                    entrada.fecha_entrada.ToString("dd/MM/yyyy") +
                    Environment.NewLine);
            }
        }




        private void CargarUltimasSalidas()
        {
            SalidaBLL salidaBLL =
                new SalidaBLL();

            List<Salida> lista =
                salidaBLL.ObtenerUltimasSalidas();

            txtUltimaSalida.Clear();

            foreach (Salida salida in lista)
            {
                txtUltimaSalida.AppendText(
                    salida.cantidad +
                    " " +
                    salida.nombre_producto +
                    " - " +
                    salida.fecha_salida.ToString("dd/MM/yyyy") +
                    Environment.NewLine);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrandoSesion)
            {
                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Realmente desea salir del sistema?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cerrandoSesion)
            {
                Application.Exit();
            }
        }
    }
}
