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

                // Validación de selección de un tipo de sala
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
                CConexion conexionObj = new CConexion("usuarioEjemplo", "contrasenaEjemplo");  // Reemplaza con tu usuario y contraseña
                MySqlConnection conexion = conexionObj.EstablecerConexion();

                // Crear consulta SQL para insertar la gestión de la sala
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
                CargarSalasGestionadas();  // Refrescar el DataGridView con los nuevos datos
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

                CConexion conexion = new CConexion("usuarioEjemplo", "contrasenaEjemplo");  // Reemplaza con tus credenciales
                MySqlConnection conn = conexion.EstablecerConexion();

                // Consulta para obtener todas las salas gestionadas de la tabla `disponibilidad`
                string selectQuery = "SELECT * FROM disponibilidad";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvGestion.Rows.Add(
                                reader["id"],
                                reader["proyector"],
                                reader["oasis"],
                                reader["cafetera"],
                                reader["ubicacion_sala"],
                                reader["tipo_sala"]);
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

                // Validación de opciones de equipo
                if ((!CHsipro.Checked && !CHnopro.Checked) ||
                    (!CHsioasis.Checked && !CHnooasis.Checked) ||
                    (!CHsicafe.Checked && !CHnocafe.Checked))
                {
                    MessageBox.Show("Por favor, seleccione Sí o No para cada equipo.");
                    return;
                }

                // Obtener valores de los controles
                bool proyector = CHsipro.Checked;
                bool oasis = CHsioasis.Checked;
                bool cafetera = CHsicafe.Checked;
                string ubicacionSala = txtUbicacion.Text.Trim();
                string tipoSala = cmbTipoSala.SelectedItem.ToString();

                // Crear conexión a la base de datos
                CConexion conexionObj = new CConexion("usuarioEjemplo", "contrasenaEjemplo");  // Reemplaza con tu usuario y contraseña
                MySqlConnection conexion = conexionObj.EstablecerConexion();

                // Crear consulta SQL para insertar la gestión de la sala
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

                conexion.Close();  // Cerrar la conexión
                CargarSalasGestionadas();  // Refrescar el DataGridView con los nuevos datos
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

 
