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
            this.txtNomJug = new System.Windows.Forms.TextBox();
            this.lblNomJug = new System.Windows.Forms.Label();
            this.btnNuevoJug = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomJug
            // 
            this.txtNomJug.Location = new System.Drawing.Point(51, 65);
            this.txtNomJug.Name = "txtNomJug";
            this.txtNomJug.Size = new System.Drawing.Size(100, 20);
            this.txtNomJug.TabIndex = 0;
            // 
            // lblNomJug
            // 
            this.lblNomJug.AutoSize = true;
            this.lblNomJug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug.Location = new System.Drawing.Point(47, 42);
            this.lblNomJug.Name = "lblNomJug";
            this.lblNomJug.Size = new System.Drawing.Size(65, 20);
            this.lblNomJug.TabIndex = 1;
            this.lblNomJug.Text = "Nombre";
            // 
            // btnNuevoJug
            // 
            this.btnNuevoJug.Location = new System.Drawing.Point(564, 246);
            this.btnNuevoJug.Name = "btnNuevoJug";
            this.btnNuevoJug.Size = new System.Drawing.Size(143, 98);
            this.btnNuevoJug.TabIndex = 2;
            this.btnNuevoJug.Text = "Agregar Jugador";
            this.btnNuevoJug.UseVisualStyleBackColor = true;
            this.btnNuevoJug.Click += new System.EventHandler(this.BtnNuevoJug_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAtras.Location = new System.Drawing.Point(117, 261);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(86, 71);
            this.btnVolverAtras.TabIndex = 3;
            this.btnVolverAtras.Text = "Volver atras";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.Button2_Click);
            // 
            // nuevoJug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnNuevoJug);
            this.Controls.Add(this.lblNomJug);
            this.Controls.Add(this.txtNomJug);
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