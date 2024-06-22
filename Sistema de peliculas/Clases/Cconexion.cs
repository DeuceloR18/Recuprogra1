using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_peliculas.Clases
{
    internal class Cconexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "moviestv";
        static string usuario = "root";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no Se conecto correctamente, error:"+ ex.ToString());

            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
