using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.CRUD
{
    public class DuenioCRUD
    {
        public void Agregar(Duenio duenio)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Duenio (nombre, direccion, telefono, email) VALUES (@nombre, @direccion, @telefono, @email)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", duenio.Nombre);
                    command.Parameters.AddWithValue("@direccion", duenio.Direccion);
                    command.Parameters.AddWithValue("@telefono", duenio.Telefono);
                    command.Parameters.AddWithValue("@email", duenio.Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Duenio> ObtenerTodos()
        {
            var duenios = new List<Duenio>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Duenio";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            duenios.Add(new Duenio
                            {
                                IdDuenio = reader.GetInt32("id_duenio"),
                                Nombre = reader.GetString("nombre"),
                                Direccion = reader.IsDBNull(reader.GetOrdinal("direccion")) ? null : reader.GetString("direccion"),
                                Telefono = reader.GetString("telefono"),
                                Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                            });
                        }
                    }
                }
            }
            return duenios;
        }

        public void Actualizar(Duenio duenio)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Duenio SET nombre = @nombre, direccion = @direccion, telefono = @telefono, email = @email WHERE id_duenio = @id_duenio";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_duenio", duenio.IdDuenio);
                    command.Parameters.AddWithValue("@nombre", duenio.Nombre);
                    command.Parameters.AddWithValue("@direccion", duenio.Direccion);
                    command.Parameters.AddWithValue("@telefono", duenio.Telefono);
                    command.Parameters.AddWithValue("@email", duenio.Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idDuenio)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Duenio WHERE id_duenio = @id_duenio";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_duenio", idDuenio);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
