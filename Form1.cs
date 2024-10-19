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
            try
            {
                // Crear una instancia de la clase CConexion
                CConexion conexion = new CConexion();

                // Obtener la conexión establecida
                MySqlConnection conn = conexion.EstablecerConexion();

                // Verificar si los campos están vacíos
                if (string.IsNullOrWhiteSpace(txtSesion.Text) || string.IsNullOrWhiteSpace(txtContra.Text))
                {
                    MessageBox.Show("Por favor, complete ambos campos: nombre de usuario y contraseña.");
                    return;
                }

                // Crear la consulta SQL
                string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombreUsuario AND contraseña = @contrasena";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Asignar los parámetros de la consulta
                    cmd.Parameters.AddWithValue("@nombreUsuario", txtSesion.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtContra.Text);

                    // Ejecutar la consulta y obtener el número de usuarios encontrados
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si se encuentra un usuario, redirigir a Form3
                    if (userCount > 0)
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();  // Ocultar Form1 actual
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos. Verifique sus credenciales.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Capturar cualquier otro error general
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
    }
}