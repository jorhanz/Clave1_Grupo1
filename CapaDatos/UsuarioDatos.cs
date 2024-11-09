using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;

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
    }
}
