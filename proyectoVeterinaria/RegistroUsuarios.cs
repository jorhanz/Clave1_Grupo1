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
using CapaNegocio;

namespace proyectoVeterinaria
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT IdRol, NombreRol FROM Roles", conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable roles = new DataTable();
                roles.Load(reader);

                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "IdRol";
            }
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                string nombreCompleto = txtNombreCompleto.Text;
                string correo = txtCorreo.Text;
                string clave = txtClave.Text;
                int idRol = (int)cmbRol.SelectedValue;

                if (usuarioNegocio.RegistrarUsuario(nombreCompleto, correo, clave, idRol))
                {
                    MessageBox.Show("Usuario registrado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardarUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                string nombreCompleto = txtNombreCompleto.Text;
                string correo = txtCorreo.Text;
                string clave = txtClave.Text;
                int idRol = (int)cmbRol.SelectedValue;

                // Intentar registrar el usuario
                if (usuarioNegocio.RegistrarUsuario(nombreCompleto, correo, clave, idRol))
                {
                    // Mostrar mensaje de confirmación
                    MessageBox.Show("Usuario registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar el formulario de registro después de mostrar el mensaje de éxito
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreCompleto.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtClave.Text = string.Empty;
            cmbRol.SelectedIndex = -1; // Desseleccionar el ComboBox
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
