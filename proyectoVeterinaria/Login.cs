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

namespace proyectoVeterinaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;

            if (usuarioNegocio.LoginUsuario(correo, clave))
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario principal y cerrar el formulario de inicio de sesión
                Form1 menuPrincipal = new Form1();
                menuPrincipal.Show();
                this.Hide(); // Oculta el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
