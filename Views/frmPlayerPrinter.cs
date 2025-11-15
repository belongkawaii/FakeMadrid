using FakeMadrid.Controllers;
using FakeMadrid.Database;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmPlayerPrinter : Form
    {
        public frmPlayerPrinter()
        {
            InitializeComponent();
        }

        string Status;

        public frmPlayerPrinter(string _Status)
        {
            InitializeComponent();
            Status = _Status;
        }
        private void frmPlayerPrinter_Load(object sender, EventArgs e)
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // Đếm số lượng
            int soLuong = (Status == "All")
                ? db.Players.Count()
                : db.Players.Count(p => p.status == Status);

            // Tạo parameter
            ReportParameter[] para = new ReportParameter[3];
            para[0] = new ReportParameter("nguoidung", SessionManager.LoggedUser);
            para[1] = new ReportParameter("Status", Status);
            para[2] = new ReportParameter("soluong", soLuong.ToString());  // <-- Quan trọng

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(para);

            // Load data
            if (Status == "All")
            {
                this.reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetPlayer",
                    db.Players.OrderBy(p => p.player_id))
                );
            }
            else
            {
                this.reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetPlayer",
                    db.Players.Where(p => p.status == Status).OrderBy(p => p.player_id))
                );
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
