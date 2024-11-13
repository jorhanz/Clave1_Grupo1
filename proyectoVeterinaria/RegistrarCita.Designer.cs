
namespace proyectoVeterinaria
{
    partial class RegistrarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRaza = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistrarMascota = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCita = new System.Windows.Forms.Button();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbMascota = new System.Windows.Forms.ComboBox();
            this.cmbVeterinario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(265, 151);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(48, 13);
            this.lblRaza.TabIndex = 38;
            this.lblRaza.Text = "Mascota";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(197, 268);
            this.dtpFechaCita.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(179, 20);
            this.dtpFechaCita.TabIndex = 36;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(196, 114);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(179, 21);
            this.cmbCliente.TabIndex = 35;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(259, 305);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 13);
            this.lblRol.TabIndex = 34;
            this.lblRol.Text = "Horario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(242, 253);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(72, 13);
            this.lblContra.TabIndex = 33;
            this.lblContra.Text = "Fecha de cita";
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Location = new System.Drawing.Point(265, 202);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(57, 13);
            this.lblVeterinario.TabIndex = 32;
            this.lblVeterinario.Text = "Veterinario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(277, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(39, 13);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Cliente";
            // 
            // lblRegistrarMascota
            // 
            this.lblRegistrarMascota.AutoSize = true;
            this.lblRegistrarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarMascota.Location = new System.Drawing.Point(171, 47);
            this.lblRegistrarMascota.Name = "lblRegistrarMascota";
            this.lblRegistrarMascota.Size = new System.Drawing.Size(234, 33);
            this.lblRegistrarMascota.TabIndex = 30;
            this.lblRegistrarMascota.Text = "Registro de cita";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(300, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarCita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCita.Location = new System.Drawing.Point(198, 430);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCita.TabIndex = 28;
            this.btnGuardarCita.Text = "Guardar";
            this.btnGuardarCita.UseVisualStyleBackColor = false;
            this.btnGuardarCita.Click += new System.EventHandler(this.btnGuardarCita_Click);
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(196, 321);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(179, 21);
            this.cmbHorario.TabIndex = 27;
            // 
            // cmbMascota
            // 
            this.cmbMascota.FormattingEnabled = true;
            this.cmbMascota.Location = new System.Drawing.Point(196, 167);
            this.cmbMascota.Name = "cmbMascota";
            this.cmbMascota.Size = new System.Drawing.Size(179, 21);
            this.cmbMascota.TabIndex = 39;
            // 
            // cmbVeterinario
            // 
            this.cmbVeterinario.FormattingEnabled = true;
            this.cmbVeterinario.Location = new System.Drawing.Point(196, 218);
            this.cmbVeterinario.Name = "cmbVeterinario";
            this.cmbVeterinario.Size = new System.Drawing.Size(179, 21);
            this.cmbVeterinario.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Motivo";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(196, 374);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(179, 20);
            this.txtMotivo.TabIndex = 42;
            // 
            // RegistrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 497);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVeterinario);
            this.Controls.Add(this.cmbMascota);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblVeterinario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRegistrarMascota);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCita);
            this.Controls.Add(this.cmbHorario);
            this.Name = "RegistrarCita";
            this.Text = "RegistrarCita";
            this.Load += new System.EventHandler(this.RegistrarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistrarMascota;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCita;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.ComboBox cmbMascota;
        private System.Windows.Forms.ComboBox cmbVeterinario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivo;
    }
}