using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_peliculas
{
    internal partial class Form1 : Form
    {
        private DataGridView tablaseries;

        public Form1()
        {
            InitializeComponent();
            tablaseries = new DataGridView();
            Clases.CMovies objetomovies = new Clases.CMovies();
            objetomovies.mostrarSeries(dgvtotalseries, dt);
           
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, System.EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, System.EventArgs e)
        {
            Clases.CMovies objetomovies = new Clases.CMovies();
            objetomovies.guardarSeries(txtTituloo, txtGeneroo, txtAutorr, txtDuracionn);
            objetomovies.mostrarSeries(dgvtotalseries, dt);
        }

        private void dgvtotalseries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CMovies objetomovies = new Clases.CMovies();
            objetomovies.seleccionarSeries(dgvtotalseries, txtidentificacion, txtTituloo, txtGeneroo, txtAutorr, txtDuracionn);
        }

        private void btnactualizar_Click(object sender, System.EventArgs e)
        {
            Clases.CMovies objetomovies = new Clases.CMovies();
            objetomovies.modificarSeries(txtidentificacion, txtTituloo, txtGeneroo, txtAutorr, txtDuracionn);
            objetomovies.mostrarSeries(dgvtotalseries, dt);
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            Clases.CMovies objetomovies = new Clases.CMovies();
            objetomovies.eliminarSeries(txtidentificacion);
            objetomovies.mostrarSeries(dgvtotalseries, dt);
        }
        
    }
}