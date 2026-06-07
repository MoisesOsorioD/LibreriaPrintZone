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
            txtCostoLote = new TextBox();
            label5 = new Label();
            btnNuevoProducto = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 30);
            label1.Name = "label1";
            label1.Size = new Size(492, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión de entradas de productos";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(25, 57);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(237, 28);
            cmbProveedor.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(297, 56);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(237, 28);
            cmbProducto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(563, 11);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(563, 57);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 11);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 11);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Producto:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtCostoLote);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnNuevoProducto);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cmbProducto);
            panel1.Location = new Point(149, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 245);
            panel1.TabIndex = 7;
            // 
            // txtCostoLote
            // 
            txtCostoLote.Location = new Point(744, 57);
            txtCostoLote.Name = "txtCostoLote";
            txtCostoLote.Size = new Size(125, 27);
            txtCostoLote.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(744, 11);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 9;
            label5.Text = "Coste del lote:";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevoProducto.IconColor = Color.Black;
            btnNuevoProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoProducto.Location = new Point(251, 162);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(163, 36);
            btnNuevoProducto.TabIndex = 8;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(451, 162);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(151, 36);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar entrada";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormEntradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1202, 578);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormEntradas";
            Text = "FormEntradas";
            Load += FormEntradas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}