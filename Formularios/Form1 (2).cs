using System;
using System.Windows.Forms;
using VeterinariaCatDog.Modelos;

namespace Registro_De_Mascota
{
    public partial class FormRegistroMascota : Form
    {
        public Mascota MascotaNueva { get; private set; }

        public FormRegistroMascota()
        {
            InitializeComponent();
            CargarEspecies(); // Método para llenar el ComboBox con opciones
        }

        private void CargarEspecies()
        {
            // Añadir las opciones de especie al ComboBox
            cmbEspecieM.Items.Add("Perro");
            cmbEspecieM.Items.Add("Gato");
            cmbEspecieM.Items.Add("Otro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar si todos los campos están llenos
            if (string.IsNullOrWhiteSpace(txtIdMascota.Text) ||
                string.IsNullOrWhiteSpace(txtNombreM.Text) ||
                cmbEspecieM.SelectedItem == null || // Verificar si se seleccionó una especie
                string.IsNullOrWhiteSpace(txtRazaM.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                // Crear una nueva instancia de Mascota y llenar con los datos del formulario
                MascotaNueva = new Mascota
                {
                    IdMascota = int.Parse(txtIdMascota.Text),
                    Nombre = txtNombreM.Text,
                    Especie = cmbEspecieM.SelectedItem.ToString(),
                    Raza = txtRazaM.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value
                };

                // Cerrar el formulario y devolver los datos
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la mascota: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario si el usuario cancela la acción
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
