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
            this.cmbDeporte = new System.Windows.Forms.ComboBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnVolverAEnt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Adobe Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(127, 224);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 276);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(278, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // btnAceptarPerfil
            // 
            this.btnAceptarPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarPerfil.BackgroundImage = global::Sport1.Properties.Resources.Botón_Verde_agua_claro;
            this.btnAceptarPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptarPerfil.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAceptarPerfil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptarPerfil.FlatAppearance.BorderSize = 0;
            this.btnAceptarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptarPerfil.Location = new System.Drawing.Point(399, 370);
            this.btnAceptarPerfil.Name = "btnAceptarPerfil";
            this.btnAceptarPerfil.Size = new System.Drawing.Size(227, 77);
            this.btnAceptarPerfil.TabIndex = 2;
            this.btnAceptarPerfil.UseVisualStyleBackColor = false;
            this.btnAceptarPerfil.Click += new System.EventHandler(this.BtnAceptarPerfil_Click);
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
            this.cmbDeporte.Location = new System.Drawing.Point(121, 521);
            this.cmbDeporte.Name = "cmbDeporte";
            this.cmbDeporte.Size = new System.Drawing.Size(214, 21);
            this.cmbDeporte.TabIndex = 4;
            this.cmbDeporte.SelectedIndexChanged += new System.EventHandler(this.CmbDeporte_SelectedIndexChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Equipo",
            "Jugador"});
            this.cmbRol.Location = new System.Drawing.Point(121, 401);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(214, 21);
            this.cmbRol.TabIndex = 5;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRol_SelectedIndexChanged);
            // 
            // btnVolverAEnt
            // 
            this.btnVolverAEnt.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.BackgroundImage = global::Sport1.Properties.Resources.image_9__1_;
            this.btnVolverAEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverAEnt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverAEnt.FlatAppearance.BorderSize = 0;
            this.btnVolverAEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAEnt.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverAEnt.Location = new System.Drawing.Point(1061, 9);
            this.btnVolverAEnt.Name = "btnVolverAEnt";
            this.btnVolverAEnt.Size = new System.Drawing.Size(67, 69);
            this.btnVolverAEnt.TabIndex = 7;
            this.btnVolverAEnt.UseVisualStyleBackColor = false;
            this.btnVolverAEnt.Click += new System.EventHandler(this.BtnVolverAEnt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sport1.Properties.Resources.Nombre_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(121, 229);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 36);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Sport1.Properties.Resources.Rol___3_;
            this.pictureBox2.Location = new System.Drawing.Point(121, 354);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 36);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Sport1.Properties.Resources.Deporte_;
            this.pictureBox3.Location = new System.Drawing.Point(121, 479);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 36);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // CrearPerfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sport1.Properties.Resources.Group_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1386, 720);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolverAEnt);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.cmbDeporte);
            this.Controls.Add(this.btnAceptarPerfil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearPerfil1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " ";
            this.Load += new System.EventHandler(this.CrearPerfil1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptarPerfil;
        private System.Windows.Forms.ComboBox cmbDeporte;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnVolverAEnt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}