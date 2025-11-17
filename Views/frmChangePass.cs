using FakeMadrid.Controllers;
using FakeMadrid.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FakeMadrid.Views
{
    public partial class frmChangePass : Form
    {
        private string _Taikhoan;
        
        public string Taikhoan
        {
            get { return _Taikhoan; }
            set { _Taikhoan = value; }
        }

        private bool _isShowing;
        public bool isShowing
        {
            get { return _isShowing; }
            set { _isShowing = value; }
        }
        public frmChangePass(string username)
        {
            InitializeComponent();
            //isShowing = false;
            //Taikhoan = username;
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!KiemTraPassHopLe(txtNewPass.Text))
            {
                MessageBox.Show("Mật khẩu phải có cả chữ và số!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string pass = txtPass.Text;
            string newPass = txtNewPass.Text;
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account nd = db.Accounts.SingleOrDefault(p => p.Username == Taikhoan);
            //Account mknd = db.Accounts.SingleOrDefault(p => p.Password == pass);
            if (nd != null)
            {
                //Kiểm tra mật khẩu đang lưu trữ trong db
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.UTF8.GetBytes(pass + nd.OTP);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
               
                if (nd.Password == hashBytes)
                {
                    // Hash mật khẩu mới
                    MD5 md5new = MD5.Create();
                    byte[] NewinputBytes = Encoding.UTF8.GetBytes(newPass + nd.OTP);
                    byte[] NewhashBytes = md5new.ComputeHash(NewinputBytes);
                    if (nd.Password == NewhashBytes)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                        // Cập nhật DB
                    nd.Password = NewhashBytes;
                    db.SubmitChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtPass.Clear();
                    txtNewPass.Clear();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
              MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void SeePass_Click(object sender, EventArgs e)
        {

            if (isShowing)
            {
                // Ẩn lại thành *
                txtPass.PasswordChar = '*';
                txtNewPass.PasswordChar = '*';
                SeePass.Text = "🙈";
                isShowing = false;
            }
            else
            {
                // Hiển thị mật khẩu
                txtPass.PasswordChar = '\0';
                txtNewPass.PasswordChar = '\0';
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

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUser.Text = Taikhoan;
        }
    }
}
