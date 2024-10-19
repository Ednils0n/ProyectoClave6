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
            dgvReserva.Columns[0].Name = "Horario de Sala";
            dgvReserva.Columns[1].Name = "Reservacion hecha por:";
            dgvReserva.Columns[2].Name = "Asistentes";
            dgvReserva.Columns[2].Name = "Menu por Persona";
            dgvReserva.Columns[2].Name = "Total a pagar";
        }
    }
}
