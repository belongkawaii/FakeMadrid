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
            bool isShowing = false;
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
                bool coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text);
                if (coTen && coPass && coPassCheck) btnSignin.Enabled = true;
            };
            txtPass.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                bool coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text);
                if (coTen && coPass && coPassCheck) btnSignin.Enabled = true;
            };
            txtPassCheck.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                bool coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text);
                if (coPassCheck = !string.IsNullOrWhiteSpace(txtPassCheck.Text)) lblPassCheck.Visible = false;
                else lblPassCheck.Visible = true;
                if (coTen && coPass && coPassCheck) btnSignin.Enabled = true;
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
           //kiem tra dien thong tin day du
           if(txtUser.Text == "" || txtPass.Text == "" || txtPassCheck.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //kiem tra mat khau co trung lap
            if(txtPass.Text != txtPassCheck.Text)
            {
                lblPassCheck.Visible = true;
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //tao ma OTP ngau nhien
            string taikhoan = txtUser.Text;
            string matkhau = txtPass.Text;
            Random rd = new Random();
            string otp = rd.Next(1000, 9999).ToString();

            //ma hoa mat khau
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(matkhau+otp);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            //tao va them vao csdl
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account nd = new Account();
            nd.Username = taikhoan;
            nd.Password = hashBytes;
            nd.Email = "";
            nd.OTP = otp;
            nd.OTPDateSend = DateTime.Now;
            nd.DateCreated = DateTime.Now;
            nd.Active = false;
            nd.DateActive = null;
            nd.IDLevel = 3; //tao acc nguoi xem

            db.Accounts.InsertOnSubmit(nd);
            db.SubmitChanges();
            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion


    }
}
