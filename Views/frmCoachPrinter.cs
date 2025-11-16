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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FakeMadrid.Views
{
    public partial class frmCoachPrinter : Form
    {
        public frmCoachPrinter()
        {
            InitializeComponent();
        }
        string Role;

        public frmCoachPrinter(string _Role)
        {
            InitializeComponent();
            Role = _Role;
        }

        private void frmCoachPrinter_Load(object sender, EventArgs e)
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // Đếm số lượng
            int soLuong = (Role == "All")
                ? db.Coaches.Count()
                : db.Coaches.Count(p => p.role == Role);

            // Tạo parameter
            ReportParameter[] para = new ReportParameter[3];
            para[0] = new ReportParameter("nguoidung", SessionManager.LoggedUser);
            para[1] = new ReportParameter("soluong", soLuong.ToString());
            para[2] = new ReportParameter("role", Role);

            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.SetParameters(para);

            // Load data
            if (Role == "All")
            {
                this.reportViewer2.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetCoach",
                    db.Coaches.OrderBy(p => p.coach_id))
                );
            }
            else
            {
                this.reportViewer2.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetCoach",
                    db.Coaches.Where(p => p.role == Role).OrderBy(p => p.coach_id))
                );
            }
            this.reportViewer2.RefreshReport();
        }
    }
}
