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
using System.Data;

namespace proyectoVeterinaria
{
    public partial class VistaCitas : Form
    {
        private CitaNegocio citaNegocio = new CitaNegocio();
        public VistaCitas()
        {
            InitializeComponent();
            CargarCitas();
        }
        private void CargarCitas()
        {
            DataTable citas = citaNegocio.ObtenerCitas();
            dgvCitas.DataSource = citas;

            if (dgvCitas.Columns["IdCita"] != null)
                dgvCitas.Columns["IdCita"].HeaderText = "ID Cita";
            if (dgvCitas.Columns["FechaCita"] != null)
                dgvCitas.Columns["FechaCita"].HeaderText = "Fecha";
            if (dgvCitas.Columns["Motivo"] != null)
                dgvCitas.Columns["Motivo"].HeaderText = "Motivo";
            if (dgvCitas.Columns["NombreMascota"] != null)
                dgvCitas.Columns["NombreMascota"].HeaderText = "Mascota";
            if (dgvCitas.Columns["NombreCliente"] != null)
                dgvCitas.Columns["NombreCliente"].HeaderText = "Cliente";
            if (dgvCitas.Columns["NombreVeterinario"] != null)
                dgvCitas.Columns["NombreVeterinario"].HeaderText = "Veterinario";
            if (dgvCitas.Columns["Horario"] != null)
                dgvCitas.Columns["Horario"].HeaderText = "Horario";
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro de citas
            RegistrarCita registrarCita = new RegistrarCita();
            if (registrarCita.ShowDialog() == DialogResult.OK)
            {
                // Recarga las citas después de agregar una nueva
                CargarCitas();
            }
        }
    }
}
