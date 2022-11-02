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
            this.lblObj = new System.Windows.Forms.Label();
            this.btnVolverAEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(30, 359);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(133, 65);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar ";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // lblObj
            // 
            this.lblObj.AutoSize = true;
            this.lblObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObj.Location = new System.Drawing.Point(23, 27);
            this.lblObj.Name = "lblObj";
            this.lblObj.Size = new System.Drawing.Size(172, 39);
            this.lblObj.TabIndex = 1;
            this.lblObj.Text = "Objetivos";
            this.lblObj.Click += new System.EventHandler(this.Lblobjfutbol_Click);
            // 
            // btnVolverAEnt
            // 
            this.btnVolverAEnt.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.BackgroundImage = global::Sport1.Properties.Resources.image_9__1_;
            this.btnVolverAEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverAEnt.FlatAppearance.BorderSize = 0;
            this.btnVolverAEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAEnt.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.Location = new System.Drawing.Point(670, 27);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverAEnt);
            this.Controls.Add(this.lblObj);
            this.Controls.Add(this.btnguardar);
            this.Name = "Objetivos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Objfutbol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.Button btnVolverAEnt;
    }
}