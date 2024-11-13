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
    public partial class AgregarHorario : Form
    {
        public AgregarHorario()
        {
            InitializeComponent();
        }

        private void AgregarHorario_Load(object sender, EventArgs e)
        {
            //CheckedListBox con los días de la semana
            checkedListBoxDias.Items.Add("Lunes");
            checkedListBoxDias.Items.Add("Martes");
            checkedListBoxDias.Items.Add("Miércoles");
            checkedListBoxDias.Items.Add("Jueves");
            checkedListBoxDias.Items.Add("Viernes");
            checkedListBoxDias.Items.Add("Sábado");
            checkedListBoxDias.Items.Add("Domingo");

            // Cargar veterinarios en el ComboBox
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            cmbVeterinario.DataSource = usuarioNegocio.ObtenerVeterinarios();
            cmbVeterinario.DisplayMember = "NombreCompleto";
            cmbVeterinario.ValueMember = "IdUsuario";

        }

        private void btnGuardarHorario_Click(object sender, EventArgs e)
        {
            // Obtener la hora de inicio y fin seleccionada
            TimeSpan horaInicio = timePickerInicio.Value.TimeOfDay;
            TimeSpan horaFin = timePickerFin.Value.TimeOfDay;

            // Obtener el Id del veterinario seleccionado en el ComboBox
            int idVeterinario = Convert.ToInt32(cmbVeterinario.SelectedValue);

            // Validar que al menos un día esté seleccionado
            if (checkedListBoxDias.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos un día.");
                return;
            }
            HorarioNegocio horarioNegocio = new HorarioNegocio();
            // Recorrer los días seleccionados y guardar cada uno
            foreach (string dia in checkedListBoxDias.CheckedItems)
            {
                bool guardado = horarioNegocio.RegistrarHorario(dia, horaInicio, horaFin, idVeterinario);

                if (guardado)
                {
                    MessageBox.Show($"Horario para {dia} guardado exitosamente.");
                }
                else
                {
                    MessageBox.Show($"Error al guardar el horario para {dia}.");
                }
            }

            // Limpiar los campos después de guardar
            checkedListBoxDias.ClearSelected();
            timePickerInicio.Value = DateTime.Now;
            timePickerFin.Value = DateTime.Now;
            cmbVeterinario.SelectedIndex = -1;
        }
    }
        
    
}
