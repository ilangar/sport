﻿namespace Sport1
{
    partial class CrearPerfil1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptarPerfil = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbDeporte = new System.Windows.Forms.ComboBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.btnVolverAEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(41, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(44, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // btnAceptarPerfil
            // 
            this.btnAceptarPerfil.Location = new System.Drawing.Point(415, 311);
            this.btnAceptarPerfil.Name = "btnAceptarPerfil";
            this.btnAceptarPerfil.Size = new System.Drawing.Size(202, 98);
            this.btnAceptarPerfil.TabIndex = 2;
            this.btnAceptarPerfil.Text = "Crear perfil";
            this.btnAceptarPerfil.UseVisualStyleBackColor = true;
            this.btnAceptarPerfil.Click += new System.EventHandler(this.BtnAceptarPerfil_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRol.Location = new System.Drawing.Point(41, 102);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 17);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            // 
            // cmbDeporte
            // 
            this.cmbDeporte.FormattingEnabled = true;
            this.cmbDeporte.Items.AddRange(new object[] {
            "Basketball",
            "Futbol",
            "Handball",
            "Hockey",
            "Rugby",
            "Tenis",
            "Voleyball"});
            this.cmbDeporte.Location = new System.Drawing.Point(44, 178);
            this.cmbDeporte.Name = "cmbDeporte";
            this.cmbDeporte.Size = new System.Drawing.Size(121, 21);
            this.cmbDeporte.TabIndex = 4;
            this.cmbDeporte.SelectedIndexChanged += new System.EventHandler(this.CmbDeporte_SelectedIndexChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Equipo",
            "Jugador"});
            this.cmbRol.Location = new System.Drawing.Point(44, 123);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 5;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRol_SelectedIndexChanged);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDeporte.Location = new System.Drawing.Point(44, 159);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(59, 17);
            this.lblDeporte.TabIndex = 6;
            this.lblDeporte.Text = "Deporte";
            // 
            // btnVolverAEnt
            // 
            this.btnVolverAEnt.Location = new System.Drawing.Point(95, 334);
            this.btnVolverAEnt.Name = "btnVolverAEnt";
            this.btnVolverAEnt.Size = new System.Drawing.Size(108, 64);
            this.btnVolverAEnt.TabIndex = 7;
            this.btnVolverAEnt.Text = "Volver atras";
            this.btnVolverAEnt.UseVisualStyleBackColor = true;
            this.btnVolverAEnt.Click += new System.EventHandler(this.BtnVolverAEnt_Click);
            // 
            // CrearPerfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.btnVolverAEnt);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.cmbDeporte);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnAceptarPerfil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "CrearPerfil1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CrearPerfil1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptarPerfil;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbDeporte;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnVolverAEnt;
    }
}