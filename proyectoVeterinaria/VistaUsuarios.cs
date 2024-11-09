using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CapaDatos;

namespace proyectoVeterinaria
{
    public partial class VistaUsuarios : Form
    {
        public VistaUsuarios()
        {
            InitializeComponent();
        }

        private void VistaUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                using (MySqlConnection conexion = new Conexion().GetConnection())
                {
                    conexion.Open();
                    // Modificamos la consulta para obtener el NombreRol de la tabla Roles
                    string query = @"SELECT u.IdUsuario, u.NombreCompleto, u.Correo, r.NombreRol 
                             FROM Usuarios u
                             INNER JOIN Roles r ON u.IdRol = r.IdRol";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable usuarios = new DataTable();
                    adapter.Fill(usuarios);

                    dgvUsuarios.DataSource = usuarios;
                    dgvUsuarios.Columns["IdUsuario"].HeaderText = "ID";
                    dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
                    dgvUsuarios.Columns["Correo"].HeaderText = "Correo Electrónico";
                    dgvUsuarios.Columns["NombreRol"].HeaderText = "Rol";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            RegistroUsuarios registroForm = new RegistroUsuarios();

            // Mostrar el formulario de registro de usuarios como modal
            registroForm.ShowDialog();

            // Actualizar la lista de usuarios después de cerrar el formulario de registro
            CargarUsuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el IdUsuario del usuario seleccionado
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conexion = new Conexion().GetConnection())
                        {
                            conexion.Open();
                            string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
                            MySqlCommand cmd = new MySqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Usuario eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarUsuarios(); // Actualizar la lista de usuarios después de eliminar
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el usuario. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Seleccionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
