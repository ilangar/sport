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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIngresarEstadisticas = new System.Windows.Forms.Button();
            this.btnVerProgresos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eliminarPerfil = new System.Windows.Forms.Button();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::Sport1.Properties.Resources.Botón_volver_a_la_pagina_anterior;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(1185, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 80);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnIngresarEstadisticas
            // 
            this.btnIngresarEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarEstadisticas.BackgroundImage = global::Sport1.Properties.Resources.Botón_Añadir_estadisticas__1_;
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
            this.btnVerProgresos.Image = global::Sport1.Properties.Resources.Botón_ver_progreso;
            this.btnVerProgresos.Location = new System.Drawing.Point(700, 250);
            this.btnVerProgresos.Name = "btnVerProgresos";
            this.btnVerProgresos.Size = new System.Drawing.Size(420, 90);
            this.btnVerProgresos.TabIndex = 3;
            this.btnVerProgresos.UseVisualStyleBackColor = false;
            this.btnVerProgresos.Click += new System.EventHandler(this.BtnVerProgresos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Sport1.Properties.Resources.Metas;
            this.button1.Location = new System.Drawing.Point(915, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 90);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // eliminarPerfil
            // 
            this.eliminarPerfil.Location = new System.Drawing.Point(1007, 426);
            this.eliminarPerfil.Name = "eliminarPerfil";
            this.eliminarPerfil.Size = new System.Drawing.Size(120, 23);
            this.eliminarPerfil.TabIndex = 5;
            this.eliminarPerfil.Text = "Eliminar perfil";
            this.eliminarPerfil.UseVisualStyleBackColor = true;
            this.eliminarPerfil.Click += new System.EventHandler(this.EliminarPerfil_Click);
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Location = new System.Drawing.Point(702, 27);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(35, 13);
            this.lblNomUser.TabIndex = 6;
            this.lblNomUser.Text = "label1";
            this.lblNomUser.Click += new System.EventHandler(this.LblNomUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Perfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sport1.Properties.Resources.Base_pagina_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.eliminarPerfil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerProgresos);
            this.Controls.Add(this.btnIngresarEstadisticas);
            this.Controls.Add(this.btnVolver);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Perfil1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil1";
            this.Load += new System.EventHandler(this.Perfil1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIngresarEstadisticas;
        private System.Windows.Forms.Button btnVerProgresos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eliminarPerfil;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Label label1;
    }
}