namespace PracticaExamen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip_Principal = new MenuStrip();
            Publicaciones_ToolStripMenuItem = new ToolStripMenuItem();
            Libros_ToolStripMenuItem = new ToolStripMenuItem();
            Revista_ToolStripMenuItem = new ToolStripMenuItem();
            MenuStrip_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip_Principal
            // 
            MenuStrip_Principal.Items.AddRange(new ToolStripItem[] { Publicaciones_ToolStripMenuItem });
            MenuStrip_Principal.Location = new Point(0, 0);
            MenuStrip_Principal.Name = "MenuStrip_Principal";
            MenuStrip_Principal.Size = new Size(867, 24);
            MenuStrip_Principal.TabIndex = 0;
            MenuStrip_Principal.Text = "menuStrip1";
            // 
            // Publicaciones_ToolStripMenuItem
            // 
            Publicaciones_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Libros_ToolStripMenuItem, Revista_ToolStripMenuItem });
            Publicaciones_ToolStripMenuItem.Name = "Publicaciones_ToolStripMenuItem";
            Publicaciones_ToolStripMenuItem.Size = new Size(92, 20);
            Publicaciones_ToolStripMenuItem.Text = "Publicaciones";
            // 
            // Libros_ToolStripMenuItem
            // 
            Libros_ToolStripMenuItem.Name = "Libros_ToolStripMenuItem";
            Libros_ToolStripMenuItem.Size = new Size(180, 22);
            Libros_ToolStripMenuItem.Text = "Ingresar Libros";
            Libros_ToolStripMenuItem.Click += Libros_ToolStripMenuItem_Click;
            // 
            // Revista_ToolStripMenuItem
            // 
            Revista_ToolStripMenuItem.Name = "Revista_ToolStripMenuItem";
            Revista_ToolStripMenuItem.Size = new Size(180, 22);
            Revista_ToolStripMenuItem.Text = "Ingresar Revista";
            Revista_ToolStripMenuItem.Click += Revista_ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 466);
            Controls.Add(MenuStrip_Principal);
            Name = "Form1";
            Text = "Form1";
            MenuStrip_Principal.ResumeLayout(false);
            MenuStrip_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip_Principal;
        private ToolStripMenuItem Publicaciones_ToolStripMenuItem;
        private ToolStripMenuItem Libros_ToolStripMenuItem;
        private ToolStripMenuItem Revista_ToolStripMenuItem;
    }
}