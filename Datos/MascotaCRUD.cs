using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.CRUD
{
    public class MascotaCRUD
    {
        public void Agregar(Mascota mascota)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Mascota (id_duenio, nombre, especie, raza, fecha_nacimiento) VALUES (@id_duenio, @nombre, @especie, @raza, @fecha_nacimiento)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_duenio", mascota.IdDuenio);
                    command.Parameters.AddWithValue("@nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@especie", mascota.Especie);
                    command.Parameters.AddWithValue("@raza", mascota.Raza);
                    command.Parameters.AddWithValue("@fecha_nacimiento", mascota.FechaNacimiento);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Mascota> ObtenerTodos()
        {
            var mascotas = new List<Mascota>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Mascota";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mascotas.Add(new Mascota
                            {
                                IdMascota = reader.GetInt32("id_mascota"),
                                IdDuenio = reader.GetInt32("id_duenio"),
                                Nombre = reader.GetString("nombre"),
                                Especie = reader.GetString("especie"),
                                Raza = reader.IsDBNull(reader.GetOrdinal("raza")) ? null : reader.GetString("raza"),
                                FechaNacimiento = reader.GetDateTime("fecha_nacimiento"),
                            });
                        }
                    }
                }
            }
            return mascotas;
        }

        public void Actualizar(Mascota mascota)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Mascota SET id_duenio = @id_duenio, nombre = @nombre, especie = @especie, raza = @raza, fecha_nacimiento = @fecha_nacimiento WHERE id_mascota = @id_mascota";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_mascota", mascota.IdMascota);
                    command.Parameters.AddWithValue("@id_duenio", mascota.IdDuenio);
                    command.Parameters.AddWithValue("@nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@especie", mascota.Especie);
                    command.Parameters.AddWithValue("@raza", mascota.Raza);
                    command.Parameters.AddWithValue("@fecha_nacimiento", mascota.FechaNacimiento);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idMascota)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Mascota WHERE id_mascota = @id_mascota";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_mascota", idMascota);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
