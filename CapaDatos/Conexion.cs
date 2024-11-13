using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CapaDatos
{
    public class Conexion
    {
        // Cadena de conexión a la base de datos
        public static string cadena = "Server=138.197.126.211;Database=veterinaria;User=usuarioC;Password=nuevaContra@1;";

        // Método para obtener la conexión
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(cadena);
        }
        public bool ProbarConexion()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadena))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar: " + ex.Message);
                    return false;
                }
            }
        }
    }
 
}
