﻿namespace Sport1
{
    partial class Inicio
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
            this.btnCrearPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.Location = new System.Drawing.Point(496, 314);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(162, 117);
            this.btnCrearPerfil.TabIndex = 0;
            this.btnCrearPerfil.Text = "Crear Perfil";
            this.btnCrearPerfil.UseVisualStyleBackColor = true;
            this.btnCrearPerfil.Click += new System.EventHandler(this.BtnCrearPerfil_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 522);
            this.Controls.Add(this.btnCrearPerfil);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPerfil;
    }
}