namespace Sport1
{
    partial class objfutbol
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
            this.lblobjfutbol = new System.Windows.Forms.Label();
            this.lblgoles = new System.Windows.Forms.Label();
            this.textboxcantgol = new System.Windows.Forms.TextBox();
            this.textboxasist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxfalt = new System.Windows.Forms.TextBox();
            this.lblfaltas = new System.Windows.Forms.Label();
            this.lblPases = new System.Windows.Forms.Label();
            this.txtpases = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(563, 302);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(133, 65);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar ";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // lblobjfutbol
            // 
            this.lblobjfutbol.AutoSize = true;
            this.lblobjfutbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobjfutbol.Location = new System.Drawing.Point(23, 27);
            this.lblobjfutbol.Name = "lblobjfutbol";
            this.lblobjfutbol.Size = new System.Drawing.Size(284, 39);
            this.lblobjfutbol.TabIndex = 1;
            this.lblobjfutbol.Text = "Objetivos Fútbol";
            // 
            // lblgoles
            // 
            this.lblgoles.AutoSize = true;
            this.lblgoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgoles.Location = new System.Drawing.Point(30, 128);
            this.lblgoles.Name = "lblgoles";
            this.lblgoles.Size = new System.Drawing.Size(69, 24);
            this.lblgoles.TabIndex = 2;
            this.lblgoles.Text = "Goles: ";
            // 
            // textboxcantgol
            // 
            this.textboxcantgol.Location = new System.Drawing.Point(185, 132);
            this.textboxcantgol.Name = "textboxcantgol";
            this.textboxcantgol.Size = new System.Drawing.Size(21, 20);
            this.textboxcantgol.TabIndex = 3;
            // 
            // textboxasist
            // 
            this.textboxasist.Location = new System.Drawing.Point(185, 166);
            this.textboxasist.Name = "textboxasist";
            this.textboxasist.Size = new System.Drawing.Size(21, 20);
            this.textboxasist.TabIndex = 5;
            this.textboxasist.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asistencias:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textboxfalt
            // 
            this.textboxfalt.Location = new System.Drawing.Point(185, 203);
            this.textboxfalt.Name = "textboxfalt";
            this.textboxfalt.Size = new System.Drawing.Size(21, 20);
            this.textboxfalt.TabIndex = 7;
            // 
            // lblfaltas
            // 
            this.lblfaltas.AutoSize = true;
            this.lblfaltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfaltas.Location = new System.Drawing.Point(30, 203);
            this.lblfaltas.Name = "lblfaltas";
            this.lblfaltas.Size = new System.Drawing.Size(64, 24);
            this.lblfaltas.TabIndex = 6;
            this.lblfaltas.Text = "Faltas ";
            // 
            // lblPases
            // 
            this.lblPases.AutoSize = true;
            this.lblPases.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPases.Location = new System.Drawing.Point(30, 241);
            this.lblPases.Name = "lblPases";
            this.lblPases.Size = new System.Drawing.Size(149, 24);
            this.lblPases.TabIndex = 8;
            this.lblPases.Text = "Pases correctos ";
            // 
            // txtpases
            // 
            this.txtpases.Location = new System.Drawing.Point(185, 246);
            this.txtpases.Name = "txtpases";
            this.txtpases.Size = new System.Drawing.Size(21, 20);
            this.txtpases.TabIndex = 9;
            // 
            // objfutbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpases);
            this.Controls.Add(this.lblPases);
            this.Controls.Add(this.textboxfalt);
            this.Controls.Add(this.lblfaltas);
            this.Controls.Add(this.textboxasist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxcantgol);
            this.Controls.Add(this.lblgoles);
            this.Controls.Add(this.lblobjfutbol);
            this.Controls.Add(this.btnguardar);
            this.Name = "objfutbol";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblobjfutbol;
        private System.Windows.Forms.Label lblgoles;
        private System.Windows.Forms.TextBox textboxcantgol;
        private System.Windows.Forms.TextBox textboxasist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxfalt;
        private System.Windows.Forms.Label lblfaltas;
        private System.Windows.Forms.Label lblPases;
        private System.Windows.Forms.TextBox txtpases;
    }
}