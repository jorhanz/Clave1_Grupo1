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
                string query = @"SELECT m.IdMascota, m.NombreMascota, e.NombreEspecie AS Especie, m.Raza, 
                         m.FechaNacimiento, u.NombreCompleto AS Propietario
                         FROM Mascotas m
                         INNER JOIN Especies e ON m.IdEspecie = e.IdEspecie
                         INNER JOIN Usuarios u ON m.IdPropietario = u.IdUsuario";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable mascotas = new DataTable();
                adapter.Fill(mascotas);
                return mascotas;
            }
        }
        // Método para insertar una nueva mascota
        public bool InsertarMascota(int idPropietario, string nombre, int idEspecie, string raza, DateTime fechaNacimiento)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Mascotas (IdPropietario, NombreMascota, IdEspecie, Raza, FechaNacimiento) " +
                               "VALUES (@IdPropietario, @NombreMascota, @IdEspecie, @Raza, @FechaNacimiento)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdPropietario", idPropietario);
                cmd.Parameters.AddWithValue("@NombreMascota", nombre);
                cmd.Parameters.AddWithValue("@IdEspecie", idEspecie);
                cmd.Parameters.AddWithValue("@Raza", raza);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable ObtenerEspecies()
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "SELECT IdEspecie, NombreEspecie FROM Especies";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable especies = new DataTable();
                adapter.Fill(especies);
                return especies;
            }
        }
        public bool EliminarMascota(int idMascota)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM Mascotas WHERE IdMascota = @IdMascota";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdMascota", idMascota);

                return cmd.ExecuteNonQuery() > 0; // Devuelve true si se eliminó con éxito
            }
        }
    }
}
