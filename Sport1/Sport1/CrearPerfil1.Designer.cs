namespace Sport1
{
    partial class CrearPerfil1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptarPerfil = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbDeporte = new System.Windows.Forms.ComboBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(62, 83);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 114);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // btnAceptarPerfil
            // 
            this.btnAceptarPerfil.Location = new System.Drawing.Point(622, 478);
            this.btnAceptarPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptarPerfil.Name = "btnAceptarPerfil";
            this.btnAceptarPerfil.Size = new System.Drawing.Size(303, 151);
            this.btnAceptarPerfil.TabIndex = 2;
            this.btnAceptarPerfil.Text = "Crear perfil";
            this.btnAceptarPerfil.UseVisualStyleBackColor = true;
            this.btnAceptarPerfil.Click += new System.EventHandler(this.BtnAceptarPerfil_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRol.Location = new System.Drawing.Point(62, 157);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(40, 25);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            // 
            // cmbDeporte
            // 
            this.cmbDeporte.FormattingEnabled = true;
            this.cmbDeporte.Items.AddRange(new object[] {
            "Basketball",
            "Futbol",
            "Handball",
            "Hockey",
            "Rugby",
            "Tenis",
            "Voleyball"});
            this.cmbDeporte.Location = new System.Drawing.Point(66, 274);
            this.cmbDeporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDeporte.Name = "cmbDeporte";
            this.cmbDeporte.Size = new System.Drawing.Size(180, 28);
            this.cmbDeporte.TabIndex = 4;
            this.cmbDeporte.SelectedIndexChanged += new System.EventHandler(this.CmbDeporte_SelectedIndexChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Equipo",
            "Jugador"});
            this.cmbRol.Location = new System.Drawing.Point(66, 189);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(180, 28);
            this.cmbRol.TabIndex = 5;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRol_SelectedIndexChanged);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDeporte.Location = new System.Drawing.Point(66, 245);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(81, 25);
            this.lblDeporte.TabIndex = 6;
            this.lblDeporte.Text = "Deporte";
            // 
            // CrearPerfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.cmbDeporte);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnAceptarPerfil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CrearPerfil1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CrearPerfil1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptarPerfil;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbDeporte;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.TextBox txtNombre;
    }
}