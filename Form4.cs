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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ConfigurarComboBox();  // Configurar opciones del ComboBox al cargar el formulario
            ConfigurarDataGridView();  // Configurar el DataGridView
            CargarSalasGestionadas();  // Cargar los datos al DataGridView al iniciar el formulario
            LimpiarFormulario();
        }
        private void GuardarSala_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de que se ha ingresado la ubicación de la sala
                if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
                {
                    MessageBox.Show("Por favor, ingrese la ubicación de la sala.");
                    return;
                }

                if (cmbTipoSala.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo de sala.");
                    return;
                }

                // Obtener valores de los controles del formulario
                bool proyector = CHsipro.Checked;
                bool oasis = CHsioasis.Checked;
                bool cafetera = CHsicafe.Checked;
                string ubicacionSala = txtUbicacion.Text.Trim();
                string tipoSala = cmbTipoSala.SelectedItem.ToString();

                // Crear la conexión a la base de datos
                CConexion conexionObj = new CConexion("usuarioEjemplo", "contrasenaEjemplo");
                MySqlConnection conexion = conexionObj.EstablecerConexion();

                string query = "INSERT INTO disponibilidad (proyector, oasis, cafetera, ubicacion_sala, tipo_sala) " +
                               "VALUES (@proyector, @oasis, @cafetera, @ubicacionSala, @tipoSala)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@proyector", proyector);
                    cmd.Parameters.AddWithValue("@oasis", oasis);
                    cmd.Parameters.AddWithValue("@cafetera", cafetera);
                    cmd.Parameters.AddWithValue("@ubicacionSala", ubicacionSala);
                    cmd.Parameters.AddWithValue("@tipoSala", tipoSala);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Información de la sala guardada exitosamente.");
                }

                conexion.Close();  // Cerrar la conexión después de la operación

                // Refrescar el DataGridView con los nuevos datos y limpiar el formulario
                CargarSalasGestionadas();
                LimpiarFormulario();  // Limpiar campos después de guardar
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

        // Método para configurar las opciones del ComboBox para el tipo de sala
        private void ConfigurarComboBox()
        {
            // Agregar opciones al ComboBox de tipo de sala
            cmbTipoSala.Items.Add("Conferencia");
            cmbTipoSala.Items.Add("Reunión");
            cmbTipoSala.Items.Add("Taller");
            cmbTipoSala.SelectedIndex = 0;  // Seleccionar el primer elemento por defecto
        }

        // Método para configurar el DataGridView
        private void ConfigurarDataGridView()
        {
            dgvGestion.Columns.Clear();
            dgvGestion.Columns.Add("id", "ID");
            dgvGestion.Columns.Add("proyector", "Proyector");
            dgvGestion.Columns.Add("oasis", "Oasis");
            dgvGestion.Columns.Add("cafetera", "Cafetera");
            dgvGestion.Columns.Add("ubicacion", "Ubicación de la Sala");
            dgvGestion.Columns.Add("tipo", "Tipo de Sala");

            dgvGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestion.ReadOnly = true;
            dgvGestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestion.AllowUserToAddRows = false;
        }


        // Método para cargar las salas gestionadas al DataGridView
        public void CargarSalasGestionadas()
        {
            try
            {
                dgvGestion.Rows.Clear();  // Limpiar el DataGridView antes de cargar nuevos datos

                CConexion conexion = new CConexion("usuarioEjemplo", "contrasenaEjemplo");
                MySqlConnection conn = conexion.EstablecerConexion();

                string selectQuery = "SELECT * FROM disponibilidad";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvGestion.Rows.Add(
                                reader["id"],
                                Convert.ToBoolean(reader["proyector"]) ? "Sí" : "No",
                                Convert.ToBoolean(reader["oasis"]) ? "Sí" : "No",
                                Convert.ToBoolean(reader["cafetera"]) ? "Sí" : "No",
                                reader["ubicacion_sala"],
                                reader["tipo_sala"]
                            );
                        }
                    }
                }

                conn.Close();  // Cerrar la conexión después de la operación
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

        // Método para limpiar los campos del formulario
        private void LimpiarFormulario()
        {
            txtUbicacion.Clear();
            cmbTipoSala.SelectedIndex = 0;
            CHsipro.Checked = false;
            CHnopro.Checked = false;
            CHsioasis.Checked = false;
            CHnooasis.Checked = false;
            CHsicafe.Checked = false;
            CHnocafe.Checked = false;
        }

        private void Form4_Load(object sender, EventArgs e) //Click Error
        {

        }

        private void btnGuardarSala_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de ubicación y tipo de sala
                if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
                {
                    MessageBox.Show("Por favor, ingrese la ubicación de la sala.");
                    return;
                }

                if (cmbTipoSala.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo de sala.");
                    return;
                }

                // Obtener valores de los controles
                bool proyector = CHsipro.Checked;
                bool oasis = CHsioasis.Checked;
                bool cafetera = CHsicafe.Checked;
                string ubicacionSala = txtUbicacion.Text.Trim();
                string tipoSala = cmbTipoSala.SelectedItem.ToString();

                // Pasar nombre de usuario y contraseña para la instancia de Disponibilidad
                string nombreUsuario = "usuarioEjemplo";  // Reemplaza con el valor real o variable
                string contrasena = "contrasenaEjemplo";  // Reemplaza con el valor real o variable

                // Crear una instancia de Disponibilidad con los datos obtenidos
                Disponibilidad disponibilidad = new Disponibilidad(nombreUsuario, contrasena, proyector, oasis, cafetera, ubicacionSala, tipoSala);

                // Guardar la disponibilidad en la base de datos
                if (disponibilidad.GuardarDisponibilidad())
                {
                    MessageBox.Show("Información de la sala guardada exitosamente.");
                    CargarSalasGestionadas();  // Refrescar el DataGridView con los nuevos datos
                    LimpiarFormulario();       // Limpiar los campos del formulario
                }
                else
                {
                    MessageBox.Show("Error al guardar la disponibilidad.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
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
    }
}

 
