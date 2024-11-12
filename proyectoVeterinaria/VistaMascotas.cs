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
    public partial class VistaMascotas : Form
    {
        private MascotaNegocio mascotaNegocio = new MascotaNegocio();
        public VistaMascotas()
        {
            InitializeComponent();
            CargarMascotas();
        }
        private void VistaMascotas_Load(object sender, EventArgs e)
        {
            
        }
        private void CargarMascotas()
        {
            dgvMascotas.DataSource = mascotaNegocio.ObtenerMascotas();

            if (dgvMascotas.Columns["IdMascota"] != null)
                dgvMascotas.Columns["IdMascota"].HeaderText = "ID Mascota";

            if (dgvMascotas.Columns["NombreMascota"] != null)
                dgvMascotas.Columns["NombreMascota"].HeaderText = "Nombre";

            if (dgvMascotas.Columns["Especie"] != null)
                dgvMascotas.Columns["Especie"].HeaderText = "Especie";

            if (dgvMascotas.Columns["Raza"] != null)
                dgvMascotas.Columns["Raza"].HeaderText = "Raza";

            if (dgvMascotas.Columns["FechaNacimiento"] != null)
                dgvMascotas.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";

            if (dgvMascotas.Columns["NombrePropietario"] != null)
                dgvMascotas.Columns["NombrePropietario"].HeaderText = "Propietario";
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            
            CargarMascotas(); // Recargar la lista de mascotas después de agregar
        }

        private void btnAgregarMascota_Click_1(object sender, EventArgs e)
        {
            AgregarMascota agregarMascotaForm = new AgregarMascota();
            agregarMascotaForm.ShowDialog();
            CargarMascotas(); // Actualiza la lista después de cerrar el formulario
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.SelectedRows.Count > 0)
            {
                // Obtener el ID de la mascota seleccionada
                int idMascota = Convert.ToInt32(dgvMascotas.SelectedRows[0].Cells["IdMascota"].Value);

                // Confirmación de eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta mascota?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    MascotaNegocio mascotaNegocio = new MascotaNegocio();
                    bool eliminado = mascotaNegocio.EliminarMascota(idMascota);

                    if (eliminado)
                    {
                        MessageBox.Show("Mascota eliminada correctamente.");
                        CargarMascotas(); // Recargar la lista de mascotas
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la mascota. Intenta nuevamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una mascota para eliminar.");
            }
        }
    }
}
