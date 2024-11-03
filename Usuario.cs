using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoClave6
{
    // Clase Usuario (clase base)
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        // Constructor de la clase Usuario
        public Usuario(string nombreUsuario, string contrasena)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }

        // Método para iniciar sesión
        public bool IniciarSesion()
        {
            CConexion conexion = new CConexion(NombreUsuario, Contrasena);
            MySqlConnection conn = conexion.EstablecerConexion();

            string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombreUsuario AND contraseña = @contrasena";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@contrasena", Contrasena);

                int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                return userCount > 0;
            }
        }

        // Método para registrar un nuevo usuario
        public bool RegistrarUsuario()
        {
            CConexion conexion = new CConexion(NombreUsuario, Contrasena);
            MySqlConnection conn = conexion.EstablecerConexion();

            // Verificar si el usuario ya existe
            string checkQuery = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombreUsuario";

            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@nombreUsuario", NombreUsuario);

                int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (userCount > 0)
                {
                    return false;  // El usuario ya existe, no se puede registrar
                }
            }

            // Registrar un nuevo usuario
            string insertQuery = "INSERT INTO usuario (nombre_usuario, contraseña) VALUES (@nombreUsuario, @contrasena)";

            using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@contrasena", Contrasena);

                cmd.ExecuteNonQuery();
                return true;  // Usuario registrado exitosamente
            }
        }
    }
}