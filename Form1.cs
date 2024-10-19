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

namespace ProyectoClave6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Crea una instancia de la clase CConexion y utiliza el método EstablecerConexion
            CConexion conexionObj = new CConexion();
            MySqlConnection conexion = conexionObj.EstablecerConexion();

            if (conexion != null)
            {
                MessageBox.Show("Conexión exitosa");

            }
            else
            {
                MessageBox.Show("No se pudo establecer la conexión");
            }
        }

        private void btnSiguienteForms_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            Form2 form2 = new Form2();

            // Mostrar el segundo formulario
            form2.Show();

            // Opcional: Ocultar el primer formulario (sin cerrarlo)
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cerrar la aplicación
                Application.Exit();
            }
            else
            {
                // Si el usuario elige "No", no hacer nada
                // Se mantiene la aplicación abierta
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CConexion
            CConexion conexion = new CConexion();

            // Obtener la conexión establecida
            MySqlConnection conn = conexion.EstablecerConexion();

            // Verificar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(txtSesion.Text) || string.IsNullOrWhiteSpace(txtContra.Text))
            {
                MessageBox.Show("Error: Los campos de nombre de usuario y contraseña no pueden estar vacíos. Por favor, complete ambos campos.");
                return;  // Salir del método si los campos están vacíos
            }

            try
            {
                // Crear la consulta para verificar si el usuario y la contraseña existen
                string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombreUsuario AND contraseña = @contrasena";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Asignar los parámetros
                    cmd.Parameters.AddWithValue("@nombreUsuario", txtSesion.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtContra.Text);

                    // Ejecutar la consulta
                    object result = cmd.ExecuteScalar();

                    // Comprobación de depuración: ¿Qué devuelve el resultado?
                    if (result == null)
                    {
                        MessageBox.Show("Error: La consulta no devolvió ningún resultado.");
                        return;
                    }

                    // Asegurarse de que el valor no sea nulo o un valor no esperado
                    int userCount = 0;
                    if (int.TryParse(result.ToString(), out userCount))
                    {
                        // Verificar si se encontró el usuario
                        if (userCount > 0)
                        {
                            // Si el usuario existe, permitir el inicio de sesión
                            MessageBox.Show("Inicio de sesión exitoso.");

                            // Crear una instancia de Form3
                            Form3 form3 = new Form3();

                            // Mostrar Form3
                            form3.Show();

                            // Ocultar el Form1 actual
                            this.Hide();
                        }
                        else
                        {
                            // Si no se encuentra el usuario, mostrar un mensaje
                            MessageBox.Show("Error: El usuario no está registrado. Por favor, registre una cuenta.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: El resultado no es un número válido.");
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
                MessageBox.Show("Error al verificar los datos: " + ex.Message);
            }
        }
    }
}