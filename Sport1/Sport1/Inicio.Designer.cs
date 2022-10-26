namespace Sport1
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
            this.btnCrearPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearPerfil.BackgroundImage = global::Sport1.Properties.Resources.Botón_Verde_agua_claro;
            this.btnCrearPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearPerfil.FlatAppearance.BorderSize = 0;
            this.btnCrearPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPerfil.Location = new System.Drawing.Point(498, 556);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(278, 79);
            this.btnCrearPerfil.TabIndex = 0;
            this.btnCrearPerfil.UseVisualStyleBackColor = false;
            this.btnCrearPerfil.Click += new System.EventHandler(this.BtnCrearPerfil_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sport1.Properties.Resources.Inicio_sesión;
            this.ClientSize = new System.Drawing.Size(1354, 749);
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