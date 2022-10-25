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
            this.chartProgresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProgresos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProgresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProgresos.Legends.Add(legend1);
            this.chartProgresos.Location = new System.Drawing.Point(50, 47);
            this.chartProgresos.Name = "chartProgresos";
            this.chartProgresos.Size = new System.Drawing.Size(1106, 537);
            this.chartProgresos.TabIndex = 0;
            this.chartProgresos.Text = "chart1";
            // 
            // progresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.chartProgresos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "progresos";
            this.Text = "progresos";
            this.Load += new System.EventHandler(this.Progresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProgresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgresos;
    }
}