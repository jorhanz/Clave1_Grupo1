using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class HorarioDatos
    {
        public bool InsertarHorario(string diaSemana, TimeSpan horaInicio, TimeSpan horaFin, int idVeterinario)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Horarios (DiaSemana, HoraInicio, HoraFin, IdVeterinario) VALUES (@DiaSemana, @HoraInicio, @HoraFin, @IdVeterinario)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@DiaSemana", diaSemana);
                cmd.Parameters.AddWithValue("@HoraInicio", horaInicio);
                cmd.Parameters.AddWithValue("@HoraFin", horaFin);
                cmd.Parameters.AddWithValue("@IdVeterinario", idVeterinario);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable ObtenerHorarios()
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();

                // Consulta SQL con un JOIN para obtener el nombre del veterinario desde la tabla Usuarios
                string query = @"SELECT h.IdHorario, h.DiaSemana, h.HoraInicio, h.HoraFin, u.NombreCompleto AS NombreVeterinario 
                         FROM Horarios h
                         INNER JOIN Usuarios u ON h.IdVeterinario = u.IdUsuario";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable horarios = new DataTable();
                adapter.Fill(horarios);

                return horarios;
            }
        }
        public bool EliminarHorario(int idHorario)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM Horarios WHERE IdHorario = @IdHorario";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdHorario", idHorario);

                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0; // Devuelve true si se eliminó alguna fila
                }
            }
        }

    }
}
