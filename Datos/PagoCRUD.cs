using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.CRUD
{
    public class PagoCRUD
    {
        public void Agregar(Pago pago)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Pago (id_duenio, id_producto, id_cita, cantidad, total, tipo_pago, fecha_pago) VALUES (@id_duenio, @id_producto, @id_cita, @cantidad, @total, @tipo_pago, @fecha_pago)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_duenio", pago.IdDuenio);
                    command.Parameters.AddWithValue("@id_producto", (object)pago.IdProducto ?? DBNull.Value);
                    command.Parameters.AddWithValue("@id_cita", (object)pago.IdCita ?? DBNull.Value);
                    command.Parameters.AddWithValue("@cantidad", pago.Cantidad);
                    command.Parameters.AddWithValue("@total", pago.Total);
                    command.Parameters.AddWithValue("@tipo_pago", pago.TipoPago);
                    command.Parameters.AddWithValue("@fecha_pago", pago.FechaPago);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Pago> ObtenerTodos()
        {
            var pagos = new List<Pago>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Pago";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pagos.Add(new Pago
                            {
                                IdPago = reader.GetInt32("id_pago"),
                                IdDuenio = reader.GetInt32("id_duenio"),
                                IdProducto = reader.IsDBNull(reader.GetOrdinal("id_producto")) ? (int?)null : reader.GetInt32("id_producto"),
                                IdCita = reader.IsDBNull(reader.GetOrdinal("id_cita")) ? (int?)null : reader.GetInt32("id_cita"),
                                Cantidad = reader.GetInt32("cantidad"),
                                Total = reader.GetDecimal("total"),
                                TipoPago = reader.GetString("tipo_pago"),
                                FechaPago = reader.GetDateTime("fecha_pago"),
                            });
                        }
                    }
                }
            }
            return pagos;
        }

        public void Actualizar(Pago pago)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Pago SET id_duenio = @id_duenio, id_producto = @id_producto, id_cita = @id_cita, cantidad = @cantidad, total = @total, tipo_pago = @tipo_pago, fecha_pago = @fecha_pago WHERE id_pago = @id_pago";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_pago", pago.IdPago);
                    command.Parameters.AddWithValue("@id_duenio", pago.IdDuenio);
                    command.Parameters.AddWithValue("@id_producto", (object)pago.IdProducto ?? DBNull.Value);
                    command.Parameters.AddWithValue("@id_cita", (object)pago.IdCita ?? DBNull.Value);
                    command.Parameters.AddWithValue("@cantidad", pago.Cantidad);
                    command.Parameters.AddWithValue("@total", pago.Total);
                    command.Parameters.AddWithValue("@tipo_pago", pago.TipoPago);
                    command.Parameters.AddWithValue("@fecha_pago", pago.FechaPago);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idPago)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Pago WHERE id_pago = @id_pago";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_pago", idPago);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
