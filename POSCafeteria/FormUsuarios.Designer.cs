namespace Printzone
{
    partial class FormUsuarios
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnMenuPrincipal = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            chkActivo = new CheckBox();
            cmbRol = new ComboBox();
            label8 = new Label();
            txtClave = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtNombreCompleto = new TextBox();
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            dgvUsuarios = new DataGridView();
            label9 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Cafeteria1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(138, 12);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 1;
            label1.Text = "Cafetería \"Aromas\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(138, 90);
            label2.Name = "label2";
            label2.Size = new Size(304, 32);
            label2.TabIndex = 2;
            label2.Text = "Administración de Usuarios";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnMenuPrincipal);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(chkActivo);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNombreCompleto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(12, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 563);
            panel1.TabIndex = 3;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = Color.Brown;
            btnMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnMenuPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuPrincipal.ForeColor = Color.White;
            btnMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft;
            btnMenuPrincipal.IconColor = Color.White;
            btnMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuPrincipal.ImageAlign = ContentAlignment.TopCenter;
            btnMenuPrincipal.Location = new Point(13, 474);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(107, 74);
            btnMenuPrincipal.TabIndex = 16;
            btnMenuPrincipal.Text = "Inicio";
            btnMenuPrincipal.TextAlign = ContentAlignment.BottomCenter;
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(141, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 74);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Peru;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(264, 474);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 74);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(20, 413);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(127, 24);
            chkActivo.TabIndex = 12;
            chkActivo.Text = "Usuario Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Cajero", "Mesero" });
            cmbRol.Location = new Point(20, 371);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(351, 28);
            cmbRol.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(20, 348);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 10;
            label8.Text = "Rol:";
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Location = new Point(20, 313);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(351, 27);
            txtClave.TabIndex = 9;
            txtClave.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(20, 280);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 8;
            label7.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(20, 244);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(351, 27);
            txtEmail.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(20, 211);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCompleto.Location = new Point(20, 176);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(351, 27);
            txtNombreCompleto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(20, 143);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombre completo:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Location = new Point(20, 108);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(351, 27);
            txtNombreUsuario.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(20, 75);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 2;
            label4.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(59, 13);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 1;
            label3.Text = "Agregar o Editar Usuario";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Linen;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(13, 13);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvUsuarios);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Location = new Point(446, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 563);
            panel2.TabIndex = 4;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(0, 72);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(839, 491);
            dgvUsuarios.TabIndex = 17;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(58, 14);
            label9.Name = "label9";
            label9.Size = new Size(172, 28);
            label9.TabIndex = 16;
            label9.Text = "Lista de Usuarios";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Linen;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(12, 14);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 40);
            iconPictureBox2.TabIndex = 16;
            iconPictureBox2.TabStop = false;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1302, 732);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtNombreUsuario;
        private Label label4;
        private TextBox txtClave;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtNombreCompleto;
        private Label label5;
        private ComboBox cmbRol;
        private Label label8;
        private CheckBox chkActivo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private Label label9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btnMenuPrincipal;
    }
}