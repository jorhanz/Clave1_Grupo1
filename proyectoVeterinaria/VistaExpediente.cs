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
using CapaDatos;

namespace proyectoVeterinaria
{
    public partial class VistaExpediente : Form
    {
        public VistaExpediente()
        {
            InitializeComponent();
        }
        private void CargarMascotas()
        {
            MascotaNegocio mascotaNegocio = new MascotaNegocio();
            DataTable mascotas = mascotaNegocio.ObtenerMascotas();
            dgvMascotas.DataSource = mascotas;

            // Configurar los encabezados de las columnas en el DataGridView
            dgvMascotas.Columns["IdMascota"].HeaderText = "ID";
            dgvMascotas.Columns["NombreMascota"].HeaderText = "Nombre";
            dgvMascotas.Columns["Especie"].HeaderText = "Especie";
            dgvMascotas.Columns["Raza"].HeaderText = "Raza";
            dgvMascotas.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvMascotas.Columns["Propietario"].HeaderText = "Propietario";
        }

        private void VistaExpediente_Load(object sender, EventArgs e)
        {
            CargarMascotas();
        }

        private void btnAgregarExpediente_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.SelectedRows.Count > 0)
            {
                int idMascota = Convert.ToInt32(dgvMascotas.SelectedRows[0].Cells["IdMascota"].Value);

                // Abrir el formulario de registro de expediente
                RegistroExpediente registroExpediente = new RegistroExpediente();
                registroExpediente.CargarHistorial(idMascota); // Cargar historial de la mascota seleccionada
                registroExpediente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una mascota de la lista.");
            }
        }
    }
}
