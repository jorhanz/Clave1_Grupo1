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
        //public int IdMascota { get; set; }
        private int idMascota;
        public RegistroExpediente(int idMascota)
        {
            InitializeComponent();
            this.idMascota = idMascota;
        }
        public RegistroExpediente()
        {
            InitializeComponent();
        }
        public void CargarHistorial(int idMascota)
        {
            ExpedienteNegocio expedienteNegocio = new ExpedienteNegocio();
            DataTable historial = expedienteNegocio.ObtenerHistorialPorMascota(idMascota);
            dgvHistorialExpediente.DataSource = historial;

            // Configura los encabezados de las columnas si es necesario
            dgvHistorialExpediente.Columns["FechaConsulta"].HeaderText = "Fecha de Consulta";
            dgvHistorialExpediente.Columns["Descripcion"].HeaderText = "Descripción";
            dgvHistorialExpediente.Columns["IdVeterinario"].HeaderText = "Veterinario";
        }

        private void btnGuardarExpediente_Click(object sender, EventArgs e)
        {
            DateTime fechaConsulta = dtpFechaConsulta.Value;
            string descripcion = txtDescripcion.Text;
            int idVeterinario = Convert.ToInt32(cmbVeterinario.SelectedValue);

            // Crear una instancia de la capa de negocio y llamar al método para guardar el expediente
            ExpedienteNegocio expedienteNegocio = new ExpedienteNegocio();
            bool guardado = expedienteNegocio.GuardarExpediente(this.idMascota, fechaConsulta, descripcion, idVeterinario);

            if (guardado)
            {
                MessageBox.Show("Registro guardado exitosamente.");
                // Puedes recargar el historial clínico o cerrar el formulario si deseas
            }
            else
            {
                MessageBox.Show("Error al guardar el registro.");
            }
        }

        private void RegistroExpediente_Load(object sender, EventArgs e)
        {
            CargarHistorial(idMascota);
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            DataTable veterinarios = usuarioNegocio.ObtenerVeterinarios();

            cmbVeterinario.DataSource = veterinarios;
            cmbVeterinario.DisplayMember = "NombreCompleto";
            cmbVeterinario.ValueMember = "IdUsuario";
        }
    }
}
