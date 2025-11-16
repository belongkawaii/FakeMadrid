using FakeMadrid.Controllers;
using FakeMadrid.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmSignin : Form
    {
        private bool _isShowing;
        public bool isShowing
        {
            get { return _isShowing; }
            set { _isShowing = value; }
        }

        public frmSignin()
        {
            InitializeComponent();
            //bool isShowing = false;
        }


        private void frmSignin_Load(object sender, EventArgs e)
        {
            // 🔹 Ban đầu tắt nút xác nhận
            btnSignin.Enabled = false;

            #region Gắn sự kiện theo dõi khi nhập tên
            txtUser.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                bool coEmail = !string.IsNullOrWhiteSpace(txtEmail.Text);
                bool coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text);
                if (coTen && coPass && coPassCheck && coEmail) btnSignin.Enabled = true;
            };
            txtPass.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                bool coEmail = !string.IsNullOrWhiteSpace(txtEmail.Text);
                bool coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text);
                if (coTen && coPass && coPassCheck && coEmail) btnSignin.Enabled = true;
            };
            txtEmail.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                bool coEmail = !string.IsNullOrWhiteSpace(txtEmail.Text);
                bool coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text);
                if (coTen && coPass && coPassCheck && coEmail) btnSignin.Enabled = true;
            };
            txtPassCheck.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                bool coEmail = !string.IsNullOrWhiteSpace(txtEmail.Text);
                bool coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text);
                if (coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text)) lblPassCheck.Visible = false;
                else lblPassCheck.Visible = true;
                if (coTen && coPass && coPassCheck && coEmail) btnSignin.Enabled = true;
            };
            #endregion
        }


        #region Xu ly hieu ung
        private void btnSignin_MouseEnter(object sender, EventArgs e)
        {
            btnSignin.BackColor = Color.MediumSeaGreen;
            btnSignin.ForeColor = Color.White;
        }

        private void btnSignin_MouseLeave(object sender, EventArgs e)
        {
            btnSignin.BackColor = SystemColors.Control;
            btnSignin.ForeColor = Color.Black;
        }
        #endregion 

        #region Xu Ly Event Click 

        private void SeePass_Click(object sender, EventArgs e)
        {

            if (isShowing)
            {
                // Ẩn lại thành *
                txtPass.PasswordChar = '*';
                txtPassCheck.PasswordChar = '*';
                SeePass.Text = "🙈";
                isShowing = false;
            }
            else
            {
                // Hiển thị mật khẩu
                txtPass.PasswordChar = '\0';
                txtPassCheck.PasswordChar = '\0';
                SeePass.Text = "👁";
                isShowing = true;
            }
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "" || txtPass.Text == "" || txtEmail.Text == "" || txtPassCheck.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPass.Text != txtPassCheck.Text)
            {
                lblPassCheck.Visible = true;
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (KiemTraEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }

            string taikhoan = txtUser.Text;
            string email = txtEmail.Text;
            string matkhau = txtPass.Text;
            string otp = new Random().Next(1000, 9999).ToString();

            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(matkhau + otp);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account nd = new Account
            {

                Username = taikhoan,
                Password = hashBytes,
                Email = email,
                RandomKey = otp,
                OTP = otp,
                OTPDateSend = DateTime.Now,
                DateCreated = DateTime.Now,
                Active = false,
                DateActive = null,
                IDLevel = 3
            };

            db.Accounts.InsertOnSubmit(nd);
            db.SubmitChanges();

            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Gửi email xác thực 
            SendMail.sendMailTo(nd.Email, "Mã OTP xác thực là: " + nd.OTP);
            nd.OTPDateSend = DateTime.Now; //Kiểm soát thời gian hiệu lực 3 phút
            db.SubmitChanges();

            frmXacThuc frm = new frmXacThuc(nd.Username);
            frm.Show();

            this.Close();
        }

        public bool KiemTraEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        #endregion


    }
}
