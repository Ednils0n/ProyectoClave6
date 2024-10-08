using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoClave6
{
    class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "Proyecto6";      
        static string usuario = "root";
        static string password = "ednilson";
        static string puerto = "3306";

        static string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" +
            "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";     

        public object Messagebox { get; private set; }


        public MySqlConnection EstablecerConexion()
        {
            try
            {
                if (conex.State == System.Data.ConnectionState.Closed)
                {
                    conex.ConnectionString = cadenaConexion;
                    conex.Open();

                    // Comentamos o eliminamos esta línea
                    // MessageBox.Show("Se conectó con éxito a la base de datos");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }

            return conex;
        }

    }
}
