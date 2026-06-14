namespace Printzone
{
    partial class FormCategorias
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
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombreCategoria = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(172, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 25);
            label1.Name = "label1";
            label1.Size = new Size(254, 38);
            label1.TabIndex = 1;
            label1.Text = "Librería PrintZone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(357, 106);
            label2.Name = "label2";
            label2.Size = new Size(291, 28);
            label2.TabIndex = 2;
            label2.Text = "Administración de Categorias";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtNombreCategoria);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(30, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 281);
            panel1.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnActualizar.IconColor = Color.Black;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.Location = new Point(103, 217);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(200, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(3, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(8, 56);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(200, 27);
            txtNombreCategoria.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 27);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre de categoria:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvCategorias);
            panel2.Location = new Point(346, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 281);
            panel2.TabIndex = 4;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(10, 27);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(355, 219);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(772, 476);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCategorias";
            Text = "FormCategorias";
            Load += FormCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txtNombreCategoria;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Panel panel2;
        private DataGridView dgvCategorias;
        private FontAwesome.Sharp.IconButton btnActualizar;
    }
}