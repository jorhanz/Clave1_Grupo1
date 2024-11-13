
namespace proyectoVeterinaria
{
    partial class RegistroExpediente
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
            this.dvgHistorialExpediente = new System.Windows.Forms.DataGridView();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarExpediente = new System.Windows.Forms.Button();
            this.lblRegistrarMascota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialExpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgHistorialExpediente
            // 
            this.dvgHistorialExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHistorialExpediente.Location = new System.Drawing.Point(191, 193);
            this.dvgHistorialExpediente.Name = "dvgHistorialExpediente";
            this.dvgHistorialExpediente.RowHeadersWidth = 51;
            this.dvgHistorialExpediente.RowTemplate.Height = 24;
            this.dvgHistorialExpediente.Size = new System.Drawing.Size(566, 334);
            this.dvgHistorialExpediente.TabIndex = 0;
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Location = new System.Drawing.Point(191, 68);
            this.dtpFechaConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(260, 22);
            this.dtpFechaConsulta.TabIndex = 37;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(191, 96);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(566, 22);
            this.txtDescripcion.TabIndex = 43;
            // 
            // btnGuardarExpediente
            // 
            this.btnGuardarExpediente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarExpediente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarExpediente.Location = new System.Drawing.Point(657, 62);
            this.btnGuardarExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarExpediente.Name = "btnGuardarExpediente";
            this.btnGuardarExpediente.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarExpediente.TabIndex = 44;
            this.btnGuardarExpediente.Text = "Guardar";
            this.btnGuardarExpediente.UseVisualStyleBackColor = false;
            // 
            // lblRegistrarMascota
            // 
            this.lblRegistrarMascota.AutoSize = true;
            this.lblRegistrarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarMascota.Location = new System.Drawing.Point(256, 138);
            this.lblRegistrarMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarMascota.Name = "lblRegistrarMascota";
            this.lblRegistrarMascota.Size = new System.Drawing.Size(445, 42);
            this.lblRegistrarMascota.TabIndex = 45;
            this.lblRegistrarMascota.Text = "Registro de expedientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 42);
            this.label1.TabIndex = 46;
            this.label1.Text = "Guardar nueva consulta";
            // 
            // RegistroExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistrarMascota);
            this.Controls.Add(this.btnGuardarExpediente);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtpFechaConsulta);
            this.Controls.Add(this.dvgHistorialExpediente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroExpediente";
            this.Text = "RegistroExpediente";
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialExpediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgHistorialExpediente;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardarExpediente;
        private System.Windows.Forms.Label lblRegistrarMascota;
        private System.Windows.Forms.Label label1;
    }
}