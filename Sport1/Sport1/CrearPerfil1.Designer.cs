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
            this.btnVolverAEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(127, 224);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 256);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // btnAceptarPerfil
            // 
            this.btnAceptarPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarPerfil.BackgroundImage = global::Sport1.Properties.Resources.Botón_Verde_agua_claro;
            this.btnAceptarPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptarPerfil.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAceptarPerfil.FlatAppearance.BorderSize = 0;
            this.btnAceptarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptarPerfil.Location = new System.Drawing.Point(468, 566);
            this.btnAceptarPerfil.Name = "btnAceptarPerfil";
            this.btnAceptarPerfil.Size = new System.Drawing.Size(227, 77);
            this.btnAceptarPerfil.TabIndex = 2;
            this.btnAceptarPerfil.UseVisualStyleBackColor = false;
            this.btnAceptarPerfil.Click += new System.EventHandler(this.BtnAceptarPerfil_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRol.Location = new System.Drawing.Point(127, 296);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 17);
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
            this.cmbDeporte.Location = new System.Drawing.Point(133, 408);
            this.cmbDeporte.Name = "cmbDeporte";
            this.cmbDeporte.Size = new System.Drawing.Size(201, 21);
            this.cmbDeporte.TabIndex = 4;
            this.cmbDeporte.SelectedIndexChanged += new System.EventHandler(this.CmbDeporte_SelectedIndexChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Equipo",
            "Jugador"});
            this.cmbRol.Location = new System.Drawing.Point(133, 327);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(201, 21);
            this.cmbRol.TabIndex = 5;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRol_SelectedIndexChanged);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.BackColor = System.Drawing.Color.Transparent;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDeporte.Location = new System.Drawing.Point(130, 375);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(59, 17);
            this.lblDeporte.TabIndex = 6;
            this.lblDeporte.Text = "Deporte";
            // 
            // btnVolverAEnt
            // 
            this.btnVolverAEnt.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.BackgroundImage = global::Sport1.Properties.Resources.image_9__1_;
            this.btnVolverAEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverAEnt.FlatAppearance.BorderSize = 0;
            this.btnVolverAEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAEnt.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.Location = new System.Drawing.Point(1246, 26);
            this.btnVolverAEnt.Name = "btnVolverAEnt";
            this.btnVolverAEnt.Size = new System.Drawing.Size(53, 50);
            this.btnVolverAEnt.TabIndex = 7;
            this.btnVolverAEnt.UseVisualStyleBackColor = false;
            this.btnVolverAEnt.Click += new System.EventHandler(this.BtnVolverAEnt_Click);
            // 
            // CrearPerfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sport1.Properties.Resources.Group_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnVolverAEnt);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.cmbDeporte);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnAceptarPerfil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CrearPerfil1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
        private System.Windows.Forms.Button btnVolverAEnt;
    }
}