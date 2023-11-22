using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExamen
{
    public partial class frmRevistas : Form
    {
        List<Revista> listarevista = new List<Revista>();
        public frmRevistas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Revista revista = new Revista
            {
                Titulo = txtTitulo.Text,
                Costo = double.Parse(txtCosto.Text),
                Periodicidad = cboPeriodicidad.Text,
            };
            listarevista.Add(revista);
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listarevista;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtCosto.Clear();
            
        }
    }
}
