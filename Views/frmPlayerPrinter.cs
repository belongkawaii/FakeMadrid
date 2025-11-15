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
            //Truyền thông tin dữ liệu vào data
            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("nguoidung", "CEO");
            this.reportViewer1.LocalReport.SetParameters(para); //Truyền dữ liệu vào report
            this.reportViewer1.LocalReport.DataSources.Clear();

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource ("DataSetPlayer", db.Players.OrderBy(p => p.player_id)));

            this.reportViewer1.RefreshReport();
        }
    }
}
