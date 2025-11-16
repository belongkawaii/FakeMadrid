using FakeMadrid.Controllers;
using FakeMadrid.Database;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
using static System.Net.WebRequestMethods;

namespace FakeMadrid.Views
{
    public partial class frmLogin : Form
    {
        private int iCount = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // 🔹 Ban đầu tắt nút xác nhận
            btnLogin.Enabled = false;

            txtUser.TextChanged += ValidateInput;
            txtPass.TextChanged += ValidateInput;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUser.Text) &&
                               !string.IsNullOrWhiteSpace(txtPass.Text);
        }


        #region Xu ly hieu ung
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.ForeColor = Color.Black;
        }
        #endregion 

        #region Xu Ly Event Click

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPass forgetPass = new frmForgetPass();
            forgetPass.ShowDialog();

        }
        public bool IsLoginSuccess = false;
        public string LoggedUser = "";
        private bool isShowing;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account nd = db.Accounts.SingleOrDefault(p => p.Username == user);
            //Account mknd = db.Accounts.SingleOrDefault(p => p.Password == pass);
            if (nd != null)
            {
                //Kiểm tra mật khẩu đang lưu trữ trong db
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.UTF8.GetBytes(pass + nd.OTP);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                if (nd.Password == hashBytes)
                {
                    // Lưu vào session
                    SessionManager.LoggedUser = nd.Username;
                    SessionManager.LoggedLevel = (int)nd.IDLevel;
                    MessageBox.Show("Xin chào " + nd.Username + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {
                    iCount++;
                    if (iCount >= 3)
                    {
                        MessageBox.Show("Bạn đã nhập sai quá nhiều lần.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.Số lần nhập còn lại " + (3 - iCount), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblForgetPass.Visible = true;
                }
            }
            else
            {
                iCount++;
                if (iCount >= 3)
                {
                    MessageBox.Show("Bạn đã nhập sai quá nhiều lần.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.Số lần nhập còn lại " + (3 - iCount), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblForgetPass.Visible = true;
            }


        }

        private void SeePass_Click(object sender, EventArgs e)
        {

            if (isShowing)
            {
                // Ẩn lại thành *
                txtPass.PasswordChar = '*';
                SeePass.Text = "🙈";
                isShowing = false;
            }
            else
            {
                // Hiển thị mật khẩu
                txtPass.PasswordChar = '\0';
                SeePass.Text = "👁";
                isShowing = true;
            }
        }
        #endregion

        private void btnLogin_MouseEnter_1(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave_1(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.ForeColor = Color.Black;
        }

        
    }
}
