
namespace proyectoVeterinaria
{
    partial class VistasHorarios
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
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.BackColor = System.Drawing.Color.Red;
            this.btnEliminarMascota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarMascota.Location = new System.Drawing.Point(764, 76);
            this.btnEliminarMascota.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarMascota.TabIndex = 11;
            this.btnEliminarMascota.Text = "Eliminar";
            this.btnEliminarMascota.UseVisualStyleBackColor = false;
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(891, 75);
            this.btnAgregarHorario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarHorario.TabIndex = 10;
            this.btnAgregarHorario.Text = "Agregar usuario";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarios.Location = new System.Drawing.Point(453, 41);
            this.lblHorarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(167, 42);
            this.lblHorarios.TabIndex = 9;
            this.lblHorarios.Text = "Horarios";
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(90, 117);
            this.dgvHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.Size = new System.Drawing.Size(901, 391);
            this.dgvHorarios.TabIndex = 8;
            // 
            // VistasHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 549);
            this.Controls.Add(this.btnEliminarMascota);
            this.Controls.Add(this.btnAgregarHorario);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.dgvHorarios);
            this.Name = "VistasHorarios";
            this.Text = "VistasHorarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.DataGridView dgvHorarios;
    }
}