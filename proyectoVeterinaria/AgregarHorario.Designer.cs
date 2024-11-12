
namespace proyectoVeterinaria
{
    partial class AgregarHorario
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
            this.lblRegistrarHorario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarHorario = new System.Windows.Forms.Button();
            this.cmbVeterinario = new System.Windows.Forms.ComboBox();
            this.checkedListBoxDias = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.timePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(307, 321);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(77, 17);
            this.lblRol.TabIndex = 34;
            this.lblRol.Text = "Veterinario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(216, 260);
            this.lblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(75, 17);
            this.lblContra.TabIndex = 33;
            this.lblContra.Text = "Hora inicio";
            // 
            // lblRegistrarHorario
            // 
            this.lblRegistrarHorario.AutoSize = true;
            this.lblRegistrarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarHorario.Location = new System.Drawing.Point(144, 15);
            this.lblRegistrarHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarHorario.Name = "lblRegistrarHorario";
            this.lblRegistrarHorario.Size = new System.Drawing.Size(379, 42);
            this.lblRegistrarHorario.TabIndex = 30;
            this.lblRegistrarHorario.Text = "Registro de mascota";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(356, 430);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarHorario
            // 
            this.btnGuardarHorario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarHorario.Location = new System.Drawing.Point(219, 430);
            this.btnGuardarHorario.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarHorario.Name = "btnGuardarHorario";
            this.btnGuardarHorario.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarHorario.TabIndex = 28;
            this.btnGuardarHorario.Text = "Guardar";
            this.btnGuardarHorario.UseVisualStyleBackColor = false;
            this.btnGuardarHorario.Click += new System.EventHandler(this.btnGuardarHorario_Click);
            // 
            // cmbVeterinario
            // 
            this.cmbVeterinario.FormattingEnabled = true;
            this.cmbVeterinario.Location = new System.Drawing.Point(219, 342);
            this.cmbVeterinario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVeterinario.Name = "cmbVeterinario";
            this.cmbVeterinario.Size = new System.Drawing.Size(237, 24);
            this.cmbVeterinario.TabIndex = 27;
            // 
            // checkedListBoxDias
            // 
            this.checkedListBoxDias.FormattingEnabled = true;
            this.checkedListBoxDias.Location = new System.Drawing.Point(219, 103);
            this.checkedListBoxDias.Name = "checkedListBoxDias";
            this.checkedListBoxDias.Size = new System.Drawing.Size(237, 140);
            this.checkedListBoxDias.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Dias de la semana";
            // 
            // timePickerInicio
            // 
            this.timePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerInicio.Location = new System.Drawing.Point(219, 280);
            this.timePickerInicio.Name = "timePickerInicio";
            this.timePickerInicio.ShowUpDown = true;
            this.timePickerInicio.Size = new System.Drawing.Size(100, 22);
            this.timePickerInicio.TabIndex = 36;
            // 
            // timePickerFin
            // 
            this.timePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerFin.Location = new System.Drawing.Point(356, 280);
            this.timePickerFin.Name = "timePickerFin";
            this.timePickerFin.ShowUpDown = true;
            this.timePickerFin.Size = new System.Drawing.Size(100, 22);
            this.timePickerFin.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Hora Fin";
            // 
            // AgregarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timePickerFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxDias);
            this.Controls.Add(this.timePickerInicio);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblRegistrarHorario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarHorario);
            this.Controls.Add(this.cmbVeterinario);
            this.Name = "AgregarHorario";
            this.Text = "AgregarHorario";
            this.Load += new System.EventHandler(this.AgregarHorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblRegistrarHorario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarHorario;
        private System.Windows.Forms.ComboBox cmbVeterinario;
        private System.Windows.Forms.CheckedListBox checkedListBoxDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePickerInicio;
        private System.Windows.Forms.DateTimePicker timePickerFin;
        private System.Windows.Forms.Label label2;
    }
}