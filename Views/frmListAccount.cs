using FakeMadrid.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmListAccount : Form
    {
        public frmListAccount()
        {
            InitializeComponent();
        }

        private void frmListAccount_Load(object sender, EventArgs e)
        {
            // --- Tạo dữ liệu cho ComboBox Level ---
            var levels = new List<dynamic>
            {
                new { Text = "All",    Value = -1 },
                new { Text = "CEO",    Value = 0 },
                new { Text = "Coach",  Value = 1 },
                new { Text = "Player", Value = 2 },
                new { Text = "Viewer", Value = 3 }
            };

            cbbLevel.DataSource = levels;
            cbbLevel.DisplayMember = "Text";   // Hiện chữ
            cbbLevel.ValueMember = "Value";    // Lấy số

            cbbLevel.SelectedIndex = 0; // chọn dòng đầu (tùy bạn)

            loadData(); // load bảng
        }

        private void loadData()
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            int? level = cbbLevel.SelectedValue as int?;

            if (level == null || level == -1)   // Nếu bạn muốn "All" thì Value = -1
            {
                dgvAccount.DataSource = db.Accounts
                    .OrderBy(p => p.ID)
                    .Select(p => new
                    {
                        p.ID,
                        p.Username,
                        p.Email,
                        p.OTP,
                        p.OTPDateSend,
                        p.DateCreated,
                        p.Active,
                        p.DateActive,
                        p.IDLevel
                    }).ToList();
            }
            else
            {
                dgvAccount.DataSource = db.Accounts
                    .Where(p => p.IDLevel == level)
                    .OrderBy(p => p.ID)
                   .Select(p => new
                    {
                        p.ID,
                        p.Username,
                        p.Email,
                        p.OTP,
                        p.OTPDateSend,
                        p.DateCreated,
                        p.Active,
                        p.DateActive,
                        p.IDLevel
                    }).ToList();
            }

            // Format ngày
            dgvAccount.Columns["DateActive"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAccount.Columns["OTPDateSend"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAccount.Columns["DateCreated"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // ============================================================
        // ===============  NÚT CHỨC NĂNG =============================
        // ============================================================

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ID
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("ID phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string otp = txtOTP.Text;

            bool active = cbbActive.SelectedItem.ToString() == "True";

            int idLevel = (int)cbbLevel.SelectedValue;

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // kiểm tra tồn tại
            if (db.Accounts.Any(p => p.ID == id))
            {
                MessageBox.Show("ID đã tồn tại!", "Thông báo");
                return;
            }

            Account acc = new Account()
            {
                ID = id,
                Username = username,
                Email = email,
                OTP = otp,
                Active = active,
                IDLevel = idLevel,
                DateActive = dtpNgayKichHoat.Value,
                OTPDateSend = dtpNgayTaoOTP.Value,
                DateCreated = dtpNgayTaoTaiKhoan.Value
            };

            db.Accounts.InsertOnSubmit(acc);
            db.SubmitChanges();

            loadData();

            MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
                return;

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            Account acc = db.Accounts.Where(p => p.ID == id).SingleOrDefault();
            if (acc == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool active = cbbActive.SelectedItem.ToString() == "True";
            acc.Username = txtUsername.Text;
            acc.Email = txtEmail.Text;
            acc.OTP = txtOTP.Text;
            acc.Active = active;
            acc.IDLevel = (int)cbbLevel.SelectedValue;
            acc.DateActive = dtpNgayKichHoat.Value;
            acc.OTPDateSend = dtpNgayTaoOTP.Value;
            acc.DateCreated = dtpNgayTaoTaiKhoan.Value;

            db.SubmitChanges();

            loadData();
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
                return;

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            Account acc = db.Accounts.Where(p => p.ID == id).SingleOrDefault();
            if (acc == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Accounts.DeleteOnSubmit(acc);
            db.SubmitChanges();

            loadData();
            MessageBox.Show("Xóa thành công!", "Thông báo");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            dgvAccount.DataSource = db.Accounts
                .Where(p => p.Username.Contains(search) || p.ID.ToString().Contains(search))
                .ToList();
        }

        // ============================================================
        // ===============  CLICK DATA GRID ============================
        // ============================================================

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r < 0) return;

            int id = int.Parse(dgvAccount.Rows[r].Cells["ID"].Value.ToString());
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Account acc = db.Accounts.Where(p => p.ID == id).SingleOrDefault();

            if (acc != null)
            {
                txtID.Text = acc.ID.ToString();
                txtUsername.Text = acc.Username;
                txtEmail.Text = acc.Email;
                txtOTP.Text = acc.OTP;
                cbbActive.SelectedItem = acc.Active;
                cbbLevel.SelectedValue = acc.IDLevel;

                dtpNgayKichHoat.Value = acc.DateActive ?? DateTime.Now;
                dtpNgayTaoOTP.Value = acc.OTPDateSend ?? DateTime.Now;
                dtpNgayTaoTaiKhoan.Value = acc.DateCreated ?? DateTime.Now;
            }
        }

        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
