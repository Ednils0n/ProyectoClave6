using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoClave6
{
    // Clase Reserva que hereda de Usuario
    class Reserva : Usuario
    {
        public int IdReserva { get; private set; }
        public DateTime FechaReserva { get; set; }
        public int Menu1 { get; set; }
        public int Menu2 { get; set; }
        public int Menu3 { get; set; }
        public decimal TotalPagar { get; set; }

        // Constructor de la clase Reserva 
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
    
        }
    }