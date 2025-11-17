using FakeMadrid.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FakeMadrid.Views
{
    public partial class frmCoachContract : Form
    {
        private string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public frmCoachContract(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void frmCoachContract_Load(object sender, EventArgs e)
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Coach nd = db.Coaches.SingleOrDefault(p => p.email == Username);
            lblText.Text = "Huấn Luyện Viên " + nd.coach_name + " , sinh ngày " + nd.coach_birthday + " , ký hợp đồng với câu lạc bộ vào ngày " + nd.hire_date + ", thời hạn đến ngày " + nd.contract_end_date + ", với mức lương " + nd.salary + " VND." + "\r\n\r\n ĐẠI DIỆN BÊN A (CLB)\r\n\r\nKý & ghi rõ họ tên: TRAN NGUYEN XUAN SON\r\n\r\nĐẠI DIỆN BÊN B (Huấn Luyện Viên)\r\n\r\nKý & ghi rõ họ tên: " + nd.coach_name;
        }
    }
}
