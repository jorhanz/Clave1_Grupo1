using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace proyectoVeterinaria
{
    public partial class AgregarMascota : Form
    {
        public AgregarMascota()
        {
            InitializeComponent();
        }

        private void AgregarMascota_Load(object sender, EventArgs e)
        {
            // Obtener los propietarios que son clientes desde la capa de negocio
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            cmbPropietario.DataSource = usuarioNegocio.ObtenerClientes();
            cmbPropietario.DisplayMember = "NombreCompleto"; // Nombre a mostrar
            cmbPropietario.ValueMember = "IdUsuario"; // Valor a guardar (IdUsuario)
            // Obtener las especies desde la capa de negocio
            MascotaNegocio mascotaNegocio = new MascotaNegocio();
            cmbEspecie.DataSource = mascotaNegocio.ObtenerEspecies();
            cmbEspecie.DisplayMember = "NombreEspecie"; // Nombre a mostrar
            cmbEspecie.ValueMember = "IdEspecie"; // Valor a guardar (IdEspecie)
        }

        private void btnGuardarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                MascotaNegocio mascotaNegocio = new MascotaNegocio();
                int idPropietario = (int)cmbPropietario.SelectedValue;
                string nombre = txtNombreMascota.Text;
                int idEspecie = (int)cmbEspecie.SelectedValue; // Obtener el IdEspecie desde el ComboBox
                string raza = txtRaza.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;

                // Enviar todos los datos, incluido IdEspecie, para registrar la mascota
                bool resultado = mascotaNegocio.RegistrarMascota(idPropietario, nombre, idEspecie, raza, fechaNacimiento);

                if (resultado)
                {
                    MessageBox.Show("Mascota registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
