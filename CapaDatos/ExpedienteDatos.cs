using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class ExpedienteDatos
    {
        public bool InsertarConsulta(int idMascota, int idVeterinario, DateTime fechaConsulta, string descripcion)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = @"INSERT INTO ExpedienteClinico (FechaConsulta, Descripcion, IdMascota, IdVeterinario) 
                         VALUES (@FechaConsulta, @Descripcion, @IdMascota, @IdVeterinario)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@FechaConsulta", fechaConsulta);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@IdMascota", idMascota);
                cmd.Parameters.AddWithValue("@IdVeterinario", idVeterinario);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable ObtenerHistorialClinico(int idMascota)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = @"SELECT e.IdExpediente, e.FechaConsulta, e.Descripcion, u.NombreCompleto AS NombreVeterinario
                         FROM ExpedienteClinico e
                         INNER JOIN Usuarios u ON e.IdVeterinario = u.IdUsuario
                         WHERE e.IdMascota = @IdMascota";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdMascota", idMascota);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable historial = new DataTable();
                adapter.Fill(historial);
                return historial;
            }
        }
    }
}
