using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    public class UsuarioDatos
    {
        public bool InsertarUsuario(string nombreCompleto, string correo, string clave, int idRol)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Usuarios (NombreCompleto, Correo, Clave, IdRol) VALUES (@NombreCompleto, @Correo, @Clave, @IdRol)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Clave", clave); // En producción, considera encriptar la contraseña
                    cmd.Parameters.AddWithValue("@IdRol", idRol);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool VerificarCredenciales(string correo, string clave)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo AND Clave = @Clave";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public DataTable ObtenerClientes()
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                // Se coloca IdRol 3 ya que es el que corresponde a los usuarios tipo cliente
                string query = "SELECT IdUsuario, NombreCompleto FROM Usuarios WHERE IdRol = 3";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable clientes = new DataTable();
                adapter.Fill(clientes);
                return clientes;
            }
        }
    }
}
