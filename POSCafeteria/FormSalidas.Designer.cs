namespace Printzone
{
    partial class FormSalidas
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
            label1 = new Label();
            label2 = new Label();
            cmbProducto = new ComboBox();
            label3 = new Label();
            lblStockActual = new Label();
            label4 = new Label();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtMotivo = new TextBox();
            label6 = new Label();
            lblUsuario = new Label();
            btnRegistrarSalida = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            dgvSalidas = new DataGridView();
            label9 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(448, 94);
            label1.Name = "label1";
            label1.Size = new Size(353, 31);
            label1.TabIndex = 0;
            label1.Text = "Gestión de salidas de productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 67);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(18, 95);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(215, 28);
            cmbProducto.TabIndex = 2;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 159);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Stock disponible:";
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockActual.Location = new Point(18, 189);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(24, 25);
            lblStockActual.TabIndex = 4;
            lblStockActual.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 254);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 5;
            label4.Text = "Cantidad a retirar:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(18, 277);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 337);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 7;
            label5.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(18, 364);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(214, 27);
            txtMotivo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 426);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(18, 458);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(24, 25);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "...";
            // 
            // btnRegistrarSalida
            // 
            btnRegistrarSalida.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnRegistrarSalida.IconColor = Color.Black;
            btnRegistrarSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarSalida.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrarSalida.Location = new Point(169, 499);
            btnRegistrarSalida.Name = "btnRegistrarSalida";
            btnRegistrarSalida.Size = new Size(121, 64);
            btnRegistrarSalida.TabIndex = 11;
            btnRegistrarSalida.Text = "Registrar salida";
            btnRegistrarSalida.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrarSalida.UseVisualStyleBackColor = true;
            btnRegistrarSalida.Click += btnRegistrarSalida_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvSalidas);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(341, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 579);
            panel1.TabIndex = 12;
            // 
            // dgvSalidas
            // 
            dgvSalidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalidas.Location = new Point(8, 67);
            dgvSalidas.Name = "dgvSalidas";
            dgvSalidas.RowHeadersWidth = 51;
            dgvSalidas.Size = new Size(579, 416);
            dgvSalidas.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(192, 5);
            label9.Name = "label9";
            label9.Size = new Size(187, 28);
            label9.TabIndex = 0;
            label9.Text = "Lista de las salidas";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnRegistrarSalida);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(txtMotivo);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbProducto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblStockActual);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 579);
            panel2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(89, 4);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 12;
            label8.Text = "Información";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(252, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(448, 34);
            label7.Name = "label7";
            label7.Size = new Size(273, 41);
            label7.TabIndex = 0;
            label7.Text = "Librería PrintZone";
            // 
            // btnRegresar
            // 
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegresar.IconColor = Color.Black;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.Location = new Point(843, 46);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormSalidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(954, 751);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormSalidas";
            Text = "FormSalidas";
            Load += FormSalidas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbProducto;
        private Label label3;
        private Label lblStockActual;
        private Label label4;
        private TextBox txtCantidad;
        private Label label5;
        private TextBox txtMotivo;
        private Label label6;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconButton btnRegistrarSalida;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private Label label8;
        private Label label9;
        private DataGridView dgvSalidas;
    }
}