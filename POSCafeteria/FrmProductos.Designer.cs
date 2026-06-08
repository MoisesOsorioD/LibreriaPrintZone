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
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            dgvProductos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Productos";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvProductos);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(lblBuscar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnCerrar);
            panel1.Location = new Point(143, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 522);
            panel1.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(671, 447);
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
            btnActualizar.Location = new Point(472, 447);
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
            btnEditar.Location = new Point(317, 447);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 50);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnCerrar.IconColor = Color.Black;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(167, 447);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(109, 50);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(30, 35);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(120, 20);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar producto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(156, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(325, 27);
            txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(520, 35);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(30, 102);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(823, 307);
            dgvProductos.TabIndex = 11;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1281, 695);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FrmProductos";
            Text = "FrmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private DataGridView dgvProductos;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}