using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.CRUD
{
    public class ExpedienteCRUD
    {
        public void Agregar(Expediente expediente)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Expediente (id_mascota, detalles_consulta, fecha_consulta) VALUES (@id_mascota, @detalles_consulta, @fecha_consulta)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_mascota", expediente.IdMascota);
                    command.Parameters.AddWithValue("@detalles_consulta", expediente.DetallesConsulta);
                    command.Parameters.AddWithValue("@fecha_consulta", expediente.FechaConsulta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Expediente> ObtenerTodos()
        {
            var expedientes = new List<Expediente>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Expediente";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            expedientes.Add(new Expediente
                            {
                                IdExpediente = reader.GetInt32("id_expediente"),
                                IdMascota = reader.GetInt32("id_mascota"),
                                DetallesConsulta = reader.GetString("detalles_consulta"),
                                FechaConsulta = reader.GetDateTime("fecha_consulta"),
                            });
                        }
                    }
                }
            }
            return expedientes;
        }

        public void Actualizar(Expediente expediente)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Expediente SET id_mascota = @id_mascota, detalles_consulta = @detalles_consulta, fecha_consulta = @fecha_consulta WHERE id_expediente = @id_expediente";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_expediente", expediente.IdExpediente);
                    command.Parameters.AddWithValue("@id_mascota", expediente.IdMascota);
                    command.Parameters.AddWithValue("@detalles_consulta", expediente.DetallesConsulta);
                    command.Parameters.AddWithValue("@fecha_consulta", expediente.FechaConsulta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idExpediente)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Expediente WHERE id_expediente = @id_expediente";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_expediente", idExpediente);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
