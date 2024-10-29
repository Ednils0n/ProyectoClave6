using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoClave6
{
    // Clase CConexion que hereda de Usuario
    class CConexion : Usuario
    {
        private MySqlConnection conex = new MySqlConnection();

        // Propiedades estáticas para la conexión
        static string servidor = "localhost";
        static string bd = "Proyecto6";
        static string usuario = "root";
        static string password = "ednilson";
        static string puerto = "3306";

        // Cadena de conexión
        static string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" +
            "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        // Constructor de la clase CConexion que llama al constructor de Usuario
        public CConexion(string nombreUsuario, string contrasena) : base(nombreUsuario, contrasena)
        {
        }

        // Método para establecer la conexión
        public MySqlConnection EstablecerConexion()
        {
            try
            {
                if (conex.State == System.Data.ConnectionState.Closed)
                {
                    conex.ConnectionString = cadenaConexion;
                    conex.Open();
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
