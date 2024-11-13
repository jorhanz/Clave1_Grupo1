using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CitaDatos
    {
        public DataTable ObtenerCitas()
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = @"SELECT c.IdCita, c.FechaCita, c.Motivo,
                         m.NombreMascota AS NombreMascota,  -- Cambia 'm.Nombre' a 'm.NombreMascota'
                         u.NombreCompleto AS NombreCliente,
                         v.NombreCompleto AS NombreVeterinario,
                         h.DiaSemana AS Horario
                         FROM Citas c
                         INNER JOIN Mascotas m ON c.IdMascota = m.IdMascota
                         INNER JOIN Usuarios u ON c.IdCliente = u.IdUsuario
                         INNER JOIN Usuarios v ON c.IdVeterinario = v.IdUsuario
                         INNER JOIN Horarios h ON c.IdHorario = h.IdHorario";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable citas = new DataTable();
                adapter.Fill(citas);
                return citas;
            }
        }
        public DataTable ObtenerVeterinarios()
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "SELECT IdUsuario, NombreCompleto FROM Usuarios WHERE IdRol = @IdRol"; 
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdRol", 2); //rol de veterinario es el ID 2

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable veterinarios = new DataTable();
                adapter.Fill(veterinarios);
                return veterinarios;
            }
        }
        public DataTable ObtenerMascotasPorCliente(int idCliente)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "SELECT IdMascota, NombreMascota FROM Mascotas WHERE IdPropietario = @idCliente";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable mascotas = new DataTable();
                adapter.Fill(mascotas);
                return mascotas;
            }
        }
        public DataTable ObtenerHorariosPorVeterinario(int idVeterinario, string diaSemana)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "SELECT IdHorario, HoraInicio, HoraFin FROM Horarios WHERE IdVeterinario = @idVeterinario AND DiaSemana = @diaSemana";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idVeterinario", idVeterinario);
                cmd.Parameters.AddWithValue("@diaSemana", diaSemana);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable horarios = new DataTable();
                adapter.Fill(horarios);
                return horarios;
            }
        }
        public bool InsertarCita(int idMascota, int idCliente, int idVeterinario, DateTime fechaCita, int idHorario, string motivo)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Citas (IdMascota, IdCliente, IdVeterinario, FechaCita, IdHorario, Motivo) " +
                               "VALUES (@IdMascota, @IdCliente, @IdVeterinario, @FechaCita, @IdHorario, @Motivo)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdMascota", idMascota);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@IdVeterinario", idVeterinario);
                cmd.Parameters.AddWithValue("@FechaCita", fechaCita);
                cmd.Parameters.AddWithValue("@IdHorario", idHorario);
                cmd.Parameters.AddWithValue("@Motivo", motivo);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        public DataTable ObtenerHorariosPorVeterinarioYDia(int idVeterinario, string diaSemana)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "SELECT IdHorario, HoraInicio, HoraFin FROM Horarios WHERE IdVeterinario = @idVeterinario AND DiaSemana = @diaSemana";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idVeterinario", idVeterinario);
                cmd.Parameters.AddWithValue("@diaSemana", diaSemana);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable horarios = new DataTable();
                adapter.Fill(horarios);

                // Verificación: Asegúrate de que `horarios` tenga filas
                if (horarios.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontraron horarios para este veterinario y día.");
                }

                return horarios;
            }
        }
    }
}
