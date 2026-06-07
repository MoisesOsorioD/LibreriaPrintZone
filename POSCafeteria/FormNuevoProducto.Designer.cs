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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 19);
            label1.Name = "label1";
            label1.Size = new Size(247, 41);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 88);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(276, 93);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(605, 93);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 236);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio de compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(276, 236);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 5;
            label6.Text = "Precio de venta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(605, 236);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 7;
            label8.Text = "Código de barras:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 369);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 8;
            label9.Text = "Stock mínimo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(282, 369);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 9;
            label10.Text = "Categoria:";
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(664, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 37);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 27);
            txtNombre.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(282, 129);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(153, 27);
            txtDescripcion.TabIndex = 12;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(605, 129);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(153, 27);
            txtMarca.TabIndex = 13;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(34, 271);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(153, 27);
            txtPrecioCompra.TabIndex = 14;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(276, 271);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(153, 27);
            txtPrecioVenta.TabIndex = 15;
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(605, 271);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(153, 27);
            txtCodigoBarras.TabIndex = 16;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(34, 419);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(153, 27);
            txtStockMinimo.TabIndex = 18;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(276, 418);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(153, 28);
            cmbCategoria.TabIndex = 19;
            // 
            // FormNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1100, 526);
            Controls.Add(cmbCategoria);
            Controls.Add(txtStockMinimo);
            Controls.Add(txtCodigoBarras);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtMarca);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNuevoProducto";
            Text = "FormNuevoProducto";
            Load += FormNuevoProducto_Load;
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
    }
}