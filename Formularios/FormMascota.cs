using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace VeterinariaCatDog.Formularios
{
    public partial class FormMascota : Form
    {
        //Para enlazarlo con el modulo Database
        private ConexionDBVeterinaria ConexionDBV;


        public FormMascota()
        {
            InitializeComponent();
            ConexionDBV = new ConexionDBVeterinaria();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
          

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var formRegistro = new FormRegistroMascota())
                {
                    var resultado = formRegistro.ShowDialog();

                   if (resultado == DialogResult.OK)
                   {
                     Mascota nuevaMascota = formRegistro.MascotaNueva;

                        // Aquí puedes procesar la nueva mascota, por ejemplo, agregarla a la base de datos o a una lista
                        MessageBox.Show($"Mascota {nuevaMascota.Nombre} registrada con éxito.");
                   }
                    else
                    {
                        MessageBox.Show("El registro de mascota fue cancelado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                ConexionDBV.CerrarConexionDelServer();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
