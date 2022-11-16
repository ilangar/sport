namespace Sport1
{
    partial class IngresarEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarEstadisticas));
            this.cmbDiaBasket = new System.Windows.Forms.ComboBox();
            this.lblFechaBasket = new System.Windows.Forms.Label();
            this.cmbAñoBasket = new System.Windows.Forms.ComboBox();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMesBasket = new System.Windows.Forms.ComboBox();
            this.btnIngresarEst = new System.Windows.Forms.Button();
            this.flowLayoutPanelEst = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cmbDiaBasket
            // 
            this.cmbDiaBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbDiaBasket.Location = new System.Drawing.Point(163, 145);
            this.cmbDiaBasket.Name = "cmbDiaBasket";
            this.cmbDiaBasket.Size = new System.Drawing.Size(71, 21);
            this.cmbDiaBasket.TabIndex = 13;
            this.cmbDiaBasket.SelectedIndexChanged += new System.EventHandler(this.CmbDiaBasket_SelectedIndexChanged);
            // 
            // lblFechaBasket
            // 
            this.lblFechaBasket.AutoSize = true;
            this.lblFechaBasket.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaBasket.Font = new System.Drawing.Font("Montserrat Alternates Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaBasket.Location = new System.Drawing.Point(80, 146);
            this.lblFechaBasket.Name = "lblFechaBasket";
            this.lblFechaBasket.Size = new System.Drawing.Size(54, 18);
            this.lblFechaBasket.TabIndex = 14;
            this.lblFechaBasket.Text = "Fecha";
            // 
            // cmbAñoBasket
            // 
            this.cmbAñoBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAñoBasket.FormattingEnabled = true;
            this.cmbAñoBasket.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbAñoBasket.Location = new System.Drawing.Point(358, 145);
            this.cmbAñoBasket.Name = "cmbAñoBasket";
            this.cmbAñoBasket.Size = new System.Drawing.Size(71, 21);
            this.cmbAñoBasket.TabIndex = 16;
            this.cmbAñoBasket.SelectedIndexChanged += new System.EventHandler(this.CmbAñoBasket_SelectedIndexChanged);
            // 
            // lblBarra1
            // 
            this.lblBarra1.AutoSize = true;
            this.lblBarra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra1.Location = new System.Drawing.Point(243, 145);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(13, 20);
            this.lblBarra1.TabIndex = 19;
            this.lblBarra1.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "/";
            // 
            // cmbMesBasket
            // 
            this.cmbMesBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbMesBasket.Location = new System.Drawing.Point(261, 145);
            this.cmbMesBasket.Name = "cmbMesBasket";
            this.cmbMesBasket.Size = new System.Drawing.Size(71, 21);
            this.cmbMesBasket.TabIndex = 21;
            this.cmbMesBasket.SelectedIndexChanged += new System.EventHandler(this.CmbMesBasket_SelectedIndexChanged);
            // 
            // btnIngresarEst
            // 
            this.btnIngresarEst.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarEst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresarEst.BackgroundImage")));
            this.btnIngresarEst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresarEst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarEst.FlatAppearance.BorderSize = 0;
            this.btnIngresarEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarEst.Location = new System.Drawing.Point(952, 573);
            this.btnIngresarEst.Name = "btnIngresarEst";
            this.btnIngresarEst.Size = new System.Drawing.Size(226, 77);
            this.btnIngresarEst.TabIndex = 22;
            this.btnIngresarEst.UseVisualStyleBackColor = false;
            this.btnIngresarEst.Click += new System.EventHandler(this.BtnIngresarBasket_Click);
            // 
            // flowLayoutPanelEst
            // 
            this.flowLayoutPanelEst.Location = new System.Drawing.Point(83, 183);
            this.flowLayoutPanelEst.Name = "flowLayoutPanelEst";
            this.flowLayoutPanelEst.Size = new System.Drawing.Size(1095, 384);
            this.flowLayoutPanelEst.TabIndex = 23;
            // 
            // IngresarEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanelEst);
            this.Controls.Add(this.btnIngresarEst);
            this.Controls.Add(this.cmbMesBasket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBarra1);
            this.Controls.Add(this.cmbAñoBasket);
            this.Controls.Add(this.lblFechaBasket);
            this.Controls.Add(this.cmbDiaBasket);
            this.Name = "IngresarEstadisticas";
            this.Text = "IngresarEstadisticas";
            this.Load += new System.EventHandler(this.IngresarEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDiaBasket;
        private System.Windows.Forms.Label lblFechaBasket;
        private System.Windows.Forms.ComboBox cmbAñoBasket;
        private System.Windows.Forms.Label lblBarra1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMesBasket;
        private System.Windows.Forms.Button btnIngresarEst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEst;
    }
}