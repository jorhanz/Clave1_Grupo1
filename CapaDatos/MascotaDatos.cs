using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace CapaDatos
{
    public class MascotaDatos
    {
        // Método para obtener todas las mascotas junto con el nombre de su dueño
        public DataTable ObtenerMascotas()
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = @"SELECT m.IdMascota, m.NombreMascota, m.Especie, m.Raza, m.FechaNacimiento, 
                         u.NombreCompleto AS NombrePropietario
                         FROM Mascotas m
                         INNER JOIN Usuarios u ON m.IdPropietario = u.IdUsuario";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable mascotas = new DataTable();
                adapter.Fill(mascotas);
                return mascotas;
            }
        }
        // Método para insertar una nueva mascota
        public bool InsertarMascota(int idDuenio, string nombre, string especie, string raza, DateTime fechaNacimiento)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Mascotas (id_duenio, nombre, especie, raza, fecha_nacimiento) " +
                               "VALUES (@IdDuenio, @Nombre, @Especie, @Raza, @FechaNacimiento)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdDuenio", idDuenio);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Especie", especie);
                cmd.Parameters.AddWithValue("@Raza", raza);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
