using MySql.Data.MySqlClient;
using System;

namespace VeterinariaCatDog
{
    public static class Database
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Database=CatDogDB;Uid=root;Pwd=P@ssw0rdT3st!;";

            try
            {
                var connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                throw;
            }
        }
    }
}
