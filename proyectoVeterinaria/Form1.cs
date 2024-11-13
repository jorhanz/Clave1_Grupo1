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
using proyectoVeterinaria;

namespace proyectoVeterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapaDatos.Conexion conexion = new CapaDatos.Conexion();
            if (conexion.ProbarConexion())
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos.");
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            VistaUsuarios vistaUsuariosForm = new VistaUsuarios();

            
            vistaUsuariosForm.Show();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            VistaMascotas vistaMascotas = new VistaMascotas();
            vistaMascotas.ShowDialog();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            VistasHorarios vistasHorarios = new VistasHorarios();
            vistasHorarios.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            VistaCitas vistaCitas = new VistaCitas();
            vistaCitas.ShowDialog();

        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            VistaExpediente vistaExpediente = new VistaExpediente();
            vistaExpediente.ShowDialog();
        }
    }
}
