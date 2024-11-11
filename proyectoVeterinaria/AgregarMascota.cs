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
            // Llama al método de la capa de negocio para obtener los propietarios
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            cmbPropietario.DataSource = usuarioNegocio.ObtenerPropietarios(); // Implementa este método para devolver los datos de los propietarios
            cmbPropietario.DisplayMember = "NombreCompleto";
            cmbPropietario.ValueMember = "IdUsuario";
        }

        private void btnGuardarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                MascotaNegocio mascotaNegocio = new MascotaNegocio();
                int idPropietario = (int)cmbPropietario.SelectedValue;
                string nombre = txtNombreMascota.Text;
                string especie = cmbEspecie.SelectedItem.ToString();
                string raza = txtRaza.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;

                bool resultado = mascotaNegocio.RegistrarMascota(idPropietario, nombre, especie, raza, fechaNacimiento);

                if (resultado)
                {
                    MessageBox.Show("Mascota registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cierra el formulario después de guardar
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
    }
}
