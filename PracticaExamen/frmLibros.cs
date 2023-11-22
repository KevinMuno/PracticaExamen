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
    public partial class frmLibros : Form
    {
        List<Libro> listapublicacions = new List<Libro>();


        public frmLibros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                FechaPublicacion = dtpFechaPublicacion.Value,
                Costo = double.Parse(txtCosto.Text),
            };
            listapublicacions.Add(libro);
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listapublicacions;

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            var autorConMasLibros = listapublicacions.OfType<Libro>()
           .GroupBy(libro => libro.Autor)
           .OrderByDescending(grupo => grupo.Count())
           .FirstOrDefault()?.Key;

            if (autorConMasLibros != null)
            {

                var cantidadLibrosAutorConMasLibros = listapublicacions.OfType<Libro>()
                    .Count(libro => libro.Autor == autorConMasLibros);

                txtAutorMasLibros.Text = autorConMasLibros;
                txtCantidadLibros.Text = Convert.ToString(cantidadLibrosAutorConMasLibros);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtCosto.Clear();
            txtAutor.Clear();
        }
    }
}
