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
        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUsuarios = new FormUsuarios(_usuarioSesion);
            frmUsuarios.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar la sesión actual y volver al formulario de inicio de sesión
            _frmlogin.Show();
            this.Close();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios(_usuarioSesion);
            formUsuarios.ShowDialog();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            FormEntradas formEntradas = new FormEntradas();
            formEntradas.ShowDialog();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            FormSalidas frmSalidas = new FormSalidas(_usuarioSesion, this);

            this.Hide();

            frmSalidas.ShowDialog();

            this.Show();
        }
    }
}
