
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
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.BackColor = System.Drawing.Color.Red;
            this.btnEliminarHorario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarHorario.Location = new System.Drawing.Point(573, 62);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarHorario.TabIndex = 11;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = false;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(668, 61);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHorario.TabIndex = 10;
            this.btnAgregarHorario.Text = "Agregar usuario";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click);
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarios.Location = new System.Drawing.Point(340, 33);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(134, 33);
            this.lblHorarios.TabIndex = 9;
            this.lblHorarios.Text = "Horarios";
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(68, 95);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.Size = new System.Drawing.Size(676, 318);
            this.dgvHorarios.TabIndex = 8;
            // 
            // VistasHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 446);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.btnAgregarHorario);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.dgvHorarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VistasHorarios";
            this.Text = "VistasHorarios";
            this.Load += new System.EventHandler(this.VistasHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.DataGridView dgvHorarios;
    }
}