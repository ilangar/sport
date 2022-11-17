namespace Sport1
{
    partial class progresos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(progresos));
            this.chartProgresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProgresos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProgresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProgresos.Legends.Add(legend1);
            this.chartProgresos.Location = new System.Drawing.Point(33, 31);
            this.chartProgresos.Margin = new System.Windows.Forms.Padding(2);
            this.chartProgresos.Name = "chartProgresos";
            this.chartProgresos.Size = new System.Drawing.Size(1178, 466);
            this.chartProgresos.TabIndex = 0;
            this.chartProgresos.Text = "chart1";
            this.chartProgresos.Visible = false;
            this.chartProgresos.Click += new System.EventHandler(this.chartProgresos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(73, 539);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(132, 52);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Listo";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 163);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.chartProgresos);
            this.Name = "progresos";
            this.Text = "progresos";
            this.Load += new System.EventHandler(this.Progresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgresos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}