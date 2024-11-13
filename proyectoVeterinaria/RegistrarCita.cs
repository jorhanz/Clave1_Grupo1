using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace proyectoVeterinaria
{
    public partial class RegistrarCita : Form
    {
        public RegistrarCita()
        {
            InitializeComponent();
        }

        private void RegistrarCita_Load(object sender, EventArgs e)
        {
            // Cargar Clientes
            CitaNegocio citaNegocio = new CitaNegocio();
            cmbCliente.DataSource = citaNegocio.ObtenerClientes(); // Método para obtener clientes
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "IdUsuario";

            // Cargar Veterinarios
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            cmbVeterinario.DataSource = usuarioNegocio.ObtenerVeterinarios(); // Método para obtener veterinarios
            cmbVeterinario.DisplayMember = "NombreCompleto";
            cmbVeterinario.ValueMember = "IdUsuario";

            // Configurar eventos para cambios en cliente y veterinario
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            cmbVeterinario.SelectedIndexChanged += cmbVeterinario_SelectedIndexChanged;
            dtpFechaCita.ValueChanged += dtpFechaCita_ValueChanged;
        }
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null)
            {
                int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);

                // Llama al método de negocio para obtener las mascotas del cliente
                CitaNegocio citaNegocio = new CitaNegocio();
                DataTable mascotas = citaNegocio.ObtenerMascotasPorCliente(idCliente);

                // Asigna las mascotas obtenidas al ComboBox de mascotas
                cmbMascota.DataSource = mascotas;
                cmbMascota.DisplayMember = "NombreMascota";
                cmbMascota.ValueMember = "IdMascota";
            }
        }
        private void cmbVeterinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHorariosDisponibles();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            CargarHorariosDisponibles();
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            int idMascota = (int)cmbMascota.SelectedValue;
            int idCliente = (int)cmbCliente.SelectedValue;
            int idVeterinario = (int)cmbVeterinario.SelectedValue;
            int idHorario = (int)cmbHorario.SelectedValue;
            DateTime fechaCita = dtpFechaCita.Value;
            string motivo = txtMotivo.Text;

            CitaNegocio citaNegocio = new CitaNegocio();
            bool resultado = citaNegocio.RegistrarCita(idMascota, idCliente, idVeterinario, fechaCita, idHorario, motivo);

            if (resultado)
            {
                MessageBox.Show("Cita registrada exitosamente.");
                //limpiar campos o cerrar formulario
            }
            else
            {
                MessageBox.Show("Error al registrar la cita.");
            }
        }
        private void CargarHorariosDisponibles()
        {
            Console.WriteLine("CargarHorariosDisponibles llamado");

            if (cmbVeterinario.SelectedValue != null && dtpFechaCita.Value != null)
            {
                int idVeterinario = Convert.ToInt32(cmbVeterinario.SelectedValue);
                string diaSemana = dtpFechaCita.Value.DayOfWeek.ToString();

                CitaNegocio citaNegocio = new CitaNegocio();
                DataTable horarios = citaNegocio.ObtenerHorariosDisponibles(idVeterinario, diaSemana);

                cmbHorario.DataSource = horarios;
                cmbHorario.DisplayMember = "HoraInicio"; // Puedes cambiarlo a "Hora" o una combinación de inicio y fin si quieres
                cmbHorario.ValueMember = "IdHorario";
            }
        }

    }
}
