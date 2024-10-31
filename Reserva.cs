using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ProyectoClave6
{
    // Clase Reserva que hereda de Usuario
    class Reserva : Usuario
    {
        public int IdReserva { get; private set; }  // Ahora es solo lectura externa
        public DateTime FechaReserva { get; set; }
        public int Menu1 { get; set; }
        public int Menu2 { get; set; }
        public int Menu3 { get; set; }
        public decimal TotalPagar { get; set; }

        // Constructor de la clase Reserva (sin IdReserva)
        public Reserva(string nombreUsuario, string contrasena, DateTime fechaReserva, int menu1, int menu2, int menu3)
            : base(nombreUsuario, contrasena)
        {
            FechaReserva = fechaReserva;
            Menu1 = menu1;
            Menu2 = menu2;
            Menu3 = menu3;
            CalcularTotal();
        }

        // Método para calcular el total a pagar basado en los menús seleccionados
        public void CalcularTotal()
        {
            TotalPagar = (Menu1 * 10) + (Menu2 * 12) + (Menu3 * 15);
        }

        // Método para guardar la reserva en la base de datos
        public bool GuardarReserva()
        {
            try
            {
                // Crear una instancia de CConexion con las credenciales de usuario
                CConexion conexion = new CConexion(NombreUsuario, Contrasena);
                MySqlConnection conn = conexion.EstablecerConexion();

                // Insertar la reserva en la base de datos
                string insertQuery = "INSERT INTO reserva (usuario, fecha, menu1, menu2, menu3, total) " +
                                     "VALUES (@usuario, @fecha, @menu1, @menu2, @menu3, @total)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", NombreUsuario);
                    cmd.Parameters.AddWithValue("@fecha", FechaReserva);
                    cmd.Parameters.AddWithValue("@menu1", Menu1);
                    cmd.Parameters.AddWithValue("@menu2", Menu2);
                    cmd.Parameters.AddWithValue("@menu3", Menu3);
                    cmd.Parameters.AddWithValue("@total", TotalPagar);

                    cmd.ExecuteNonQuery();

                    // Obtener el último ID insertado de MySQL
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    IdReserva = Convert.ToInt32(cmd.ExecuteScalar());  // Asignar el ID generado

                    return true;  // Reserva guardada exitosamente
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la base de datos: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
                return false;
            }
        }
    }
}