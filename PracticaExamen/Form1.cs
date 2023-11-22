namespace PracticaExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Libros_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibros frmlibros = new frmLibros();
            frmlibros.Show();
        }

        private void Revista_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevistas frmrevista = new frmRevistas();
            frmrevista.Show();
        }
    }
}