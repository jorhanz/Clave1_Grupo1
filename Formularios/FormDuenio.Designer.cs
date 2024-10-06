
using System;
using System.Windows.Forms;

namespace VeterinariaCatDog.Formularios
{
    partial class FormDuenio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label labelBuscarID;
        private TextBox textBoxBuscarID;
        private Button buttonBuscar;
        private Button buttonAgregar;
        private Button buttonRegresar;
        private DataGridView dataGridViewDuenios;
        private Label labelTitulo;
        private Button buttonModificar;
        private Button buttonEliminar;

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
            this.labelBuscarID = new System.Windows.Forms.Label();
            this.textBoxBuscarID = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.dataGridViewDuenios = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuenios)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuscarID
            // 
            this.labelBuscarID.AutoSize = true;
            this.labelBuscarID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelBuscarID.Location = new System.Drawing.Point(50, 100);
            this.labelBuscarID.Name = "labelBuscarID";
            this.labelBuscarID.Size = new System.Drawing.Size(131, 32);
            this.labelBuscarID.TabIndex = 0;
            this.labelBuscarID.Text = "ID Dueño:";
            // 
            // textBoxBuscarID
            // 
            this.textBoxBuscarID.Location = new System.Drawing.Point(200, 100);
            this.textBoxBuscarID.Name = "textBoxBuscarID";
            this.textBoxBuscarID.Size = new System.Drawing.Size(350, 26);
            this.textBoxBuscarID.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(570, 100);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 40);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(50, 170);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(150, 50);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(220, 170);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(150, 50);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(390, 170);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(150, 50);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.Gray;
            this.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresar.ForeColor = System.Drawing.Color.White;
            this.buttonRegresar.Location = new System.Drawing.Point(570, 170);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(150, 50);
            this.buttonRegresar.TabIndex = 6;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // dataGridViewDuenios
            // 
            this.dataGridViewDuenios.AllowUserToAddRows = false;
            this.dataGridViewDuenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuenios.Location = new System.Drawing.Point(50, 250);
            this.dataGridViewDuenios.Name = "dataGridViewDuenios";
            this.dataGridViewDuenios.RowHeadersWidth = 62;
            this.dataGridViewDuenios.Size = new System.Drawing.Size(1000, 300);
            this.dataGridViewDuenios.TabIndex = 7;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(50, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(338, 48);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Gestión de Dueños";
            // 
            // FormDuenio
            // 
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelBuscarID);
            this.Controls.Add(this.textBoxBuscarID);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.dataGridViewDuenios);
            this.Name = "FormDuenio";
            this.Text = "Gestión de Dueños";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuenios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
      #endregion
    }
}