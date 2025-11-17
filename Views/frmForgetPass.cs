using FakeMadrid.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FakeMadrid.Views
{
    public partial class frmForgetPass : Form
    {
        public frmForgetPass()
        {
            InitializeComponent();
            //isShowing = false;
        }

      

        private bool _isShowing;
        public bool isShowing
        {
            get { return _isShowing; }
            set { _isShowing = value; }
        }


        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (KiemTraEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }

            if (!KiemTraPassHopLe(txtPass.Text))
            {
                MessageBox.Show("Mật khẩu phải có cả chữ và số!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;
            string email = txtEmail.Text.Trim();
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account nd = db.Accounts.SingleOrDefault(p => p.Username == user);
            if (nd != null)
            {
                if (nd.Email == email)
                {
                    // Hash mật khẩu mới
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = Encoding.UTF8.GetBytes(pass + nd.OTP);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    // Cập nhật DB
                    nd.Password = hashBytes;
                    db.SubmitChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtPass.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc emai; không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc email không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public bool KiemTraEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private void SeePass_Click(object sender, EventArgs e)
        {

            if (isShowing)
            {
                // Ẩn lại thành *
                txtPass.PasswordChar = '*';
                txtPass.PasswordChar = '*';
                SeePass.Text = "🙈";
                isShowing = false;
            }
            else
            {
                // Hiển thị mật khẩu
                txtPass.PasswordChar = '\0';
                txtPass.PasswordChar = '\0';
                SeePass.Text = "👁";
                isShowing = true;
            }
        }
        private bool KiemTraPassHopLe(string pass)
        {
            // Có ít nhất 1 chữ cái
            bool coChu = pass.Any(char.IsLetter);

            // Có ít nhất 1 chữ số
            bool coSo = pass.Any(char.IsDigit);

            return coChu && coSo;
        }
    }
}
