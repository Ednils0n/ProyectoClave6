﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ConfigurarDataGridView();  // Configurar el DataGridView cuando se crea el Form
        }

        private void ConfigurarDataGridView()
        {
            // Limpiamos cualquier columna anterior que pueda tener el DataGridView
            dgvReserva.Columns.Clear();

            // Agregar columna para el ID (que será generado por MySQL)
            dgvReserva.Columns.Add("id", "ID");

            // Agregar las demás columnas necesarias al DataGridView
            dgvReserva.Columns.Add("Usuario", "Usuario");
            dgvReserva.Columns.Add("Fecha", "Fecha de Reserva");
            dgvReserva.Columns.Add("Menu1", "Cantidad Menú 1");
            dgvReserva.Columns.Add("Menu2", "Cantidad Menú 2");
            dgvReserva.Columns.Add("Menu3", "Cantidad Menú 3");
            dgvReserva.Columns.Add("Total", "Total a Pagar");

            // Configuramos el ajuste de tamaño de las columnas
            dgvReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hacemos que el DataGridView no sea editable directamente por el usuario
            dgvReserva.ReadOnly = true;

            // Establecer el modo de selección a "FullRowSelect" para que seleccione toda la fila al hacer clic
            dgvReserva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Evitamos la adición de nuevas filas por el usuario (solo mediante el código)
            dgvReserva.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo de usuario no esté vacío
                if (string.IsNullOrWhiteSpace(txtReservador.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre de usuario.");
                    return;
                }

                // Validar que se hayan seleccionado cantidades en los NumericUpDowns
                if (nupMenu1.Value == 0 && nupMenu2.Value == 0 && nupMenu3.Value == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un menú.");
                    return;
                }

                // Validar que se haya seleccionado una fecha válida
                DateTime fechaReserva = dtmReservacion.Value;
                if (fechaReserva < DateTime.Now.Date)
                {
                    MessageBox.Show("No se puede seleccionar una fecha pasada.");
                    return;
                }

                // Validar que el número total de asistentes no exceda 25
                int totalAsistentes = (int)nupMenu1.Value + (int)nupMenu2.Value + (int)nupMenu3.Value;
                if (totalAsistentes > 25)
                {
                    MessageBox.Show("El número total de asistentes no puede exceder 25.");
                    return;
                }

                // Calcular el total a pagar
                decimal totalPagar = (nupMenu1.Value * 10) + (nupMenu2.Value * 12) + (nupMenu3.Value * 15);

                // Crear la consulta de inserción
                string query = "INSERT INTO reserva (usuario, fecha, menu1, menu2, menu3, total) VALUES (@usuario, @fecha, @menu1, @menu2, @menu3, @total)";

                // Crear la conexión con los parámetros requeridos
                string nombreUsuario = "usuarioEjemplo";  // Reemplaza con el nombre de usuario correcto
                string contrasena = "contrasenaEjemplo";  // Reemplaza con la contraseña correcta
                CConexion conexionObj = new CConexion(nombreUsuario, contrasena);
                MySqlConnection conexion = conexionObj.EstablecerConexion();

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    // Asignar los valores a los parámetros
                    cmd.Parameters.AddWithValue("@usuario", txtReservador.Text.Trim());  // Usar el nombre de usuario ingresado
                    cmd.Parameters.AddWithValue("@fecha", fechaReserva);
                    cmd.Parameters.AddWithValue("@menu1", nupMenu1.Value);
                    cmd.Parameters.AddWithValue("@menu2", nupMenu2.Value);
                    cmd.Parameters.AddWithValue("@menu3", nupMenu3.Value);
                    cmd.Parameters.AddWithValue("@total", totalPagar);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reserva guardada exitosamente.");

                    // Obtener el último ID insertado
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    int idReserva = Convert.ToInt32(cmd.ExecuteScalar());

                    // Añadir los datos al DataGridView
                    dgvReserva.Rows.Add(idReserva, txtReservador.Text.Trim(), fechaReserva.ToShortDateString(), nupMenu1.Value, nupMenu2.Value, nupMenu3.Value, totalPagar);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBorrarReservacion_Click(object sender, EventArgs e)
        {
            // Pedir el ID de la reservación
            string idReservaStr = Interaction.InputBox("Ingrese el ID de la reservación a eliminar:", "Borrar Reservación", "");

            if (string.IsNullOrWhiteSpace(idReservaStr) || !int.TryParse(idReservaStr, out int idReserva))
            {
                MessageBox.Show("Debe ingresar un ID de reservación válido.");
                return;
            }

            try
            {
                // Establecer la conexión a la base de datos
                CConexion conexion = new CConexion("usuario", "contraseña");
                MySqlConnection conn = conexion.EstablecerConexion();

                // Consulta DELETE
                string deleteQuery = "DELETE FROM reserva WHERE id = @idReserva";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@idReserva", idReserva);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservación eliminada exitosamente.");
                        CargarReservaciones();  // Llamar al método para refrescar el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una reservación con ese ID.");
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


        private void CargarReservaciones()
        {
            try
            {
                // Limpiar las filas del DataGridView
                dgvReserva.Rows.Clear();

                // Establecer la conexión a la base de datos
                CConexion conexion = new CConexion("usuario", "contraseña");  // Ajusta con tus credenciales
                MySqlConnection conn = conexion.EstablecerConexion();

                // Consulta para obtener todas las reservaciones
                string selectQuery = "SELECT * FROM reserva";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agregar filas al DataGridView
                            dgvReserva.Rows.Add(reader["id"], reader["usuario"], reader["fecha"],
                                                reader["menu1"], reader["menu2"], reader["menu3"], reader["total"]);
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


