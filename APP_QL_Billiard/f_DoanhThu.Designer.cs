namespace APP_QL_Billiard
{
    partial class f_DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chartQuarters = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbQuarter = new System.Windows.Forms.ComboBox();
            this.chartQuarter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart30Days = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart7Days = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarters)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarter)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart30Days)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart7Days)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 727);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chartQuarters);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 544);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 180);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doanh thu các quý";
            // 
            // chartQuarters
            // 
            chartArea6.Name = "ChartArea1";
            this.chartQuarters.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartQuarters.Legends.Add(legend6);
            this.chartQuarters.Location = new System.Drawing.Point(4, 25);
            this.chartQuarters.Name = "chartQuarters";
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.LegendText = "Quý";
            series6.Name = "S1";
            this.chartQuarters.Series.Add(series6);
            this.chartQuarters.Size = new System.Drawing.Size(421, 136);
            this.chartQuarters.TabIndex = 3;
            this.chartQuarters.Text = "chart4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbQuarter);
            this.groupBox3.Controls.Add(this.chartQuarter);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doanh thu trong quý";
            // 
            // cbbQuarter
            // 
            this.cbbQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuarter.FormattingEnabled = true;
            this.cbbQuarter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbQuarter.Location = new System.Drawing.Point(432, 15);
            this.cbbQuarter.Name = "cbbQuarter";
            this.cbbQuarter.Size = new System.Drawing.Size(44, 28);
            this.cbbQuarter.TabIndex = 2;
            this.cbbQuarter.SelectedIndexChanged += new System.EventHandler(this.cbbQuarter_SelectedIndexChanged);
            // 
            // chartQuarter
            // 
            chartArea5.Name = "ChartArea1";
            this.chartQuarter.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartQuarter.Legends.Add(legend5);
            this.chartQuarter.Location = new System.Drawing.Point(5, 25);
            this.chartQuarter.Name = "chartQuarter";
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.LegendText = "Tháng";
            series5.Name = "S1";
            this.chartQuarter.Series.Add(series5);
            this.chartQuarter.Size = new System.Drawing.Size(420, 136);
            this.chartQuarter.TabIndex = 1;
            this.chartQuarter.Text = "chart3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart30Days);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doanh thu trong 30 ngày";
            // 
            // chart30Days
            // 
            chartArea7.Name = "ChartArea1";
            this.chart30Days.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart30Days.Legends.Add(legend7);
            this.chart30Days.Location = new System.Drawing.Point(7, 23);
            this.chart30Days.Name = "chart30Days";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.IsValueShownAsLabel = true;
            series7.IsXValueIndexed = true;
            series7.Legend = "Legend1";
            series7.LegendText = "Ngày";
            series7.Name = "S1";
            this.chart30Days.Series.Add(series7);
            this.chart30Days.Size = new System.Drawing.Size(421, 136);
            this.chart30Days.TabIndex = 0;
            this.chart30Days.Text = "chart2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart7Days);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu trong 7 ngày";
            // 
            // chart7Days
            // 
            chartArea8.Name = "ChartArea1";
            this.chart7Days.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart7Days.Legends.Add(legend8);
            this.chart7Days.Location = new System.Drawing.Point(6, 23);
            this.chart7Days.Name = "chart7Days";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series8.IsValueShownAsLabel = true;
            series8.IsXValueIndexed = true;
            series8.Legend = "Legend1";
            series8.LegendText = "Ngày";
            series8.Name = "S1";
            series8.YValuesPerPoint = 4;
            this.chart7Days.Series.Add(series8);
            this.chart7Days.Size = new System.Drawing.Size(421, 136);
            this.chart7Days.TabIndex = 0;
            this.chart7Days.Text = "chart1";
            // 
            // f_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 740);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "f_DoanhThu";
            this.Text = "f_DoanhThu";
            this.Load += new System.EventHandler(this.f_DoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarters)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart30Days)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart7Days)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbQuarter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuarter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart30Days;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart7Days;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuarters;
    }
}