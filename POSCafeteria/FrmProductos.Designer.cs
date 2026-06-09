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
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 9);
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
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEditar);
            panel1.Location = new Point(479, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 522);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(304, 13);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
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
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(485, 448);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 50);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnActualizar.IconColor = Color.Black;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(319, 448);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 50);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar lista";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(204, 448);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 50);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 753);
            panel2.TabIndex = 4;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(41, 623);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(270, 27);
            textBox8.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(41, 589);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 28;
            label11.Text = "Stock minimo:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(41, 538);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(270, 27);
            textBox7.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(41, 515);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 26;
            label10.Text = "Stock actual:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(41, 460);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(270, 27);
            textBox6.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 435);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 24;
            label9.Text = "Código de barras:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(41, 383);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(270, 27);
            textBox5.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 360);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 22;
            label8.Text = "Precio de venta:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(41, 311);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 27);
            textBox4.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 288);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 20;
            label7.Text = "Precio de compra:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 238);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 27);
            textBox3.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 206);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 18;
            label6.Text = "Marca:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 134);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 16;
            label5.Text = "Descripción:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 58);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 14;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 13);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 13;
            label3.Text = "Actualizar productos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(41, 671);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 30;
            label12.Text = "Categoria:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 694);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 28);
            comboBox1.TabIndex = 31;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1281, 839);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FrmProductos";
            Text = "FrmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private DataGridView dgvProductos;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox8;
        private Label label11;
        private ComboBox comboBox1;
        private Label label12;
    }
}