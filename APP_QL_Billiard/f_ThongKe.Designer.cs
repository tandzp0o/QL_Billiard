﻿namespace APP_QL_Billiard
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
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDB.Legends.Add(legend1);
            this.chartDB.Location = new System.Drawing.Point(3, 3);
            this.chartDB.Name = "chartDB";
            this.chartDB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartDB.Series.Add(series1);
            this.chartDB.Size = new System.Drawing.Size(531, 299);
            this.chartDB.SuppressExceptions = true;
            this.chartDB.TabIndex = 0;
            this.chartDB.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chartDB.Titles.Add(title1);
            // 
            // chartTC
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTC.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTC.Legends.Add(legend2);
            this.chartTC.Location = new System.Drawing.Point(3, 308);
            this.chartTC.Name = "chartTC";
            this.chartTC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Thu";
            series2.YValuesPerPoint = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Chi";
            this.chartTC.Series.Add(series2);
            this.chartTC.Series.Add(series3);
            this.chartTC.Size = new System.Drawing.Size(1327, 435);
            this.chartTC.TabIndex = 1;
            this.chartTC.Text = "chartDT";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            this.chartTC.Titles.Add(title2);
            // 
            // chartDT
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDT.Legends.Add(legend3);
            this.chartDT.Location = new System.Drawing.Point(540, 3);
            this.chartDT.Name = "chartDT";
            this.chartDT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.LegendText = "Doanh thu";
            series4.Name = "s1";
            series4.YValuesPerPoint = 4;
            this.chartDT.Series.Add(series4);
            this.chartDT.Size = new System.Drawing.Size(790, 299);
            this.chartDT.SuppressExceptions = true;
            this.chartDT.TabIndex = 2;
            this.chartDT.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            this.chartDT.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartDB);
            this.panel1.Controls.Add(this.chartTC);
            this.panel1.Controls.Add(this.chartDT);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 746);
            this.panel1.TabIndex = 3;
            // 
            // f_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 770);
            this.Controls.Add(this.panel1);
            this.Name = "f_ThongKe";
            this.Text = "f_ThongKe";
            this.Load += new System.EventHandler(this.f_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.Panel panel1;
    }
}