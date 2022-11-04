namespace Sport1
{
    partial class Objetivos
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnVolverAEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::Sport1.Properties.Resources.Botón_guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Location = new System.Drawing.Point(881, 512);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(226, 84);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // btnVolverAEnt
            // 
            this.btnVolverAEnt.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.BackgroundImage = global::Sport1.Properties.Resources.image_9__1_;
            this.btnVolverAEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverAEnt.FlatAppearance.BorderSize = 0;
            this.btnVolverAEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAEnt.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.Location = new System.Drawing.Point(1120, 23);
            this.btnVolverAEnt.Name = "btnVolverAEnt";
            this.btnVolverAEnt.Size = new System.Drawing.Size(53, 50);
            this.btnVolverAEnt.TabIndex = 8;
            this.btnVolverAEnt.UseVisualStyleBackColor = false;
            this.btnVolverAEnt.Click += new System.EventHandler(this.BtnVolverAEnt_Click);
            // 
            // Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sport1.Properties.Resources.Base;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 681);
            this.Controls.Add(this.btnVolverAEnt);
            this.Controls.Add(this.btnguardar);
            this.DoubleBuffered = true;
            this.Name = "Objetivos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Objfutbol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnVolverAEnt;
    }
}