using MySqlConnector;
using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.CRUD
{
    public class MascotaCRUD
    {
        private readonly MySqlConnection _connection;

        // Constructor que recibe una conexión
        public MascotaCRUD(MySqlConnection connection)
        {
            _connection = connection;
        }

        public bool Agregar(Mascota mascota)
        {
            try
            {
                // Abrir la conexión si está cerrada
                if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();

                // Iniciar una transacción para asegurar que todas las operaciones sean atómicas
                using (var transaction = _connection.BeginTransaction())
                {
                    string query = @"INSERT INTO Mascota (id_duenio, nombre, especie, raza, fecha_nacimiento) 
                                     VALUES (@id_duenio, @nombre, @especie, @raza, @fecha_nacimiento)";

                    using (var command = new MySqlCommand(query, _connection, transaction))
                    {
                        // Parámetros del comando
                        command.Parameters.AddWithValue("@id_duenio", mascota.IdDuenio);
                        command.Parameters.AddWithValue("@nombre", mascota.Nombre);
                        command.Parameters.AddWithValue("@especie", mascota.Especie);
                        command.Parameters.AddWithValue("@raza", mascota.Raza);
                        command.Parameters.AddWithValue("@fecha_nacimiento", mascota.FechaNacimiento);

                        command.ExecuteNonQuery();
                    }

                    // Confirmar transacción
                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y reportarla
                Console.WriteLine("Error al agregar la mascota: " + ex.Message);
                return false;
            }
            finally
            {
                // Cerrar la conexión
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        public List<Mascota> ObtenerTodos()
        {
            var mascotas = new List<Mascota>();

            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT * FROM Mascota";

                using (var command = new MySqlCommand(query, _connection))
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
                                FechaNacimiento = reader.GetDateTime("fecha_nacimiento")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las mascotas: " + ex.Message);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }

            return mascotas;
        }

        public bool Actualizar(Mascota mascota)
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();

                using (var transaction = _connection.BeginTransaction())
                {
                    string query = @"UPDATE Mascota 
                                     SET id_duenio = @id_duenio, nombre = @nombre, especie = @especie, 
                                         raza = @raza, fecha_nacimiento = @fecha_nacimiento
                                     WHERE id_mascota = @id_mascota";

                    using (var command = new MySqlCommand(query, _connection, transaction))
                    {
                        command.Parameters.AddWithValue("@id_mascota", mascota.IdMascota);
                        command.Parameters.AddWithValue("@id_duenio", mascota.IdDuenio);
                        command.Parameters.AddWithValue("@nombre", mascota.Nombre);
                        command.Parameters.AddWithValue("@especie", mascota.Especie);
                        command.Parameters.AddWithValue("@raza", mascota.Raza);
                        command.Parameters.AddWithValue("@fecha_nacimiento", mascota.FechaNacimiento);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la mascota: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        public bool Eliminar(int idMascota)
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();

                using (var transaction = _connection.BeginTransaction())
                {
                    string query = "DELETE FROM Mascota WHERE id_mascota = @id_mascota";

                    using (var command = new MySqlCommand(query, _connection, transaction))
                    {
                        command.Parameters.AddWithValue("@id_mascota", idMascota);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la mascota: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}
