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
            this.cmbDiaBasket = new System.Windows.Forms.ComboBox();
            this.lblFechaBasket = new System.Windows.Forms.Label();
            this.cmbAñoBasket = new System.Windows.Forms.ComboBox();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMesBasket = new System.Windows.Forms.ComboBox();
            this.btnIngresarEst = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cmbDiaBasket.Location = new System.Drawing.Point(260, 80);
            this.cmbDiaBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDiaBasket.Name = "cmbDiaBasket";
            this.cmbDiaBasket.Size = new System.Drawing.Size(104, 28);
            this.cmbDiaBasket.TabIndex = 13;
            // 
            // lblFechaBasket
            // 
            this.lblFechaBasket.AutoSize = true;
            this.lblFechaBasket.Location = new System.Drawing.Point(135, 85);
            this.lblFechaBasket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaBasket.Name = "lblFechaBasket";
            this.lblFechaBasket.Size = new System.Drawing.Size(54, 20);
            this.lblFechaBasket.TabIndex = 14;
            this.lblFechaBasket.Text = "Fecha";
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
            this.cmbAñoBasket.Location = new System.Drawing.Point(594, 80);
            this.cmbAñoBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAñoBasket.Name = "cmbAñoBasket";
            this.cmbAñoBasket.Size = new System.Drawing.Size(104, 28);
            this.cmbAñoBasket.TabIndex = 16;
            // 
            // lblBarra1
            // 
            this.lblBarra1.AutoSize = true;
            this.lblBarra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra1.Location = new System.Drawing.Point(375, 85);
            this.lblBarra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(20, 29);
            this.lblBarra1.TabIndex = 19;
            this.lblBarra1.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "/";
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
            this.cmbMesBasket.Location = new System.Drawing.Point(426, 83);
            this.cmbMesBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMesBasket.Name = "cmbMesBasket";
            this.cmbMesBasket.Size = new System.Drawing.Size(104, 28);
            this.cmbMesBasket.TabIndex = 21;
            // 
            // btnIngresarEst
            // 
            this.btnIngresarEst.Location = new System.Drawing.Point(848, 325);
            this.btnIngresarEst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresarEst.Name = "btnIngresarEst";
            this.btnIngresarEst.Size = new System.Drawing.Size(112, 35);
            this.btnIngresarEst.TabIndex = 22;
            this.btnIngresarEst.Text = "Listo";
            this.btnIngresarEst.UseVisualStyleBackColor = true;
            this.btnIngresarEst.Click += new System.EventHandler(this.BtnIngresarBasket_Click);
            // 
            // IngresarEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.btnIngresarEst);
            this.Controls.Add(this.cmbMesBasket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBarra1);
            this.Controls.Add(this.cmbAñoBasket);
            this.Controls.Add(this.lblFechaBasket);
            this.Controls.Add(this.cmbDiaBasket);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}