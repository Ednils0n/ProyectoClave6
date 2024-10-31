using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClave6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ConfigurarComboBox();  // Configurar opciones del ComboBox al cargar el formulario
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

        private void Form4_Load(object sender, EventArgs e) //Click Error
        {

        }

        private void btnGuardarSala_Click(object sender, EventArgs e)
        {

        }
    }
}
