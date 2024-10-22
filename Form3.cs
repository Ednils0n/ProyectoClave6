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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ConfigurarDataGridView();  // Configurar el DataGridView cuando se crea el Form3

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
    }
}
