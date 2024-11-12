
namespace proyectoVeterinaria
{
    partial class VistaMascotas
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
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.lblMascotas = new System.Windows.Forms.Label();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.BackColor = System.Drawing.Color.Red;
            this.btnEliminarMascota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarMascota.Location = new System.Drawing.Point(758, 44);
            this.btnEliminarMascota.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarMascota.TabIndex = 7;
            this.btnEliminarMascota.Text = "Eliminar";
            this.btnEliminarMascota.UseVisualStyleBackColor = false;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.Location = new System.Drawing.Point(885, 43);
            this.btnAgregarMascota.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarMascota.TabIndex = 6;
            this.btnAgregarMascota.Text = "Agregar usuario";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click_1);
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotas.Location = new System.Drawing.Point(446, 9);
            this.lblMascotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(187, 42);
            this.lblMascotas.TabIndex = 5;
            this.lblMascotas.Text = "Mascotas";
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(84, 85);
            this.dgvMascotas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.Size = new System.Drawing.Size(901, 391);
            this.dgvMascotas.TabIndex = 4;
            // 
            // VistaMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 485);
            this.Controls.Add(this.btnEliminarMascota);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.lblMascotas);
            this.Controls.Add(this.dgvMascotas);
            this.Name = "VistaMascotas";
            this.Text = "VistaMascotas";
            this.Load += new System.EventHandler(this.VistaMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.DataGridView dgvMascotas;
    }
}