namespace Sport1
{
    partial class objetivos
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
            this.cmbMesBasket = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.cmbAñoBasket = new System.Windows.Forms.ComboBox();
            this.lblFechaBasket = new System.Windows.Forms.Label();
            this.cmbDiaBasket = new System.Windows.Forms.ComboBox();
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
            // cmbMesBasket
            // 
            this.cmbMesBasket.FormattingEnabled = true;
            this.cmbMesBasket.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMesBasket.Location = new System.Drawing.Point(433, 45);
            this.cmbMesBasket.Name = "cmbMesBasket";
            this.cmbMesBasket.Size = new System.Drawing.Size(71, 21);
            this.cmbMesBasket.TabIndex = 27;
            this.cmbMesBasket.SelectedIndexChanged += new System.EventHandler(this.CmbMesBasket_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "/";
            // 
            // lblBarra1
            // 
            this.lblBarra1.AutoSize = true;
            this.lblBarra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra1.Location = new System.Drawing.Point(402, 44);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(13, 20);
            this.lblBarra1.TabIndex = 25;
            this.lblBarra1.Text = "/";
            // 
            // cmbAñoBasket
            // 
            this.cmbAñoBasket.FormattingEnabled = true;
            this.cmbAñoBasket.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbAñoBasket.Location = new System.Drawing.Point(545, 43);
            this.cmbAñoBasket.Name = "cmbAñoBasket";
            this.cmbAñoBasket.Size = new System.Drawing.Size(71, 21);
            this.cmbAñoBasket.TabIndex = 24;
            this.cmbAñoBasket.SelectedIndexChanged += new System.EventHandler(this.CmbAñoBasket_SelectedIndexChanged);
            // 
            // lblFechaBasket
            // 
            this.lblFechaBasket.AutoSize = true;
            this.lblFechaBasket.Location = new System.Drawing.Point(239, 46);
            this.lblFechaBasket.Name = "lblFechaBasket";
            this.lblFechaBasket.Size = new System.Drawing.Size(37, 13);
            this.lblFechaBasket.TabIndex = 23;
            this.lblFechaBasket.Text = "Fecha";
            this.lblFechaBasket.Click += new System.EventHandler(this.LblFechaBasket_Click);
            // 
            // cmbDiaBasket
            // 
            this.cmbDiaBasket.FormattingEnabled = true;
            this.cmbDiaBasket.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDiaBasket.Location = new System.Drawing.Point(322, 43);
            this.cmbDiaBasket.Name = "cmbDiaBasket";
            this.cmbDiaBasket.Size = new System.Drawing.Size(71, 21);
            this.cmbDiaBasket.TabIndex = 22;
            this.cmbDiaBasket.SelectedIndexChanged += new System.EventHandler(this.CmbDiaBasket_SelectedIndexChanged);
            // 
            // objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMesBasket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBarra1);
            this.Controls.Add(this.cmbAñoBasket);
            this.Controls.Add(this.lblFechaBasket);
            this.Controls.Add(this.cmbDiaBasket);
            this.Controls.Add(this.btnVolverAEnt);
            this.Controls.Add(this.lblObj);
            this.Controls.Add(this.btnguardar);
            this.Name = "objetivos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Objfutbol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.Button btnVolverAEnt;
        private System.Windows.Forms.ComboBox cmbMesBasket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBarra1;
        private System.Windows.Forms.ComboBox cmbAñoBasket;
        private System.Windows.Forms.Label lblFechaBasket;
        private System.Windows.Forms.ComboBox cmbDiaBasket;
    }
}