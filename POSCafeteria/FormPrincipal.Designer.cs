namespace Printzone
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblBienvenido = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            lblUsuario = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            lblRol = new Label();
            label6 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblFecha = new Label();
            label8 = new Label();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            btnCategorias = new FontAwesome.Sharp.IconButton();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnEntradas = new FontAwesome.Sharp.IconButton();
            btnSalidas = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtCantidadProductos = new TextBox();
            txtUltimaEntrada = new TextBox();
            txtUltimaSalida = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtStockMinimo = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(70, 5);
            label1.Name = "label1";
            label1.Size = new Size(254, 38);
            label1.TabIndex = 3;
            label1.Text = "Librería PrintZone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBienvenido.ForeColor = Color.Black;
            lblBienvenido.Location = new Point(122, 76);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(163, 28);
            lblBienvenido.TabIndex = 4;
            lblBienvenido.Text = "¡Bienvenido(a) !";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Linen;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(529, 78);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 30);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(565, 68);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(565, 88);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "User";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Linen;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ShieldBlank;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(703, 78);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(30, 30);
            iconPictureBox2.TabIndex = 8;
            iconPictureBox2.TabStop = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(739, 88);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 10;
            lblRol.Text = "Administrador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(739, 68);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 9;
            label6.Text = "Rol:";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Linen;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(907, 78);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(30, 30);
            iconPictureBox3.TabIndex = 11;
            iconPictureBox3.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(943, 88);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(77, 20);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "29/5/2026";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(954, 68);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 12;
            label8.Text = "Fecha:";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Brown;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(1091, 56);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(172, 48);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnProductos.IconColor = Color.Black;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(26, 26);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(154, 60);
            btnProductos.TabIndex = 16;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnCategorias.IconColor = Color.Black;
            btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(26, 102);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(154, 60);
            btnCategorias.TabIndex = 17;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextAlign = ContentAlignment.MiddleRight;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            btnProveedores.IconColor = Color.Black;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(26, 183);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(154, 60);
            btnProveedores.TabIndex = 18;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleRight;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnEntradas
            // 
            btnEntradas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntradas.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnEntradas.IconColor = Color.Black;
            btnEntradas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEntradas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntradas.Location = new Point(26, 264);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Size = new Size(154, 60);
            btnEntradas.TabIndex = 19;
            btnEntradas.Text = "Entradas";
            btnEntradas.TextAlign = ContentAlignment.MiddleRight;
            btnEntradas.UseVisualStyleBackColor = true;
            btnEntradas.Click += btnEntradas_Click;
            // 
            // btnSalidas
            // 
            btnSalidas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalidas.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            btnSalidas.IconColor = Color.Black;
            btnSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalidas.Location = new Point(26, 343);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(154, 60);
            btnSalidas.TabIndex = 20;
            btnSalidas.Text = "Salidas";
            btnSalidas.TextAlign = ContentAlignment.MiddleRight;
            btnSalidas.UseVisualStyleBackColor = true;
            btnSalidas.Click += btnSalidas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(26, 422);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(154, 60);
            btnUsuarios.TabIndex = 21;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnCategorias);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnSalidas);
            panel1.Controls.Add(btnEntradas);
            panel1.Location = new Point(12, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 514);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblFecha);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblBienvenido);
            panel2.Controls.Add(iconPictureBox3);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblRol);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 151);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtCantidadProductos);
            panel3.Controls.Add(txtUltimaEntrada);
            panel3.Controls.Add(txtUltimaSalida);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtStockMinimo);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(245, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(1064, 514);
            panel3.TabIndex = 24;
            // 
            // txtCantidadProductos
            // 
            txtCantidadProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidadProductos.Location = new Point(550, 282);
            txtCantidadProductos.Multiline = true;
            txtCantidadProductos.Name = "txtCantidadProductos";
            txtCantidadProductos.ReadOnly = true;
            txtCantidadProductos.ScrollBars = ScrollBars.Vertical;
            txtCantidadProductos.Size = new Size(395, 121);
            txtCantidadProductos.TabIndex = 7;
            // 
            // txtUltimaEntrada
            // 
            txtUltimaEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUltimaEntrada.Location = new Point(550, 52);
            txtUltimaEntrada.Multiline = true;
            txtUltimaEntrada.Name = "txtUltimaEntrada";
            txtUltimaEntrada.ReadOnly = true;
            txtUltimaEntrada.ScrollBars = ScrollBars.Vertical;
            txtUltimaEntrada.Size = new Size(395, 121);
            txtUltimaEntrada.TabIndex = 6;
            // 
            // txtUltimaSalida
            // 
            txtUltimaSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUltimaSalida.Location = new Point(26, 282);
            txtUltimaSalida.Multiline = true;
            txtUltimaSalida.Name = "txtUltimaSalida";
            txtUltimaSalida.ReadOnly = true;
            txtUltimaSalida.ScrollBars = ScrollBars.Vertical;
            txtUltimaSalida.Size = new Size(425, 121);
            txtUltimaSalida.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(550, 250);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 4;
            label7.Text = "Cantidad de productos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 250);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 3;
            label5.Text = "Última salida registrada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(550, 28);
            label4.Name = "label4";
            label4.Size = new Size(193, 20);
            label4.TabIndex = 2;
            label4.Text = "Última entrada registrada:";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStockMinimo.Location = new Point(26, 52);
            txtStockMinimo.Multiline = true;
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.ReadOnly = true;
            txtStockMinimo.ScrollBars = ScrollBars.Vertical;
            txtStockMinimo.Size = new Size(425, 121);
            txtStockMinimo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 26);
            label2.Name = "label2";
            label2.Size = new Size(242, 23);
            label2.TabIndex = 0;
            label2.Text = "Productos con stock mínimo:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1321, 740);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblBienvenido;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblRol;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label lblFecha;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnCategorias;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnEntradas;
        private FontAwesome.Sharp.IconButton btnSalidas;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private TextBox txtStockMinimo;
        private TextBox txtUltimaSalida;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox txtUltimaEntrada;
        private TextBox txtCantidadProductos;
    }
}