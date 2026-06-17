namespace Printzone
{
    partial class FormEntradas
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
            cmbProveedor = new ComboBox();
            cmbProducto = new ComboBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            dgvEntradas = new DataGridView();
            txtCostoLote = new TextBox();
            label5 = new Label();
            btnNuevoProducto = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(493, 83);
            label1.Name = "label1";
            label1.Size = new Size(373, 31);
            label1.TabIndex = 0;
            label1.Text = "Gestión de entradas de productos";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(19, 97);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(279, 28);
            cmbProveedor.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(19, 188);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(279, 28);
            cmbProducto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 261);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(19, 285);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 73);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Proveedor:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 165);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Producto:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dgvEntradas);
            panel1.Location = new Point(358, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 534);
            panel1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(198, 14);
            label8.Name = "label8";
            label8.Size = new Size(205, 28);
            label8.TabIndex = 1;
            label8.Text = "Lista de las entradas";
            // 
            // dgvEntradas
            // 
            dgvEntradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntradas.Location = new Point(3, 60);
            dgvEntradas.Name = "dgvEntradas";
            dgvEntradas.RowHeadersWidth = 51;
            dgvEntradas.Size = new Size(773, 378);
            dgvEntradas.TabIndex = 0;
            // 
            // txtCostoLote
            // 
            txtCostoLote.Location = new Point(19, 373);
            txtCostoLote.Name = "txtCostoLote";
            txtCostoLote.Size = new Size(125, 27);
            txtCostoLote.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 350);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 9;
            label5.Text = "Coste del lote:";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevoProducto.IconColor = Color.Black;
            btnNuevoProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoProducto.ImageAlign = ContentAlignment.TopCenter;
            btnNuevoProducto.Location = new Point(171, 421);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(127, 67);
            btnNuevoProducto.TabIndex = 8;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.TextAlign = ContentAlignment.BottomCenter;
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(19, 421);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(131, 65);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar entrada";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(316, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnNuevoProducto);
            panel2.Controls.Add(txtCostoLote);
            panel2.Controls.Add(btnRegistrar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbProveedor);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(cmbProducto);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 534);
            panel2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(92, 14);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 11;
            label7.Text = "Información";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(493, 22);
            label6.Name = "label6";
            label6.Size = new Size(254, 38);
            label6.TabIndex = 9;
            label6.Text = "Librería PrintZone";
            // 
            // btnRegresar
            // 
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft;
            btnRegresar.IconColor = Color.Black;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegresar.Location = new Point(1040, 22);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(95, 54);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "Inicio";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormEntradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1151, 693);
            Controls.Add(btnRegresar);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormEntradas";
            Text = "FormEntradas";
            Load += FormEntradas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbProveedor;
        private ComboBox cmbProducto;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnNuevoProducto;
        private TextBox txtCostoLote;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
        private DataGridView dgvEntradas;
        private Label label7;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnRegresar;
    }
}