namespace PracticaExamen
{
    partial class frmLibros
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
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtCosto = new TextBox();
            dgvDetalle = new DataGridView();
            dtpFechaPublicacion = new DateTimePicker();
            btnAgregar = new Button();
            btnNuevo = new Button();
            label5 = new Label();
            txtAutorMasLibros = new TextBox();
            label6 = new Label();
            btnVer = new Button();
            txtCantidadLibros = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 46);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "TITULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 102);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "AUTOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 46);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHA DE PUBLICACION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 102);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "COSTO";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(127, 43);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(208, 23);
            txtTitulo.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(127, 94);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(208, 23);
            txtAutor.TabIndex = 5;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(561, 94);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(200, 23);
            txtCosto.TabIndex = 7;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(45, 173);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(716, 198);
            dgvDetalle.TabIndex = 8;
            // 
            // dtpFechaPublicacion
            // 
            dtpFechaPublicacion.Location = new Point(561, 40);
            dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            dtpFechaPublicacion.Size = new Size(200, 23);
            dtpFechaPublicacion.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(551, 397);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(686, 397);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 494);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 12;
            label5.Text = "AUTOR CON MAS LIBROS";
            // 
            // txtAutorMasLibros
            // 
            txtAutorMasLibros.Location = new Point(249, 491);
            txtAutorMasLibros.Name = "txtAutorMasLibros";
            txtAutorMasLibros.Size = new Size(100, 23);
            txtAutorMasLibros.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 564);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 14;
            label6.Text = "CANTIDAD DE LIBROS";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(249, 628);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 15;
            btnVer.Text = "VER";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // txtCantidadLibros
            // 
            txtCantidadLibros.Location = new Point(249, 556);
            txtCantidadLibros.Name = "txtCantidadLibros";
            txtCantidadLibros.Size = new Size(100, 23);
            txtCantidadLibros.TabIndex = 16;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 803);
            Controls.Add(txtCantidadLibros);
            Controls.Add(btnVer);
            Controls.Add(label6);
            Controls.Add(txtAutorMasLibros);
            Controls.Add(label5);
            Controls.Add(btnNuevo);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaPublicacion);
            Controls.Add(dgvDetalle);
            Controls.Add(txtCosto);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLibros";
            Text = "frmLibros";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtCosto;
        private DataGridView dgvDetalle;
        private DateTimePicker dtpFechaPublicacion;
        private Button btnAgregar;
        private Button btnNuevo;
        private Label label5;
        private TextBox txtAutorMasLibros;
        private Label label6;
        private Button btnVer;
        private TextBox txtCantidadLibros;
    }
}