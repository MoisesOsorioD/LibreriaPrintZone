namespace Printzone
{
    partial class FormNuevoProducto
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtMarca = new TextBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCodigoBarras = new TextBox();
            txtStockMinimo = new TextBox();
            cmbCategoria = new ComboBox();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 94);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 39);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(268, 39);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(526, 39);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 186);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio de compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(268, 186);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 5;
            label6.Text = "Precio de venta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(526, 186);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 7;
            label8.Text = "Código de barras:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 329);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 8;
            label9.Text = "Stock mínimo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(268, 329);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 9;
            label10.Text = "Categoria:";
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(526, 341);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 50);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 27);
            txtNombre.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(268, 72);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(185, 27);
            txtDescripcion.TabIndex = 12;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(526, 72);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(185, 27);
            txtMarca.TabIndex = 13;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(20, 221);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(185, 27);
            txtPrecioCompra.TabIndex = 14;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(268, 221);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(185, 27);
            txtPrecioVenta.TabIndex = 15;
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(526, 221);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(185, 27);
            txtCodigoBarras.TabIndex = 16;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(20, 364);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(185, 27);
            txtStockMinimo.TabIndex = 18;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(268, 363);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(185, 28);
            cmbCategoria.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtStockMinimo);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPrecioCompra);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtPrecioVenta);
            panel1.Controls.Add(txtCodigoBarras);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 428);
            panel1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(381, 24);
            label7.Name = "label7";
            label7.Size = new Size(273, 41);
            label7.TabIndex = 1;
            label7.Text = "Librería PrintZone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(208, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(790, 621);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormNuevoProducto";
            Text = "FormNuevoProducto";
            Load += FormNuevoProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtMarca;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtCodigoBarras;
        private TextBox txtStockMinimo;
        private ComboBox cmbCategoria;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
    }
}