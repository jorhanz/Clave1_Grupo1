
namespace proyectoVeterinaria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnRegistrarPagos = new System.Windows.Forms.Button();
            this.btnTarjetaDeVacunacion = new System.Windows.Forms.Button();
            this.btnHistoriaClinica = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(387, 89);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(111, 13);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido a Cat-Dog";
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(204, 148);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(143, 82);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.Text = "Citas medicas";
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPagos
            // 
            this.btnRegistrarPagos.Location = new System.Drawing.Point(390, 148);
            this.btnRegistrarPagos.Name = "btnRegistrarPagos";
            this.btnRegistrarPagos.Size = new System.Drawing.Size(143, 82);
            this.btnRegistrarPagos.TabIndex = 2;
            this.btnRegistrarPagos.Text = "Registrar pagos";
            this.btnRegistrarPagos.UseVisualStyleBackColor = true;
            // 
            // btnTarjetaDeVacunacion
            // 
            this.btnTarjetaDeVacunacion.Location = new System.Drawing.Point(204, 257);
            this.btnTarjetaDeVacunacion.Name = "btnTarjetaDeVacunacion";
            this.btnTarjetaDeVacunacion.Size = new System.Drawing.Size(143, 82);
            this.btnTarjetaDeVacunacion.TabIndex = 3;
            this.btnTarjetaDeVacunacion.Text = "Tarjeta de vacunacion";
            this.btnTarjetaDeVacunacion.UseVisualStyleBackColor = true;
            // 
            // btnHistoriaClinica
            // 
            this.btnHistoriaClinica.Location = new System.Drawing.Point(567, 148);
            this.btnHistoriaClinica.Name = "btnHistoriaClinica";
            this.btnHistoriaClinica.Size = new System.Drawing.Size(143, 82);
            this.btnHistoriaClinica.TabIndex = 4;
            this.btnHistoriaClinica.Text = "Historia clinica";
            this.btnHistoriaClinica.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(390, 257);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(143, 82);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.Location = new System.Drawing.Point(567, 257);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(143, 82);
            this.btnHorarios.TabIndex = 6;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(847, 12);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(93, 23);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(722, 17);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(119, 13);
            this.lblNombreDeUsuario.TabIndex = 8;
            this.lblNombreDeUsuario.Text = "Nombre de usuario aqui";
            // 
            // btnMascotas
            // 
            this.btnMascotas.Location = new System.Drawing.Point(204, 359);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(143, 82);
            this.btnMascotas.TabIndex = 9;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 541);
            this.Controls.Add(this.btnMascotas);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnHistoriaClinica);
            this.Controls.Add(this.btnTarjetaDeVacunacion);
            this.Controls.Add(this.btnRegistrarPagos);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnRegistrarPagos;
        private System.Windows.Forms.Button btnTarjetaDeVacunacion;
        private System.Windows.Forms.Button btnHistoriaClinica;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Button btnMascotas;
    }
}

