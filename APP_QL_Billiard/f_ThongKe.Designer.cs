namespace APP_QL_Billiard
{
    partial class f_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDB.Legends.Add(legend1);
            this.chartDB.Location = new System.Drawing.Point(12, 12);
            this.chartDB.Name = "chartDB";
            this.chartDB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartDB.Series.Add(series1);
            this.chartDB.Size = new System.Drawing.Size(228, 175);
            this.chartDB.SuppressExceptions = true;
            this.chartDB.TabIndex = 0;
            this.chartDB.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chartDB.Titles.Add(title1);
            // 
            // chartDT
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDT.Legends.Add(legend2);
            this.chartDT.Location = new System.Drawing.Point(12, 193);
            this.chartDT.Name = "chartDT";
            this.chartDT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.chartDT.Series.Add(series2);
            this.chartDT.Series.Add(series3);
            this.chartDT.Size = new System.Drawing.Size(797, 300);
            this.chartDT.TabIndex = 1;
            this.chartDT.Text = "chartDT";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Name = "Title1";
            this.chartDT.Titles.Add(title2);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(246, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(563, 175);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title3.Name = "Title1";
            this.chart1.Titles.Add(title3);
            // 
            // f_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 505);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartDT);
            this.Controls.Add(this.chartDB);
            this.Name = "f_ThongKe";
            this.Text = "f_ThongKe";
            this.Load += new System.EventHandler(this.f_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}