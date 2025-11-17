using FakeMadrid.Controllers;
using FakeMadrid.Database;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmAccountPrinter : Form
    {
        public frmAccountPrinter()
        {
            InitializeComponent();
        }

        string IdLevel;
        public frmAccountPrinter(string _IdLevel)
        {
            InitializeComponent();
            IdLevel = _IdLevel;
        }

        private void frmAccountPrinter_Load(object sender, EventArgs e)
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // Đếm tổng số người dùng
            int soLuong = db.Accounts.Count();

            // Tạo parameter
            ReportParameter[] para = new ReportParameter[2];
            para[0] = new ReportParameter("nguoidung", SessionManager.LoggedUser);
            para[1] = new ReportParameter("soluong", soLuong.ToString());

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(para);

            // Load toàn bộ Account KHÔNG ĐIỀU KIỆN
            this.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetAccount",
                    db.Accounts.OrderBy(p => p.ID))
            );

            this.reportViewer1.RefreshReport();
            
        }

        
    }
}
