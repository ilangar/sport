namespace Sport1
{
    partial class perfilEnt
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
            this.btnNuevoJug = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoJug
            // 
            this.btnNuevoJug.Location = new System.Drawing.Point(770, 388);
            this.btnNuevoJug.Name = "btnNuevoJug";
            this.btnNuevoJug.Size = new System.Drawing.Size(136, 98);
            this.btnNuevoJug.TabIndex = 0;
            this.btnNuevoJug.Text = "Agregar jugador";
            this.btnNuevoJug.UseVisualStyleBackColor = true;
            this.btnNuevoJug.Click += new System.EventHandler(this.BtnAgregarJug_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Location = new System.Drawing.Point(86, 428);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(117, 105);
            this.btnVolverAtras.TabIndex = 1;
            this.btnVolverAtras.Text = "Volver atras";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            this.btnVolverAtras.Click += new System.EventHandler(this.BtnVolverAtras_Click);
            // 
            // perfilEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnNuevoJug);
            this.Name = "perfilEnt";
            this.Text = "perfilEnt";
            this.Load += new System.EventHandler(this.PerfilEnt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarJug;
        public System.Windows.Forms.Button btnNuevoJug;
        private System.Windows.Forms.Button btnVolverAtras;
    }
}