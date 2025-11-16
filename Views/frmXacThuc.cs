using FakeMadrid.Controllers;
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
    public partial class frmXacThuc : Form
    {
        string taikhoan = SessionManager.LoggedUser;
        public frmXacThuc()
        {
            InitializeComponent();
        }

        public frmXacThuc(string _taikhoan)
        {
            InitializeComponent();
            taikhoan = _taikhoan;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Gửi lại mail xác thực
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account nd = db.Accounts.SingleOrDefault(p => p.Username == taikhoan);

            if (nd != null)
            {
                if (nd.OTP == txtOTP.Text)
                {
                    DateTime otpdatasend = (DateTime)nd.OTPDateSend;
                    if ((DateTime.Now - otpdatasend).TotalMinutes <= 3)
                    {
                        nd.DateActive = DateTime.Now;
                        nd.Active = true;
                        db.SubmitChanges();
                        MessageBox.Show("Đã kích hoạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã OTP hết hiệu lực! Vui lòng nhập lại mã OTP mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnGuiLai_Click(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Mã OTP không chính xác! Vui lòng nhập lại mã OTP mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            }

        private void btnGuiLai_Click(object sender, EventArgs e)
        {
            //Gửi lại mail xác thực
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account nd = db.Accounts.SingleOrDefault(p => p.Username == taikhoan);

            if (nd != null)
            {
                Random rd = new Random();
                nd.OTP = rd.Next(1000, 9999).ToString();
                SendMail.sendMailTo(nd.Email, "Mã OTP xác thực là: " + nd.OTP);
                nd.OTPDateSend = DateTime.Now; //Kiểm soát thời gian hiệu lực 3 phút
                db.SubmitChanges();
                MessageBox.Show("Đã gửi lại mã OTP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
