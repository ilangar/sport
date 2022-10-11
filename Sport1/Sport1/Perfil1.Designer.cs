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
            this.lblNomPerfil = new System.Windows.Forms.Label();
            this.btnIngresarEstadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(72, 511);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(169, 107);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver a inicio";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblNomPerfil
            // 
            this.lblNomPerfil.AutoSize = true;
            this.lblNomPerfil.Location = new System.Drawing.Point(69, 53);
            this.lblNomPerfil.Name = "lblNomPerfil";
            this.lblNomPerfil.Size = new System.Drawing.Size(53, 20);
            this.lblNomPerfil.TabIndex = 1;
            this.lblNomPerfil.Text = "label1";
            this.lblNomPerfil.Click += new System.EventHandler(this.LblNomPerfil_Click);
            // 
            // btnIngresarEstadisticas
            // 
            this.btnIngresarEstadisticas.Location = new System.Drawing.Point(696, 73);
            this.btnIngresarEstadisticas.Name = "btnIngresarEstadisticas";
            this.btnIngresarEstadisticas.Size = new System.Drawing.Size(138, 157);
            this.btnIngresarEstadisticas.TabIndex = 2;
            this.btnIngresarEstadisticas.Text = "Ingresar estadisticas";
            this.btnIngresarEstadisticas.UseVisualStyleBackColor = true;
            this.btnIngresarEstadisticas.Click += new System.EventHandler(this.BtnIngresarEstadisticas_Click);
            // 
            // Perfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.btnIngresarEstadisticas);
            this.Controls.Add(this.lblNomPerfil);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Perfil1";
            this.Text = "Perfil1";
            this.Load += new System.EventHandler(this.Perfil1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNomPerfil;
        private System.Windows.Forms.Button btnIngresarEstadisticas;
    }
}