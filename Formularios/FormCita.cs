using System;
using System.Windows.Forms;
using VeterinariaCatDog.CRUD;
using VeterinariaCatDog.Modelos;

namespace VeterinariaCatDog.Formularios
{
    public partial class FormCita : Form
    {
        private CitaCRUD citaCRUD;

        public FormCita()
        {
            InitializeComponent();
            citaCRUD = new CitaCRUD(); // Inicializa tu clase CRUD aquí
            HabilitarBotonesIniciales(); // Llama a la función para establecer el estado inicial de los botones
        }

        private void HabilitarBotonesIniciales()
        {
            // Habilitar solo el botón de Buscar y Regresar al inicio
            buttonAgregar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonRegresar.Enabled = true;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Habilitar los botones Agregar, Modificar y Eliminar
            buttonAgregar.Enabled = true;
            buttonModificar.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Deshabilitar todos los botones excepto Regresar
            DeshabilitarBotones();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Deshabilitar todos los botones excepto Regresar
            DeshabilitarBotones();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Deshabilitar todos los botones excepto Regresar
            DeshabilitarBotones();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            // Habilitar todos los botones después de regresar
            HabilitarBotonesIniciales();
        }

        private void DeshabilitarBotones()
        {
            buttonAgregar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonRegresar.Enabled = true; // Siempre habilitado
        }
    }
}
