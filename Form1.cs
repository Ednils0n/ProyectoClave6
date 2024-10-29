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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CConexion 
            string nombreUsuario = "usuarioEjemplo";  
            string contrasena = "contrasenaEjemplo";  

            CConexion conexionObj = new CConexion(nombreUsuario, contrasena);
            MySqlConnection conexion = conexionObj.EstablecerConexion();

            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
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
            // Verificar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(txtSesion.Text) || string.IsNullOrWhiteSpace(txtContra.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos: nombre de usuario y contraseña.");
                return;
            }

            // Validar que el usuario y la contraseña sean diferentes
            if (txtSesion.Text == txtContra.Text)
            {
                MessageBox.Show("Error: El nombre de usuario y la contraseña no pueden ser iguales.");
                return;
            }

            // Crear una instancia de Usuario e intentar iniciar sesión
            Usuario usuario = new Usuario(txtSesion.Text, txtContra.Text);
            if (usuario.IniciarSesion())
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                // Crear una instancia de Form3 y mostrarlo
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();  // Ocultar Form1 actual
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Verifique sus credenciales.");
                return;
            }

            try
            {
                // Crear una instancia de la clase CConexion con el nombre de usuario y la contraseña ingresados
                CConexion conexion = new CConexion(txtSesion.Text, txtContra.Text);
                MySqlConnection conn = conexion.EstablecerConexion();

                // Crear la consulta SQL
                string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombreUsuario AND contraseña = @contrasena";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Asignar los parámetros de la consulta
                    cmd.Parameters.AddWithValue("@nombreUsuario", txtSesion.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtContra.Text);

                    // Ejecutar la consulta y obtener el número de usuarios encontrados
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        // Mostrar mensaje de éxito antes de pasar a Form3
                        MessageBox.Show("Inicio de sesión exitoso.");

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
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            {
                // Pedir el nombre de usuario mediante un cuadro de entrada flotante
                string nombreUsuario = Interaction.InputBox("Ingrese el nombre de usuario a eliminar:",
                                                            "Eliminar Usuario",
                                                            "");

                if (string.IsNullOrWhiteSpace(nombreUsuario))
                {
                    MessageBox.Show("Debe ingresar un nombre de usuario para continuar.");
                    return;
                }

                // Pedir la contraseña mediante un cuadro de entrada flotante
                string contrasena = Interaction.InputBox("Ingrese la contraseña del usuario:",
                                                         "Eliminar Usuario",
                                                         "");

                if (string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Debe ingresar la contraseña para continuar.");
                    return;
                }

                // Confirmar la eliminación del usuario
                DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el usuario '{nombreUsuario}'?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Crear la conexión a la base de datos
                        CConexion conexion = new CConexion("usuarioEjemplo", "contrasenaEjemplo");
                        MySqlConnection conn = conexion.EstablecerConexion();

                        // Verificar si el usuario y la contraseña coinciden
                        string checkQuery = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombreUsuario AND contraseña = @contrasena";

                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                            checkCmd.Parameters.AddWithValue("@contrasena", contrasena);

                            int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (userCount == 0)
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.");
                                return;
                            }
                        }

                        // Si el usuario existe, proceder con la eliminación
                        string deleteQuery = "DELETE FROM usuario WHERE nombre_usuario = @nombreUsuario AND contraseña = @contrasena";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                            cmd.Parameters.AddWithValue("@contrasena", contrasena);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Usuario eliminado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un usuario con esos datos.");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error en la base de datos: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inesperado: " + ex.Message);
                    }
                }
            }
        }
    }
}
