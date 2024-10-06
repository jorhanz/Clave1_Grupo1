using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.CRUD
{
    public class ProductoCRUD
    {
        public void Agregar(Producto producto)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Producto (nombre, descripcion, precio, stock) VALUES (@nombre, @descripcion, @precio, @stock)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                    command.Parameters.AddWithValue("@precio", producto.Precio);
                    command.Parameters.AddWithValue("@stock", producto.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Producto> ObtenerTodos()
        {
            var productos = new List<Producto>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Producto";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                IdProducto = reader.GetInt32("id_producto"),
                                Nombre = reader.GetString("nombre"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? null : reader.GetString("descripcion"),
                                Precio = reader.GetDecimal("precio"),
                                Stock = reader.GetInt32("stock"),
                            });
                        }
                    }
                }
            }
            return productos;
        }

        public void Actualizar(Producto producto)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Producto SET nombre = @nombre, descripcion = @descripcion, precio = @precio, stock = @stock WHERE id_producto = @id_producto";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_producto", producto.IdProducto);
                    command.Parameters.AddWithValue("@nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                    command.Parameters.AddWithValue("@precio", producto.Precio);
                    command.Parameters.AddWithValue("@stock", producto.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idProducto)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Producto WHERE id_producto = @id_producto";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_producto", idProducto);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
