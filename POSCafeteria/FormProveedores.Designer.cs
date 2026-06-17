namespace Printzone
{
    partial class FormProveedores
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
            txtMontoMinimoCompra = new TextBox();
            label10 = new Label();
            txtTelefonoAgente = new TextBox();
            txtNombreAgente = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            txtNombreEmpresa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            dgvProveedores = new DataGridView();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(329, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(486, 37);
            label1.Name = "label1";
            label1.Size = new Size(254, 38);
            label1.TabIndex = 1;
            label1.Text = "Librería PrintZone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(486, 94);
            label2.Name = "label2";
            label2.Size = new Size(308, 28);
            label2.TabIndex = 2;
            label2.Text = "Administración de Proveedores";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtMontoMinimoCompra);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtTelefonoAgente);
            panel1.Controls.Add(txtNombreAgente);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtNombreEmpresa);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(14, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 600);
            panel1.TabIndex = 3;
            // 
            // txtMontoMinimoCompra
            // 
            txtMontoMinimoCompra.Location = new Point(22, 535);
            txtMontoMinimoCompra.Name = "txtMontoMinimoCompra";
            txtMontoMinimoCompra.Size = new Size(236, 27);
            txtMontoMinimoCompra.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 512);
            label10.Name = "label10";
            label10.Size = new Size(196, 20);
            label10.TabIndex = 13;
            label10.Text = "Monto minimo de compra:";
            // 
            // txtTelefonoAgente
            // 
            txtTelefonoAgente.Location = new Point(22, 461);
            txtTelefonoAgente.Name = "txtTelefonoAgente";
            txtTelefonoAgente.Size = new Size(236, 27);
            txtTelefonoAgente.TabIndex = 12;
            // 
            // txtNombreAgente
            // 
            txtNombreAgente.Location = new Point(22, 389);
            txtNombreAgente.Name = "txtNombreAgente";
            txtNombreAgente.Size = new Size(236, 27);
            txtNombreAgente.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 438);
            label9.Name = "label9";
            label9.Size = new Size(151, 20);
            label9.TabIndex = 10;
            label9.Text = "Teléfono del agente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 366);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 9;
            label8.Text = "Nombre del agente:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(21, 318);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(237, 27);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(21, 236);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(237, 27);
            txtCorreo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 295);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 6;
            label7.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 213);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Correo:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(21, 156);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(237, 27);
            txtDireccion.TabIndex = 4;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(21, 70);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(237, 27);
            txtNombreEmpresa.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 133);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 2;
            label5.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 47);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 1;
            label4.Text = "Nombre de la empresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 3);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 0;
            label3.Text = "Información";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dgvProveedores);
            panel2.Location = new Point(346, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 600);
            panel2.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnActualizar.IconColor = Color.Black;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.ImageAlign = ContentAlignment.TopCenter;
            btnActualizar.Location = new Point(323, 512);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 70);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.BottomCenter;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(428, 512);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 70);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(217, 512);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 70);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(271, 3);
            label11.Name = "label11";
            label11.Size = new Size(208, 28);
            label11.TabIndex = 1;
            label11.Text = "Lista de Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(45, 47);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(682, 441);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // btnRegresar
            // 
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft;
            btnRegresar.IconColor = Color.Black;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegresar.Location = new Point(996, 37);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(98, 50);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Inicio";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1109, 782);
            Controls.Add(btnRegresar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox txtNombreEmpresa;
        private Label label5;
        private Label label4;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox txtTelefonoAgente;
        private TextBox txtNombreAgente;
        private Label label9;
        private TextBox txtMontoMinimoCompra;
        private Label label10;
        private Panel panel2;
        private Label label11;
        private DataGridView dgvProveedores;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnRegresar;
    }
}