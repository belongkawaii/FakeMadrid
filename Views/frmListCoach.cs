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
    public partial class frmListCoach : Form
    {
        public frmListCoach()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmListCoach_Load(object sender, EventArgs e)
        {
            cbbRole.SelectedIndex = 0;
            loadData();
           
        
        }
        private void loadData()
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            string role = cbbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(role) || role == "All")
            {
                dgvCoach.DataSource = db.Coaches
                    .OrderBy(p => p.coach_id)
                    .Select(p => new
                    {
                        p.coach_id,
                        p.coach_name,
                        p.coach_birthday,
                        p.nationality,
                        p.role,
                        p.hire_date,
                        p.contract_end_date,
                        p.salary,
                        p.phone,
                        p.email
                    })
                    .ToList();
            }
            else
            {
                dgvCoach.DataSource = db.Coaches
                    .Where(p => p.role == role)
                    .OrderBy(p => p.coach_id)
                    .Select(p => new
                    {
                        p.coach_id,
                        p.coach_name,
                        p.coach_birthday,
                        p.nationality,
                        p.role,
                        p.hire_date,
                        p.contract_end_date,
                        p.salary,
                        p.phone,
                        p.email
                    })
                    .ToList();
            }

            dgvCoach.Columns["coach_birthday"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCoach.Columns["coach_hiredate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCoach.Columns["coach_contract"].DefaultCellStyle.Format = "dd/MM/yyyy";


        }
        #region Nút chức năng

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ID
            if (string.IsNullOrWhiteSpace(txtCoachId.Text))
            {
                MessageBox.Show("Bạn phải nhập ID HLV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoachId.Focus();
                return;
            }

            if (!int.TryParse(txtCoachId.Text, out int coachId))
            {
                MessageBox.Show("ID HLV phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoachId.Focus();
                return;
            }

            // 2. Lấy dữ liệu từ form
            string coachName = txtCoachName.Text;
            if (string.IsNullOrWhiteSpace(coachName))
            {
                MessageBox.Show("Bạn phải nhập tên HLV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoachName.Focus();
                return;
            }

            string role = cbbRole.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Bạn phải chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbRole.Focus();
                return;
            }

            DateTime dateOfBirth = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string nationality = txtQuocTich.Text;
            DateTime joinDate = dtpNgayGiaHan.Value;
            DateTime contractEndDate = dtpNgayHetHan.Value;

            if (!decimal.TryParse(txtLuong.Text, out decimal salary))
            {
                MessageBox.Show("Lương phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }

            // 3. Kết nối DB
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // 4. Kiểm tra trùng ID
            Coach coach = db.Coaches.Where(p => p.coach_id == coachId).SingleOrDefault();
            if (coach != null)
            {
                MessageBox.Show("Mã cầu thủ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCoachId.Focus();
                return;
            }

            // 5. Tạo mới Player và gán dữ liệu
            coach = new Coach();
            coach.coach_id = coachId;
            coach.coach_name = coachName;
            coach.role = role;
            coach.coach_birthday = dateOfBirth;
            coach.email = email;
            coach.phone = phone;
            coach.nationality = nationality;
            coach.hire_date = joinDate;
            coach.contract_end_date = contractEndDate;
            coach.salary = salary;
            // 6. Thêm và lưu DB
            db.Coaches.InsertOnSubmit(coach);
            db.SubmitChanges();

            // 7. Load lại dữ liệu và thông báo
            loadData();
            MessageBox.Show("Thêm mới HLV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu input từ form
            int coachId = int.Parse(txtCoachId.Text); // IDENTITY, dùng để tìm bản ghi
            string coachName = txtCoachName.Text;
            string role = cbbRole.SelectedItem.ToString();
            DateTime dateOfBirth = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string nationality = txtQuocTich.Text;
            DateTime hireDate = dtpNgayGiaHan.Value;
            DateTime contractEndDate = dtpNgayHetHan.Value;
            decimal salary = decimal.Parse(txtLuong.Text);

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // Tìm cầu thủ theo player_id
            Coach coach = db.Coaches.Where(p => p.coach_id == coachId).SingleOrDefault();
            if (coach == null)
            {
                MessageBox.Show("Mã HLV không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCoachId.Focus();
                return;
            }
            else
            {

                // Cập nhật thông tin
                coach.coach_name = coachName;
                coach.role = role;
                coach.coach_birthday = dateOfBirth;
                coach.email = email;
                coach.phone = phone;
                coach.nationality = nationality;
                coach.hire_date = hireDate;
                coach.contract_end_date = contractEndDate;
                coach.salary = salary;

                db.SubmitChanges(); // lưu vào DB

                loadData(); // load lại DataGridView
                MessageBox.Show("Cập nhật HLV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string timKiem = txtSearch.Text;
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            if (string.IsNullOrEmpty(timKiem))
            {
                loadData();
            }
            else
            {
                dgvCoach.DataSource = db.Coaches   
                    .Where(p => p.coach_name.Contains(timKiem) || p.coach_id.ToString().Contains(timKiem))
                    .ToList();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmCoachPrinter frm = new frmCoachPrinter(cbbRole.SelectedItem.ToString()); 
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int coachId = int.Parse(txtCoachId.Text);

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Coach coach = db.Coaches.Where(p => p.coach_id == coachId).SingleOrDefault();

            if (coach == null)
            {
                MessageBox.Show("Mã cầu thủ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCoachId.Focus();
                return;
            }
            else
            {

                var contracts = db.Contracts.Where(c => c.coach_id == coachId).ToList();
                db.Contracts.DeleteAllOnSubmit(contracts);

                db.SubmitChanges(); // Xóa tất cả dữ liệu liên quan trước


                // Sau đó mới xóa coach
                db.Coaches.DeleteOnSubmit(coach);
                db.SubmitChanges();


                loadData(); // load lại DataGridView
                MessageBox.Show("Xóa cầu thủ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Truyền dữ liệu từ db
        private void dgvCoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xác định cái Row đang chọn
            int idrow = e.RowIndex;
            if (idrow == -1) return; //header
            hienThiDuLieuDong(idrow);
        }

        private void hienThiDuLieuDong(int idrow)
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            int id = int.Parse(dgvCoach.Rows[idrow].Cells[0].Value.ToString());
            //Hiển thị dữ liệu
            Coach coach = db.Coaches.Where(p => p.coach_id == id).SingleOrDefault();
            if (coach != null)
            {
                txtCoachId.Text = coach.coach_id.ToString();
                txtCoachName.Text = coach.coach_name;
                cbbRole.SelectedItem = coach.role;
                dtpNgaySinh.Value = coach.coach_birthday.Value;
                txtEmail.Text = coach.email;
                txtPhoneNumber.Text = coach.phone;
                txtQuocTich.Text = coach.nationality;
                dtpNgayGiaHan.Value = coach.hire_date.Value;
                dtpNgayHetHan.Value = coach.contract_end_date.Value;
                txtLuong.Text = coach.salary.ToString();
            }
        }
        #endregion

        private void CoachRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
