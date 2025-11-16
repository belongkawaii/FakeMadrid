namespace FakeMadrid
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crtTranDau = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.crtPhanTramTienThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.crtDoanhThuTheoNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtTranDau)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtPhanTramTienThu)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtDoanhThuTheoNam)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1878, 1044);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDoanhThu);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1863, 88);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1109, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "+ 1,6 %";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(537, 26);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(474, 32);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "Tổng doanh thu: 1.073.890.600  €";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crtTranDau);
            this.panel2.Location = new System.Drawing.Point(3, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 294);
            this.panel2.TabIndex = 3;
            // 
            // crtTranDau
            // 
            chartArea1.Name = "ChartArea1";
            this.crtTranDau.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtTranDau.Legends.Add(legend1);
            this.crtTranDau.Location = new System.Drawing.Point(9, 2);
            this.crtTranDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtTranDau.Name = "crtTranDau";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Legend = "Legend1";
            series1.Name = "Trận đấu";
            this.crtTranDau.Series.Add(series1);
            this.crtTranDau.Size = new System.Drawing.Size(862, 261);
            this.crtTranDau.TabIndex = 0;
            this.crtTranDau.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.crtPhanTramTienThu);
            this.panel4.Location = new System.Drawing.Point(883, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(975, 294);
            this.panel4.TabIndex = 4;
            // 
            // crtPhanTramTienThu
            // 
            chartArea2.Name = "ChartArea1";
            this.crtPhanTramTienThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtPhanTramTienThu.Legends.Add(legend2);
            this.crtPhanTramTienThu.Location = new System.Drawing.Point(67, 2);
            this.crtPhanTramTienThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtPhanTramTienThu.Name = "crtPhanTramTienThu";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.crtPhanTramTienThu.Series.Add(series2);
            this.crtPhanTramTienThu.Size = new System.Drawing.Size(876, 273);
            this.crtPhanTramTienThu.TabIndex = 0;
            this.crtPhanTramTienThu.Text = "chart2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.crtDoanhThuTheoNam);
            this.panel3.Location = new System.Drawing.Point(3, 392);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1863, 631);
            this.panel3.TabIndex = 2;
            // 
            // crtDoanhThuTheoNam
            // 
            chartArea3.Name = "ChartArea1";
            this.crtDoanhThuTheoNam.ChartAreas.Add(chartArea3);
            this.crtDoanhThuTheoNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend3.Name = "Legend1";
            this.crtDoanhThuTheoNam.Legends.Add(legend3);
            this.crtDoanhThuTheoNam.Location = new System.Drawing.Point(35, 34);
            this.crtDoanhThuTheoNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtDoanhThuTheoNam.Name = "crtDoanhThuTheoNam";
            this.crtDoanhThuTheoNam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Euro";
            this.crtDoanhThuTheoNam.Series.Add(series3);
            this.crtDoanhThuTheoNam.Size = new System.Drawing.Size(1793, 557);
            this.crtDoanhThuTheoNam.TabIndex = 0;
            this.crtDoanhThuTheoNam.Text = "chart1";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1878, 1044);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKe";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtTranDau)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtPhanTramTienThu)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtDoanhThuTheoNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtDoanhThuTheoNam;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtTranDau;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtPhanTramTienThu;
    }
}