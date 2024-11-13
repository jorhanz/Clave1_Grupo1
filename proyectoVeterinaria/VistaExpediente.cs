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
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dgvMascotas.SelectedRows.Count > 0)
            {
                // Obtén el idMascota de la fila seleccionada
                int idMascota = Convert.ToInt32(dgvMascotas.SelectedRows[0].Cells["IdMascota"].Value);

                // Pasa el idMascota al formulario RegistroExpediente
                RegistroExpediente registroExpediente = new RegistroExpediente(idMascota);
                registroExpediente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una mascota de la lista.");
            }
        }
    }
}
