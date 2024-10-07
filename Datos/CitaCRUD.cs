using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;
using MySqlConnector;

namespace VeterinariaCatDog.CRUD
{
    
    public class CitaCRUD
    {
        private ConexionDBVeterinaria conexionDB;
        public void Agregar(Cita cita)
        {
            conexionDB = new ConexionDBVeterinaria();

            conexionDB.AbrirConexion();
            {
                conexionDB.AbrirConexion();
                var query = "INSERT INTO Cita (id_duenio, id_mascota, fecha, hora, motivo) VALUES (@id_duenio, @id_mascota, @fecha, @hora, @motivo)";
                using(MySqlCommand command = new MySqlCommand(query, conexionDB.GetConexion()))
                {
                    command.Parameters.AddWithValue("@id_duenio", cita.IdDuenio);
                    command.Parameters.AddWithValue("@id_mascota", cita.IdMascota);
                    command.Parameters.AddWithValue("@fecha", cita.Fecha);
                    command.Parameters.AddWithValue("@hora", cita.Hora);
                    command.Parameters.AddWithValue("@motivo", cita.Motivo);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal object BuscarCita(int idCita)
        {
            throw new NotImplementedException();
        }

        internal object ObtenerCitas()
        {
            throw new NotImplementedException();
        }

        public List<Cita> ObtenerTodos()
        {
            var citas = new List<Cita>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Cita";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            citas.Add(new Cita
                            {
                                IdCita = reader.GetInt32("id_cita"),
                                IdDuenio = reader.GetInt32("id_duenio"),
                                IdMascota = reader.GetInt32("id_mascota"),
                                Fecha = reader.GetDateTime("fecha"),
                                Hora = reader.GetTimeSpan("hora"),
                                Motivo = reader.GetString("motivo"),
                                Estado = reader.GetString("estado"),
                            });
                        }
                    }
                }
            }
            return citas;
        }

        internal void AgregarCita(Cita nuevaCita)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(Cita cita)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Cita SET id_duenio = @id_duenio, id_mascota = @id_mascota, fecha = @fecha, hora = @hora, motivo = @motivo, estado = @estado WHERE id_cita = @id_cita";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_cita", cita.IdCita);
                    command.Parameters.AddWithValue("@id_duenio", cita.IdDuenio);
                    command.Parameters.AddWithValue("@id_mascota", cita.IdMascota);
                    command.Parameters.AddWithValue("@fecha", cita.Fecha);
                    command.Parameters.AddWithValue("@hora", cita.Hora);
                    command.Parameters.AddWithValue("@motivo", cita.Motivo);
                    command.Parameters.AddWithValue("@estado", cita.Estado);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void EliminarCita(int idCita)
        {
            throw new NotImplementedException();
        }

        internal void ModificarCita(object citaExistente)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int idCita)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Cita WHERE id_cita = @id_cita";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_cita", idCita);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
