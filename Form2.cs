using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace ProyectoClave6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            // Mostrar de nuevo el primer formulario
            Form1 form1 = new Form1();
            form1.Show();

            // Cerrar este formulario
            this.Close();
        }

        private void btnRegistrar1_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos antes de cualquier operación
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtContra.Text))
            {
                MessageBox.Show("Error: Los campos de nombre de usuario y contraseña no pueden estar vacíos. Por favor, complete ambos campos.");
                return;  // Salir del método si los campos están vacíos
            }

            // Crear una instancia de Usuario y realizar el registro
            Usuario usuario = new Usuario(txtNombre.Text, txtContra.Text);
            if (usuario.RegistrarUsuario())
            {
                MessageBox.Show("Usuario registrado exitosamente.");
                Form1 formLogin = new Form1();
                formLogin.Show();
                this.Close();  // Cerrar el Form2
                return;  // Salir del método después de un registro exitoso
            }
            else
            {
                MessageBox.Show("Error: El nombre de usuario ya está registrado. Elija otro nombre.");
                return;
            }

            try
            {
                // Crear una instancia de la clase CConexion con los argumentos requeridos
                CConexion conexion = new CConexion(txtNombre.Text, txtContra.Text);

                // Obtener la conexión establecida
                MySqlConnection conn = conexion.EstablecerConexion();

                // Verificar si el usuario ya existe en la base de datos
                string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombreUsuario";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Asignar los parámetros
                    cmd.Parameters.AddWithValue("@nombreUsuario", txtNombre.Text);

                    // Ejecutar la consulta
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        // Si el usuario ya existe, mostrar un mensaje de error
                        MessageBox.Show("Error: El nombre de usuario ya está registrado. Elija otro nombre.");
                    }
                    else
                    {
                        // Si el usuario no existe, procedemos a registrarlo
                        string insertQuery = "INSERT INTO usuario (nombre_usuario, contraseña) VALUES (@nombreUsuario, @contrasena)";
                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                        {
                            // Asignar los parámetros
                            insertCmd.Parameters.AddWithValue("@nombreUsuario", txtNombre.Text);
                            insertCmd.Parameters.AddWithValue("@contrasena", txtContra.Text);

                            // Ejecutar la consulta para registrar al usuario
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario registrado exitosamente.");
                        }

                        // Volver al Form1 para iniciar sesión
                        Form1 formLogin = new Form1();
                        formLogin.Show();
                        this.Close(); // Cerrar el Form2
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Capturar errores de MySQL y mostrar detalles adicionales
                MessageBox.Show("Error de MySQL: " + ex.Message + "\nCódigo de error: " + ex.Number);
            }
            catch (Exception ex)
            {
                // Manejo de otros errores generales
                MessageBox.Show("Error al registrar los datos: " + ex.Message);
            }
        }
    }
}
