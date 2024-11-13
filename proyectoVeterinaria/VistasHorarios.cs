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
    public partial class VistasHorarios : Form
    {
        public VistasHorarios()
        {
            InitializeComponent();
        }
        private void CargarHorarios()
        {
            HorarioNegocio horarioNegocio = new HorarioNegocio();
            dgvHorarios.DataSource = horarioNegocio.ObtenerHorarios();

            // Configurar los encabezados de las columnas
            dgvHorarios.Columns["IdHorario"].HeaderText = "ID Horario";
            dgvHorarios.Columns["DiaSemana"].HeaderText = "Día";
            dgvHorarios.Columns["HoraInicio"].HeaderText = "Hora Inicio";
            dgvHorarios.Columns["HoraFin"].HeaderText = "Hora Fin";
            dgvHorarios.Columns["NombreVeterinario"].HeaderText = "Veterinario";
        }
        private void VistasHorarios_Load(object sender, EventArgs e)
        {
            CargarHorarios(); // Llamada al método para cargar los horarios
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            AgregarHorario agregarHorarioForm = new AgregarHorario();
            agregarHorarioForm.ShowDialog();
            CargarHorarios();
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.SelectedRows.Count > 0)
            {
                int idHorario = Convert.ToInt32(dgvHorarios.SelectedRows[0].Cells["IdHorario"].Value);

                HorarioNegocio horarioNegocio = new HorarioNegocio();
                bool eliminado = horarioNegocio.EliminarHorario(idHorario);

                if (eliminado)
                {
                    MessageBox.Show("Horario eliminado exitosamente.");
                    CargarHorarios(); // Refresca el listado de horarios
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el horario. Intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un horario para eliminar.");
            }
        }
    }
}
