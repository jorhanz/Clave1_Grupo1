
namespace proyectoVeterinaria
{
    partial class AgregarMascota
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
            this.lblRol = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistrarMascota = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarMascota = new System.Windows.Forms.Button();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(308, 364);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(77, 17);
            this.lblRol.TabIndex = 21;
            this.lblRol.Text = "Propietario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(276, 294);
            this.lblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(139, 17);
            this.lblContra.TabIndex = 20;
            this.lblContra.Text = "Fecha de nacimiento";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(312, 160);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(58, 17);
            this.lblEspecie.TabIndex = 19;
            this.lblEspecie.Text = "Especie";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(276, 98);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(150, 17);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre de la mascota";
            // 
            // lblRegistrarMascota
            // 
            this.lblRegistrarMascota.AutoSize = true;
            this.lblRegistrarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarMascota.Location = new System.Drawing.Point(143, 33);
            this.lblRegistrarMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarMascota.Name = "lblRegistrarMascota";
            this.lblRegistrarMascota.Size = new System.Drawing.Size(379, 42);
            this.lblRegistrarMascota.TabIndex = 17;
            this.lblRegistrarMascota.Text = "Registro de mascota";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(355, 448);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarMascota
            // 
            this.btnGuardarMascota.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarMascota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarMascota.Location = new System.Drawing.Point(218, 448);
            this.btnGuardarMascota.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarMascota.Name = "btnGuardarMascota";
            this.btnGuardarMascota.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarMascota.TabIndex = 15;
            this.btnGuardarMascota.Text = "Guardar";
            this.btnGuardarMascota.UseVisualStyleBackColor = false;
            this.btnGuardarMascota.Click += new System.EventHandler(this.btnGuardarMascota_Click);
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(218, 385);
            this.cmbPropietario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(237, 24);
            this.cmbPropietario.TabIndex = 14;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(218, 118);
            this.txtNombreMascota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(237, 22);
            this.txtNombreMascota.TabIndex = 11;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(218, 181);
            this.cmbEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(237, 24);
            this.cmbEspecie.TabIndex = 22;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(218, 323);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(237, 22);
            this.dtpFechaNacimiento.TabIndex = 23;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(218, 249);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(237, 22);
            this.txtRaza.TabIndex = 24;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(308, 228);
            this.lblRaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(41, 17);
            this.lblRaza.TabIndex = 25;
            this.lblRaza.Text = "Raza";
            // 
            // AgregarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 511);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRegistrarMascota);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarMascota);
            this.Controls.Add(this.cmbPropietario);
            this.Controls.Add(this.txtNombreMascota);
            this.Name = "AgregarMascota";
            this.Text = "AgregarMascota";
            this.Load += new System.EventHandler(this.AgregarMascota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistrarMascota;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarMascota;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblRaza;
    }
}