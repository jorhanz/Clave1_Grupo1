
namespace proyectoVeterinaria
{
    partial class VistaExpediente
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
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnAgregarExpediente = new System.Windows.Forms.Button();
            this.lblMascotas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(92, 171);
            this.dgvMascotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.Size = new System.Drawing.Size(884, 281);
            this.dgvMascotas.TabIndex = 0;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCita.Location = new System.Drawing.Point(747, 111);
            this.btnEliminarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarCita.TabIndex = 14;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            // 
            // btnAgregarExpediente
            // 
            this.btnAgregarExpediente.Location = new System.Drawing.Point(875, 110);
            this.btnAgregarExpediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarExpediente.Name = "btnAgregarExpediente";
            this.btnAgregarExpediente.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarExpediente.TabIndex = 13;
            this.btnAgregarExpediente.Text = "Agregar";
            this.btnAgregarExpediente.UseVisualStyleBackColor = true;
            this.btnAgregarExpediente.Click += new System.EventHandler(this.btnAgregarExpediente_Click);
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotas.Location = new System.Drawing.Point(459, 54);
            this.lblMascotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(236, 42);
            this.lblMascotas.TabIndex = 12;
            this.lblMascotas.Text = "Expedientes";
            // 
            // VistaExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.btnAgregarExpediente);
            this.Controls.Add(this.lblMascotas);
            this.Controls.Add(this.dgvMascotas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VistaExpediente";
            this.Text = "VistaExpediente";
            this.Load += new System.EventHandler(this.VistaExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Button btnAgregarExpediente;
        private System.Windows.Forms.Label lblMascotas;
    }
}