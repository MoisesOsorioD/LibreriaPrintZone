namespace Printzone
{
    partial class FrmProductos
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
            panel1 = new Panel();
            label2 = new Label();
            dgvProductos = new DataGridView();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnActualizarLista = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblStockActual = new Label();
            cmbCategoria = new ComboBox();
            label12 = new Label();
            txtStockMinimo = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtCodigoBarras = new TextBox();
            label9 = new Label();
            txtPrecioVenta = new TextBox();
            label8 = new Label();
            txtPrecioCompra = new TextBox();
            label7 = new Label();
            txtMarca = new TextBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(454, 9);
            label1.Name = "label1";
            label1.Size = new Size(426, 41);
            label1.TabIndex = 0;
            label1.Text = "Administración de Productos";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvProductos);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizarLista);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(601, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 572);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(304, 8);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 12;
            label2.Text = "Lista de productos";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(22, 58);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(723, 366);
            dgvProductos.TabIndex = 11;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(485, 494);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 50);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizarLista
            // 
            btnActualizarLista.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnActualizarLista.IconColor = Color.Black;
            btnActualizarLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizarLista.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarLista.Location = new Point(319, 494);
            btnActualizarLista.Name = "btnActualizarLista";
            btnActualizarLista.Size = new Size(160, 50);
            btnActualizarLista.TabIndex = 6;
            btnActualizarLista.Text = "Actualizar lista";
            btnActualizarLista.TextAlign = ContentAlignment.MiddleRight;
            btnActualizarLista.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(204, 494);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 50);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblStockActual);
            panel2.Controls.Add(cmbCategoria);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtStockMinimo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCodigoBarras);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtPrecioVenta);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtPrecioCompra);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtMarca);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 572);
            panel2.TabIndex = 4;
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockActual.Location = new Point(19, 413);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(22, 23);
            lblStockActual.TabIndex = 32;
            lblStockActual.Text = "...";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(19, 516);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(204, 28);
            cmbCategoria.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 478);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 30;
            label12.Text = "Categoria:";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(317, 409);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(204, 27);
            txtStockMinimo.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(317, 365);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 28;
            label11.Text = "Stock minimo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 365);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 26;
            label10.Text = "Stock actual:";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(317, 289);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(204, 27);
            txtCodigoBarras.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(317, 255);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 24;
            label9.Text = "Código de barras:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(19, 278);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(204, 27);
            txtPrecioVenta.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 255);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 22;
            label8.Text = "Precio de venta:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(317, 178);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(204, 27);
            txtPrecioCompra.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(317, 155);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 20;
            label7.Text = "Precio de compra:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(19, 178);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(204, 27);
            txtMarca.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 155);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 18;
            label6.Text = "Marca:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(317, 79);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(204, 27);
            txtDescripcion.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(317, 56);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 16;
            label5.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(19, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 27);
            txtNombre.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 56);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 14;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(175, 13);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 13;
            label3.Text = "Actualizar productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1374, 778);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnActualizarLista;
        private DataGridView dgvProductos;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtMarca;
        private Label label6;
        private TextBox txtPrecioCompra;
        private Label label7;
        private TextBox txtPrecioVenta;
        private Label label8;
        private Label label9;
        private TextBox txtCodigoBarras;
        private Label label10;
        private TextBox txtStockMinimo;
        private Label label11;
        private ComboBox cmbCategoria;
        private Label label12;
        private PictureBox pictureBox1;
        private Label lblStockActual;
    }
}