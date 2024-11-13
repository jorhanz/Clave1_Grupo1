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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }
        // Constructor personalizado que acepta los datos del usuario
        private int idUsuario;

        public EditarUsuario(int idUsuario, string nombreCompleto, string correo, string clave, int idRol)
        {
            InitializeComponent();

            // Asignar los valores del formulario
            this.idUsuario = idUsuario;
            txtNombreCompleto.Text = nombreCompleto;
            txtCorreo.Text = correo;
            txtClave.Text = clave;
            cmbRol.SelectedValue = idRol; 
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new Conexion().GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT IdRol, NombreRol FROM Roles", conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable roles = new DataTable();
                roles.Load(reader);

                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "NombreRol"; // Mostrar el nombre del rol en el ComboBox
                cmbRol.ValueMember = "IdRol"; // Usar el ID del rol como valor del ComboBox
            }

            // Seleccionar el rol actual del usuario
            cmbRol.SelectedValue = idUsuario;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            string nombreCompleto = txtNombreCompleto.Text;
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;
            int idRol = (int)cmbRol.SelectedValue;

            // Llamar al método para actualizar el usuario
            if (usuarioNegocio.ActualizarUsuario(idUsuario, nombreCompleto, correo, clave, idRol))
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
