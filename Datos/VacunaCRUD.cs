using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.CRUD
{
    public class VacunaCRUD
    {
        public void Agregar(Vacuna vacuna)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Vacuna (id_mascota, nombre, fecha_aplicacion, proxima_aplicacion) VALUES (@id_mascota, @nombre, @fecha_aplicacion, @proxima_aplicacion)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_mascota", vacuna.IdMascota);
                    command.Parameters.AddWithValue("@nombre", vacuna.Nombre);
                    command.Parameters.AddWithValue("@fecha_aplicacion", vacuna.FechaAplicacion);
                    command.Parameters.AddWithValue("@proxima_aplicacion", vacuna.ProximaAplicacion);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Vacuna> ObtenerTodos()
        {
            var vacunas = new List<Vacuna>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Vacuna";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vacunas.Add(new Vacuna
                            {
                                IdVacuna = reader.GetInt32("id_vacuna"),
                                IdMascota = reader.GetInt32("id_mascota"),
                                Nombre = reader.GetString("nombre"),
                                FechaAplicacion = reader.GetDateTime("fecha_aplicacion"),
                                ProximaAplicacion = reader.GetDateTime("proxima_aplicacion"),
                            });
                        }
                    }
                }
            }
            return vacunas;
        }

        public void Actualizar(Vacuna vacuna)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Vacuna SET id_mascota = @id_mascota, nombre = @nombre, fecha_aplicacion = @fecha_aplicacion, proxima_aplicacion = @proxima_aplicacion WHERE id_vacuna = @id_vacuna";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_vacuna", vacuna.IdVacuna);
                    command.Parameters.AddWithValue("@id_mascota", vacuna.IdMascota);
                    command.Parameters.AddWithValue("@nombre", vacuna.Nombre);
                    command.Parameters.AddWithValue("@fecha_aplicacion", vacuna.FechaAplicacion);
                    command.Parameters.AddWithValue("@proxima_aplicacion", vacuna.ProximaAplicacion);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idVacuna)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Vacuna WHERE id_vacuna = @id_vacuna";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_vacuna", idVacuna);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
