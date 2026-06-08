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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(465, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión de salidas de productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 117);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(121, 154);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(215, 28);
            cmbProducto.TabIndex = 2;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(380, 117);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Stock disponible:";
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Location = new Point(380, 162);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(18, 20);
            lblStockActual.TabIndex = 4;
            lblStockActual.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(660, 117);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 5;
            label4.Text = "Cantidad a retirar:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(660, 159);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(122, 282);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 7;
            label5.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(122, 323);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(214, 27);
            txtMotivo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(380, 282);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(380, 330);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(18, 20);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "...";
            // 
            // btnRegistrarSalida
            // 
            btnRegistrarSalida.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrarSalida.IconColor = Color.Black;
            btnRegistrarSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarSalida.Location = new Point(629, 321);
            btnRegistrarSalida.Name = "btnRegistrarSalida";
            btnRegistrarSalida.Size = new Size(156, 29);
            btnRegistrarSalida.TabIndex = 11;
            btnRegistrarSalida.Text = "Registrar salida";
            btnRegistrarSalida.UseVisualStyleBackColor = true;
            btnRegistrarSalida.Click += btnRegistrarSalida_Click;
            // 
            // FormSalidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1192, 581);
            Controls.Add(btnRegistrarSalida);
            Controls.Add(lblUsuario);
            Controls.Add(label6);
            Controls.Add(txtMotivo);
            Controls.Add(label5);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(lblStockActual);
            Controls.Add(label3);
            Controls.Add(cmbProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSalidas";
            Text = "FormSalidas";
            Load += FormSalidas_Load;
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
    }
}