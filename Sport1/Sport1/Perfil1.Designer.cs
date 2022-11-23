namespace Sport1
{
    partial class Perfil1
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
            System.Windows.Forms.Button eliminarPerfil;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil1));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIngresarEstadisticas = new System.Windows.Forms.Button();
            this.btnVerProgresos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomUser = new System.Windows.Forms.Label();
            eliminarPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eliminarPerfil
            // 
            eliminarPerfil.BackColor = System.Drawing.Color.Transparent;
            eliminarPerfil.FlatAppearance.BorderSize = 0;
            eliminarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            eliminarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("eliminarPerfil.Image")));
            eliminarPerfil.Location = new System.Drawing.Point(1110, 663);
            eliminarPerfil.Name = "eliminarPerfil";
            eliminarPerfil.Size = new System.Drawing.Size(228, 64);
            eliminarPerfil.TabIndex = 5;
            eliminarPerfil.UseVisualStyleBackColor = false;
            eliminarPerfil.Click += new System.EventHandler(this.EliminarPerfil_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVolver.Image = global::Sport1.Properties.Resources.Botón_volver_a_la_pagina_anterior;
            this.btnVolver.Location = new System.Drawing.Point(1213, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(67, 69);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnIngresarEstadisticas
            // 
            this.btnIngresarEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarEstadisticas.BackgroundImage = global::Sport1.Properties.Resources.Botón_Añadir_estadisticas__1_;
            this.btnIngresarEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarEstadisticas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresarEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnIngresarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarEstadisticas.Location = new System.Drawing.Point(475, 110);
            this.btnIngresarEstadisticas.Name = "btnIngresarEstadisticas";
            this.btnIngresarEstadisticas.Size = new System.Drawing.Size(420, 90);
            this.btnIngresarEstadisticas.TabIndex = 2;
            this.btnIngresarEstadisticas.UseVisualStyleBackColor = false;
            this.btnIngresarEstadisticas.Click += new System.EventHandler(this.BtnIngresarEstadisticas_Click);
            // 
            // btnVerProgresos
            // 
            this.btnVerProgresos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerProgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerProgresos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerProgresos.FlatAppearance.BorderSize = 0;
            this.btnVerProgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProgresos.Image = global::Sport1.Properties.Resources.Botón_ver_progreso;
            this.btnVerProgresos.Location = new System.Drawing.Point(700, 250);
            this.btnVerProgresos.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerProgresos.Name = "btnVerProgresos";
            this.btnVerProgresos.Size = new System.Drawing.Size(420, 90);
            this.btnVerProgresos.TabIndex = 3;
            this.btnVerProgresos.UseVisualStyleBackColor = false;
            this.btnVerProgresos.Click += new System.EventHandler(this.BtnVerProgresos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Sport1.Properties.Resources.Metas;
            this.button1.Location = new System.Drawing.Point(915, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 90);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUser.Location = new System.Drawing.Point(664, 25);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(124, 42);
            this.lblNomUser.TabIndex = 6;
            this.lblNomUser.Text = "label1";
            this.lblNomUser.Click += new System.EventHandler(this.LblNomUser_Click);
            // 
            // Perfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(eliminarPerfil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerProgresos);
            this.Controls.Add(this.btnIngresarEstadisticas);
            this.Controls.Add(this.btnVolver);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Perfil1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Perfil1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIngresarEstadisticas;
        private System.Windows.Forms.Button btnVerProgresos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomUser;
    }
}