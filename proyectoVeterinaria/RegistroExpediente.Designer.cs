
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
            this.dgvHistorialExpediente = new System.Windows.Forms.DataGridView();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarExpediente = new System.Windows.Forms.Button();
            this.lblRegistrarMascota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVeterinario = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialExpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialExpediente
            // 
            this.dgvHistorialExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialExpediente.Location = new System.Drawing.Point(191, 249);
            this.dgvHistorialExpediente.Name = "dgvHistorialExpediente";
            this.dgvHistorialExpediente.RowHeadersWidth = 51;
            this.dgvHistorialExpediente.RowTemplate.Height = 24;
            this.dgvHistorialExpediente.Size = new System.Drawing.Size(593, 334);
            this.dgvHistorialExpediente.TabIndex = 0;
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Location = new System.Drawing.Point(191, 90);
            this.dtpFechaConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(241, 22);
            this.dtpFechaConsulta.TabIndex = 37;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(191, 156);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(593, 22);
            this.txtDescripcion.TabIndex = 43;
            // 
            // btnGuardarExpediente
            // 
            this.btnGuardarExpediente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarExpediente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarExpediente.Location = new System.Drawing.Point(684, 85);
            this.btnGuardarExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarExpediente.Name = "btnGuardarExpediente";
            this.btnGuardarExpediente.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarExpediente.TabIndex = 44;
            this.btnGuardarExpediente.Text = "Guardar";
            this.btnGuardarExpediente.UseVisualStyleBackColor = false;
            this.btnGuardarExpediente.Click += new System.EventHandler(this.btnGuardarExpediente_Click);
            // 
            // lblRegistrarMascota
            // 
            this.lblRegistrarMascota.AutoSize = true;
            this.lblRegistrarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarMascota.Location = new System.Drawing.Point(256, 182);
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
            // cmbVeterinario
            // 
            this.cmbVeterinario.FormattingEnabled = true;
            this.cmbVeterinario.Location = new System.Drawing.Point(439, 88);
            this.cmbVeterinario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVeterinario.Name = "cmbVeterinario";
            this.cmbVeterinario.Size = new System.Drawing.Size(237, 24);
            this.cmbVeterinario.TabIndex = 47;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(188, 60);
            this.lblRaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(124, 17);
            this.lblRaza.TabIndex = 48;
            this.lblRaza.Text = "Fecha de consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Veterinario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Descripción";
            // 
            // RegistroExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.cmbVeterinario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistrarMascota);
            this.Controls.Add(this.btnGuardarExpediente);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtpFechaConsulta);
            this.Controls.Add(this.dgvHistorialExpediente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroExpediente";
            this.Text = "RegistroExpediente";
            this.Load += new System.EventHandler(this.RegistroExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialExpediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialExpediente;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardarExpediente;
        private System.Windows.Forms.Label lblRegistrarMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVeterinario;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}