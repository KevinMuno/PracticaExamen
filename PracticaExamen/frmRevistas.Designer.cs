namespace PracticaExamen
{
    partial class frmRevistas
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
            txtTitulo = new TextBox();
            cboPeriodicidad = new ComboBox();
            txtCosto = new TextBox();
            dgvDetalle = new DataGridView();
            btnAgregar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 41);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "TITULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 104);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "PERIODICIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 66);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "COSTO";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(150, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(167, 23);
            txtTitulo.TabIndex = 3;
            // 
            // cboPeriodicidad
            // 
            cboPeriodicidad.FormattingEnabled = true;
            cboPeriodicidad.Items.AddRange(new object[] { "MENSUAL", "SEMANAL", "QUINCENAL" });
            cboPeriodicidad.Location = new Point(196, 96);
            cboPeriodicidad.Name = "cboPeriodicidad";
            cboPeriodicidad.Size = new Size(121, 23);
            cboPeriodicidad.TabIndex = 4;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(538, 63);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 5;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(62, 236);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(715, 209);
            dgvDetalle.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(540, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 27);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(667, 176);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 27);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmRevistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 505);
            Controls.Add(btnNuevo);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDetalle);
            Controls.Add(txtCosto);
            Controls.Add(cboPeriodicidad);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRevistas";
            Text = "frmRevistas";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitulo;
        private ComboBox cboPeriodicidad;
        private TextBox txtCosto;
        private DataGridView dgvDetalle;
        private Button btnAgregar;
        private Button btnNuevo;
    }
}