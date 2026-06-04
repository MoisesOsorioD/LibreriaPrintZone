using Printzone.BLL;
using Printzone.Entidades;

namespace Printzone
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario? user = usuarioBLL.IniciarSesion(txtUsuario.Text, txtClave.Text);

                if (user != null)
                {
                    MessageBox.Show($"Bienvenido {user.nombre_completo} ({user.rol})", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Abrimos el formulario del menú principal y enviamos el usuario
                    FormPrincipal frmPrincipal = new FormPrincipal(user, this);
                    txtUsuario.Clear();
                    txtClave.Clear();
                    this.Hide();
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
