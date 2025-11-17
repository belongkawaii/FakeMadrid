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

namespace FakeMadrid.Views
{
    public partial class frmPlayerContract : Form
    {
        private string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public frmPlayerContract(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void frmPlayerContract_Load(object sender, EventArgs e)
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Player nd = db.Players.SingleOrDefault(p => p.email == Username);
            lblText.Text = "Cầu thủ " + nd.player_name + " , sinh ngày " + nd.date_of_birth + " , ký hợp đồng với câu lạc bộ vào ngày " + nd.join_date + ", thời hạn đến ngày " + nd.contract_end_date + ", với mức lương " + nd.salary + " VND." + "\r\n\r\n ĐẠI DIỆN BÊN A (CLB)\r\n\r\nKý & ghi rõ họ tên: TRAN NGUYEN XUAN SON\r\n\r\nĐẠI DIỆN BÊN B (CẦU THỦ)\r\n\r\nKý & ghi rõ họ tên: " +nd.player_name;
        }
    }
}
