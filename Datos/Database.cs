using System;
using MySqlConnector;

namespace VeterinariaCatDog
{
    public class ConexionDBVeterinaria
    {
        private MySqlConnection connection;
        //El constructor que inicia la conexion con el server de la base de datos
        public ConexionDBVeterinaria()
        {
            //String de la conexion
            //En su codigo, podrian cambiar el user y la password por su usuario y contraseña 
            string connexionString = "Server=138.197.126.211; Database=veterinaria; User ID=federick; Password=federickBase; Port=3306";
            connection = new MySqlConnection(connexionString);
        }

        //Como su nombre lo indica, abre la conexion al server xd
        public void AbrirConexion()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Conexión abierta.\n La conexion ha sido exitosa");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void CerrarConexionDelServer()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }

        // Método para obtener la conexión actual
        public MySqlConnection GetConexion()
        {
            return connection;
        }
    }
}
