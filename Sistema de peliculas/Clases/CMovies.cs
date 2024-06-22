using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_peliculas.Clases
{
    internal class CMovies
    {
        public void mostrarSeries(DataGridView tablaseries, object dt)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();
                String query = "select * from series";
                DataTable dataTable = new DataTable();
                DataTable dt = dataTable;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable series = new DataTable();
                adapter.Fill(dt);
                tablaseries.DataSource = dt;
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar los datos, error: " + ex.ToString());
            }
        }
        public void guardarSeries(TextBox Titulo, TextBox Genero, TextBox Autor, TextBox Duracion5)
        {
            try
            {
                
                Cconexion objetoConexion = new Cconexion();

                String query = "insert into series (Titulo,Genero,Autor,Duracion)" +
                    "values ('" + Titulo.Text + "','" + Genero.Text + "','" + Autor.Text + "','" + Duracion5 + "');";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se guardo correctamente los cambios");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro guardar los datos, error: " + ex.ToString());
            }
        }
        public void seleccionarSeries(DataGridView tablaSeries, TextBox id, TextBox Titulo, TextBox Genero, TextBox Autor, TextBox Duracion5)
        {
            try
            {
                id.Text = tablaSeries.CurrentRow.Cells[0].Value.ToString();
                Titulo.Text = tablaSeries.CurrentRow.Cells[1].Value.ToString();
                Genero.Text = tablaSeries.CurrentRow.Cells[2].Value.ToString();
                Autor.Text = tablaSeries.CurrentRow.Cells[3].Value.ToString();
                Duracion5.Text = tablaSeries.CurrentRow.Cells[4].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar los datos, error: " + ex.ToString());
            }
        }
        public void modificarSeries(TextBox identificacion, TextBox Tituloo, TextBox Genero, TextBox Autor, TextBox Duracion5)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();

                String query = "update series set Titulo='"
                    + Tituloo.Text + "', Genero='" + Genero.Text + "'where id='" + identificacion.Text + "';";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se modifico correctamente los cambios");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar los datos, error: " + ex.ToString());
            }

        }
        public void eliminarSeries(TextBox id)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();

                String query = "delete from series where id='" + id.Text + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se elimino correctamente los cambios");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro eliminar los datos, error: " + ex.ToString());
            }

        }
    }
}