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
    public partial class RegistroExpediente : Form
    {
        public int IdMascota { get; set; }
        public RegistroExpediente()
        {
            InitializeComponent();
        }
        public void CargarHistorial(int idMascota)
        {
            ExpedienteNegocio expedienteNegocio = new ExpedienteNegocio();
            DataTable historial = expedienteNegocio.ObtenerHistorialPorMascota(idMascota);
            dgvHistorialExpediente.DataSource = historial;

            // Configurar encabezados de las columnas
            dgvHistorialExpediente.Columns["FechaConsulta"].HeaderText = "Fecha de Consulta";
            dgvHistorialExpediente.Columns["Descripcion"].HeaderText = "Descripción";
            dgvHistorialExpediente.Columns["NombreVeterinario"].HeaderText = "Veterinario";
        }

        private void btnGuardarExpediente_Click(object sender, EventArgs e)
        {
            DateTime fechaConsulta = dtpFechaConsulta.Value;
            string descripcion = txtDescripcion.Text;
            int idVeterinario = Convert.ToInt32(cmbVeterinario.SelectedValue);
            int idMascota = this.IdMascota;
            ExpedienteNegocio expedienteNegocio = new ExpedienteNegocio();
            bool guardado = expedienteNegocio.GuardarExpediente(idMascota, fechaConsulta, descripcion, idVeterinario);
            if (guardado)
            {
                MessageBox.Show("Registro guardado exitosamente.");
                CargarHistorial(idMascota); 
            }
            else
            {
                MessageBox.Show("Error al guardar el registro.");
            }
        }
    }
}
