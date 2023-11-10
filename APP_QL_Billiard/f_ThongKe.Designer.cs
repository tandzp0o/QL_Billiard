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
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbQuarter = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.GoupBox3 = new System.Windows.Forms.GroupBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.lb30Days = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb7Days = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GoupBox3.SuspendLayout();
            this.gb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDB.Legends.Add(legend1);
            this.chartDB.Location = new System.Drawing.Point(2, 2);
            this.chartDB.Margin = new System.Windows.Forms.Padding(2);
            this.chartDB.Name = "chartDB";
            this.chartDB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartDB.Series.Add(series1);
            this.chartDB.Size = new System.Drawing.Size(398, 243);
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
            this.chartTC.Location = new System.Drawing.Point(2, 250);
            this.chartTC.Margin = new System.Windows.Forms.Padding(2);
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
            this.chartTC.Size = new System.Drawing.Size(995, 353);
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
            this.chartDT.Location = new System.Drawing.Point(405, 2);
            this.chartDT.Margin = new System.Windows.Forms.Padding(2);
            this.chartDT.Name = "chartDT";
            this.chartDT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.LegendText = "Doanh thu";
            series4.Name = "s1";
            series4.YValuesPerPoint = 4;
            this.chartDT.Series.Add(series4);
            this.chartDT.Size = new System.Drawing.Size(592, 243);
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chartDB);
            this.panel1.Controls.Add(this.chartTC);
            this.panel1.Controls.Add(this.chartDT);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 719);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.GoupBox3);
            this.groupBox1.Controls.Add(this.gb);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 608);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Controls.Add(this.lbQuarter);
            this.groupBox6.Location = new System.Drawing.Point(604, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(150, 83);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tổng doanh thu trong quý";
            // 
            // lbQuarter
            // 
            this.lbQuarter.AutoSize = true;
            this.lbQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbQuarter.Location = new System.Drawing.Point(6, 51);
            this.lbQuarter.Name = "lbQuarter";
            this.lbQuarter.Size = new System.Drawing.Size(124, 20);
            this.lbQuarter.TabIndex = 3;
            this.lbQuarter.Text = "000000000VND";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Controls.Add(this.lbYear);
            this.groupBox5.Location = new System.Drawing.Point(785, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 83);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tổng doanh thu trong năm";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbYear.Location = new System.Drawing.Point(6, 51);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(124, 20);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "000000000VND";
            // 
            // GoupBox3
            // 
            this.GoupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GoupBox3.Controls.Add(this.lbMonth);
            this.GoupBox3.Location = new System.Drawing.Point(423, 19);
            this.GoupBox3.Name = "GoupBox3";
            this.GoupBox3.Size = new System.Drawing.Size(150, 83);
            this.GoupBox3.TabIndex = 2;
            this.GoupBox3.TabStop = false;
            this.GoupBox3.Text = "Tổng doanh thu trong tháng";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMonth.Location = new System.Drawing.Point(6, 51);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(124, 20);
            this.lbMonth.TabIndex = 2;
            this.lbMonth.Text = "000000000VND";
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb.Controls.Add(this.lb30Days);
            this.gb.Location = new System.Drawing.Point(242, 19);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(150, 83);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Tổng doanh thu trong 30 ngày";
            // 
            // lb30Days
            // 
            this.lb30Days.AutoSize = true;
            this.lb30Days.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb30Days.Location = new System.Drawing.Point(6, 51);
            this.lb30Days.Name = "lb30Days";
            this.lb30Days.Size = new System.Drawing.Size(124, 20);
            this.lb30Days.TabIndex = 1;
            this.lb30Days.Text = "000000000VND";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.lb7Days);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(61, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng doanh thu trong 7 ngày";
            // 
            // lb7Days
            // 
            this.lb7Days.AutoSize = true;
            this.lb7Days.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb7Days.Location = new System.Drawing.Point(6, 51);
            this.lb7Days.Name = "lb7Days";
            this.lb7Days.Size = new System.Drawing.Size(124, 20);
            this.lb7Days.TabIndex = 0;
            this.lb7Days.Text = "000000000VND";
            // 
            // f_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 732);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "f_ThongKe";
            this.Text = "f_ThongKe";
            this.Load += new System.EventHandler(this.f_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GoupBox3.ResumeLayout(false);
            this.GoupBox3.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox GoupBox3;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbQuarter;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lb30Days;
        private System.Windows.Forms.Label lb7Days;
    }
}