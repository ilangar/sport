namespace Sport1
{
    partial class nuevoJug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoJug));
            this.txtNomJug = new System.Windows.Forms.TextBox();
            this.lblNomJug = new System.Windows.Forms.Label();
            this.btnNuevoJug = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomJug
            // 
            this.txtNomJug.Font = new System.Drawing.Font("Montserrat Alternates Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomJug.Location = new System.Drawing.Point(247, 317);
            this.txtNomJug.Name = "txtNomJug";
            this.txtNomJug.Size = new System.Drawing.Size(238, 43);
            this.txtNomJug.TabIndex = 0;
            // 
            // lblNomJug
            // 
            this.lblNomJug.AutoSize = true;
            this.lblNomJug.BackColor = System.Drawing.Color.Transparent;
            this.lblNomJug.Font = new System.Drawing.Font("Montserrat Alternates Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug.Location = new System.Drawing.Point(240, 263);
            this.lblNomJug.Name = "lblNomJug";
            this.lblNomJug.Size = new System.Drawing.Size(145, 40);
            this.lblNomJug.TabIndex = 1;
            this.lblNomJug.Text = "Nombre";
            // 
            // btnNuevoJug
            // 
            this.btnNuevoJug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoJug.BackgroundImage")));
            this.btnNuevoJug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoJug.FlatAppearance.BorderSize = 0;
            this.btnNuevoJug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJug.Location = new System.Drawing.Point(228, 385);
            this.btnNuevoJug.Name = "btnNuevoJug";
            this.btnNuevoJug.Size = new System.Drawing.Size(320, 77);
            this.btnNuevoJug.TabIndex = 2;
            this.btnNuevoJug.UseVisualStyleBackColor = true;
            this.btnNuevoJug.Click += new System.EventHandler(this.BtnNuevoJug_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAtras.FlatAppearance.BorderSize = 0;
            this.btnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAtras.Font = new System.Drawing.Font("Montserrat Alternates Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAtras.Location = new System.Drawing.Point(257, 484);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(239, 71);
            this.btnVolverAtras.TabIndex = 3;
            this.btnVolverAtras.Text = "Volver atras";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.Button2_Click);
            // 
            // nuevoJug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnNuevoJug);
            this.Controls.Add(this.lblNomJug);
            this.Controls.Add(this.txtNomJug);
            this.DoubleBuffered = true;
            this.Name = "nuevoJug";
            this.Text = "nuevoJug";
            this.Load += new System.EventHandler(this.NuevoJug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomJug;
        private System.Windows.Forms.Label lblNomJug;
        private System.Windows.Forms.Button btnNuevoJug;
        private System.Windows.Forms.Button btnVolverAtras;
    }
}