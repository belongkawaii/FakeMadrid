using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FakeMadrid.Views
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //crtTranDau.Series["Số trận đấu"].Points.AddXY("Real Madrid", 38);
            //crtTranDau.Series["Số trận đấu"].Points.AddXY("Barcelona", 20);
            //crtTranDau.Series["Số trận đấu"].Points.AddXY("Atletico Madrid", 25);
            //crtTranDau.Series["Số trận đấu"].Points.AddXY("Sevilla", 30);
            //crtTranDau.Series["Số trận đấu"].Points.AddXY("Valencia", 15);
            //crtTranDau.Series["Số trận đấu"].Points.AddXY("Villarreal", 18);

            //crtBieuDo.Series["Euro"].Points.AddXY("2019", 1000000000);
            //crtBieuDo.Series["Euro"].Points.AddXY("2020", 1500000000);
            //crtBieuDo.Series["Euro"].Points.AddXY("2021", 2000000000);
            //crtBieuDo.Series["Euro"].Points.AddXY("2022", 2500000000);
            //crtBieuDo.Series["Euro"].Points.AddXY("2023", 3000000000);

            //crtPhanTramTienThu.Series["Phần trăm tiền thu"].Points.AddXY("Vé xem trận đấu", 40);
            //crtPhanTramTienThu.Series["Phần trăm tiền thu"].Points.AddXY("Quảng cáo", 30);
            //crtPhanTramTienThu.Series["Phần trăm tiền thu"].Points.AddXY("Bán đồ lưu niệm", 20);
            //crtPhanTramTienThu.Series["Phần trăm tiền thu"].Points.AddXY("Các nguồn khác", 10);
            // crtTranDau
            crtTranDau.Series.Clear(); // loại bỏ series cũ
            var seriesTranDau = crtTranDau.Series.Add("Số trận đấu");
            seriesTranDau.ChartType = SeriesChartType.Column;

            seriesTranDau.Points.AddXY("Real Madrid", 38);
            seriesTranDau.Points.AddXY("Barcelona", 20);
            seriesTranDau.Points.AddXY("Atletico Madrid", 25);
            seriesTranDau.Points.AddXY("Sevilla", 30);
            seriesTranDau.Points.AddXY("Valencia", 15);
            seriesTranDau.Points.AddXY("Villarreal", 18);

            // crtBieuDo
            crtBieuDo.Series.Clear();
            var seriesEuro = crtBieuDo.Series.Add("Euro");
            seriesEuro.ChartType = SeriesChartType.Line;

            seriesEuro.Points.AddXY("2019", 1000000000);
            seriesEuro.Points.AddXY("2020", 1500000000);
            seriesEuro.Points.AddXY("2021", 2000000000);
            seriesEuro.Points.AddXY("2022", 2500000000);
            seriesEuro.Points.AddXY("2023", 3000000000);

            // crtPhanTramTienThu
            crtPhanTramTienThu.Series.Clear();
            var seriesPhanTram = crtPhanTramTienThu.Series.Add("Phần trăm tiền thu");
            seriesPhanTram.ChartType = SeriesChartType.Pie;

            seriesPhanTram.Points.AddXY("Vé xem trận đấu", 40);
            seriesPhanTram.Points.AddXY("Quảng cáo", 30);
            seriesPhanTram.Points.AddXY("Bán đồ lưu niệm", 20);
            seriesPhanTram.Points.AddXY("Các nguồn khác", 10);
        }

    }
}
