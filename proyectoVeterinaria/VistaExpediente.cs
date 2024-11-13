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
    }
}
