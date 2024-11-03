using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoClave6
{
    public class Disponibilidad : Usuario
    {
        public int IdDisponibilidad { get; private set; }
        public bool Proyector { get; set; }
        public bool Oasis { get; set; }
        public bool Cafetera { get; set; }
        public string UbicacionSala { get; set; }
        public string TipoSala { get; set; }

        // Constructor que llama al constructor base de Usuario y asigna las propiedades de Disponibilidad
        public Disponibilidad(string nombreUsuario, string contrasena, bool proyector, bool oasis, bool cafetera, string ubicacionSala, string tipoSala)
            : base(nombreUsuario, contrasena)  // Llamada al constructor de Usuario
        {
            Proyector = proyector;
            Oasis = oasis;
            Cafetera = cafetera;
            UbicacionSala = ubicacionSala;
            TipoSala = tipoSala;
        }

        // Método para guardar la disponibilidad en la base de datos
        public bool GuardarDisponibilidad()
        {
            try
            {
                CConexion conexionObj = new CConexion(NombreUsuario, Contrasena);
                MySqlConnection conexion = conexionObj.EstablecerConexion();

                string query = "INSERT INTO disponibilidad (proyector, oasis, cafetera, ubicacion_sala, tipo_sala) " +
                               "VALUES (@proyector, @oasis, @cafetera, @ubicacionSala, @tipoSala)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@proyector", Proyector ? 1 : 0);
                    cmd.Parameters.AddWithValue("@oasis", Oasis ? 1 : 0);
                    cmd.Parameters.AddWithValue("@cafetera", Cafetera ? 1 : 0);
                    cmd.Parameters.AddWithValue("@ubicacionSala", UbicacionSala);
                    cmd.Parameters.AddWithValue("@tipoSala", TipoSala);

                    cmd.ExecuteNonQuery();

                    // Obtener el último ID insertado
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    IdDisponibilidad = Convert.ToInt32(cmd.ExecuteScalar());

                    return true;
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
