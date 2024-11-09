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
            RegistroUsuarios registroForm = new RegistroUsuarios();

            registroForm.Show();
        }
    }
}
