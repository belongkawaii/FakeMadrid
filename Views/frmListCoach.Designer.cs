namespace FakeMadrid.Views
{
    partial class frmListCoach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCoach = new System.Windows.Forms.DataGridView();
            this.coach_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpNgayGiaHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbInfor = new System.Windows.Forms.GroupBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoachId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoach)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.grbInfor.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HideSelection = false;
            this.txtEmail.Location = new System.Drawing.Point(699, 207);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 34);
            this.txtEmail.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(600, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 26);
            this.label16.TabIndex = 36;
            this.label16.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.HideSelection = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(169, 257);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(297, 34);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(25, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 26);
            this.label17.TabIndex = 35;
            this.label17.Text = "Số điện thoại";
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Items.AddRange(new object[] {
            "All",
            "Head Coach",
            "Assistant Coach",
            "Goalkeeping Coach"});
            this.cbbRole.Location = new System.Drawing.Point(165, 149);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(297, 34);
            this.cbbRole.TabIndex = 3;
            this.cbbRole.SelectedIndexChanged += new System.EventHandler(this.CoachRole_SelectedIndexChanged);
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHetHan.Location = new System.Drawing.Point(699, 149);
            this.dtpNgayHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(301, 30);
            this.dtpNgayHetHan.TabIndex = 10;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.HideSelection = false;
            this.txtLuong.Location = new System.Drawing.Point(699, 263);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(297, 34);
            this.txtLuong.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(589, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 26);
            this.label13.TabIndex = 30;
            this.label13.Text = "Lương";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HideSelection = false;
            this.txtSearch.Location = new System.Drawing.Point(1583, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(412, 34);
            this.txtSearch.TabIndex = 3;
            // 
            // dgvCoach
            // 
            this.dgvCoach.AllowUserToAddRows = false;
            this.dgvCoach.AllowUserToDeleteRows = false;
            this.dgvCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coach_id,
            this.coach_name,
            this.coach_birthday,
            this.coach_nationality,
            this.coach_role,
            this.coach_hiredate,
            this.coach_contract,
            this.coach_salary,
            this.coach_phone,
            this.coach_email});
            this.dgvCoach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCoach.Location = new System.Drawing.Point(0, 116);
            this.dgvCoach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCoach.Name = "dgvCoach";
            this.dgvCoach.ReadOnly = true;
            this.dgvCoach.RowHeadersWidth = 51;
            this.dgvCoach.RowTemplate.Height = 24;
            this.dgvCoach.Size = new System.Drawing.Size(1924, 859);
            this.dgvCoach.TabIndex = 2;
            this.dgvCoach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoach_CellClick);
            // 
            // coach_id
            // 
            this.coach_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.coach_id.DataPropertyName = "coach_id";
            this.coach_id.HeaderText = "Mã HLV";
            this.coach_id.MinimumWidth = 6;
            this.coach_id.Name = "coach_id";
            this.coach_id.ReadOnly = true;
            this.coach_id.Width = 78;
            // 
            // coach_name
            // 
            this.coach_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_name.DataPropertyName = "coach_name";
            this.coach_name.HeaderText = "Tên HLV";
            this.coach_name.MinimumWidth = 6;
            this.coach_name.Name = "coach_name";
            this.coach_name.ReadOnly = true;
            // 
            // coach_birthday
            // 
            this.coach_birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_birthday.DataPropertyName = "coach_birthday";
            this.coach_birthday.HeaderText = "Ngày Sinh";
            this.coach_birthday.MinimumWidth = 6;
            this.coach_birthday.Name = "coach_birthday";
            this.coach_birthday.ReadOnly = true;
            // 
            // coach_nationality
            // 
            this.coach_nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_nationality.DataPropertyName = "nationality";
            this.coach_nationality.HeaderText = "Quốc Tịch";
            this.coach_nationality.MinimumWidth = 6;
            this.coach_nationality.Name = "coach_nationality";
            this.coach_nationality.ReadOnly = true;
            // 
            // coach_role
            // 
            this.coach_role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_role.DataPropertyName = "role";
            this.coach_role.HeaderText = "Vai Trò";
            this.coach_role.MinimumWidth = 6;
            this.coach_role.Name = "coach_role";
            this.coach_role.ReadOnly = true;
            // 
            // coach_hiredate
            // 
            this.coach_hiredate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_hiredate.DataPropertyName = "hire_date";
            this.coach_hiredate.HeaderText = "Ngày Gia Hạn";
            this.coach_hiredate.MinimumWidth = 6;
            this.coach_hiredate.Name = "coach_hiredate";
            this.coach_hiredate.ReadOnly = true;
            // 
            // coach_contract
            // 
            this.coach_contract.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_contract.DataPropertyName = "contract_end_date";
            this.coach_contract.HeaderText = "Ngày Hết Hợp Đồng";
            this.coach_contract.MinimumWidth = 6;
            this.coach_contract.Name = "coach_contract";
            this.coach_contract.ReadOnly = true;
            // 
            // coach_salary
            // 
            this.coach_salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_salary.DataPropertyName = "salary";
            this.coach_salary.HeaderText = "Lương";
            this.coach_salary.MinimumWidth = 6;
            this.coach_salary.Name = "coach_salary";
            this.coach_salary.ReadOnly = true;
            // 
            // coach_phone
            // 
            this.coach_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_phone.DataPropertyName = "phone";
            this.coach_phone.HeaderText = "Số Điện Thoại";
            this.coach_phone.MinimumWidth = 6;
            this.coach_phone.Name = "coach_phone";
            this.coach_phone.ReadOnly = true;
            // 
            // coach_email
            // 
            this.coach_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach_email.DataPropertyName = "email";
            this.coach_email.HeaderText = "Email";
            this.coach_email.MinimumWidth = 6;
            this.coach_email.Name = "coach_email";
            this.coach_email.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(788, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HUẤN LUYỆN VIÊN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(524, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 26);
            this.label15.TabIndex = 28;
            this.label15.Text = "Ngày hết HĐ";
            // 
            // dtpNgayGiaHan
            // 
            this.dtpNgayGiaHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGiaHan.Location = new System.Drawing.Point(699, 96);
            this.dtpNgayGiaHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayGiaHan.Name = "dtpNgayGiaHan";
            this.dtpNgayGiaHan.Size = new System.Drawing.Size(301, 30);
            this.dtpNgayGiaHan.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(165, 204);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(301, 30);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(519, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngày Gia Hạn";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.grbChucNang);
            this.panelFooter.Controls.Add(this.grbInfor);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 589);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1924, 386);
            this.panelFooter.TabIndex = 2;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnIn);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnTim);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChucNang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.Location = new System.Drawing.Point(1256, 0);
            this.grbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChucNang.Size = new System.Drawing.Size(668, 386);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Bảng chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Location = new System.Drawing.Point(307, 230);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(204, 60);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.Location = new System.Drawing.Point(307, 134);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(204, 60);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In danh sách";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(307, 42);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(204, 60);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(45, 230);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(204, 60);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.Location = new System.Drawing.Point(45, 134);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(204, 60);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(45, 42);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 60);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbInfor
            // 
            this.grbInfor.Controls.Add(this.txtEmail);
            this.grbInfor.Controls.Add(this.label16);
            this.grbInfor.Controls.Add(this.txtPhoneNumber);
            this.grbInfor.Controls.Add(this.label17);
            this.grbInfor.Controls.Add(this.cbbRole);
            this.grbInfor.Controls.Add(this.dtpNgayHetHan);
            this.grbInfor.Controls.Add(this.txtLuong);
            this.grbInfor.Controls.Add(this.label13);
            this.grbInfor.Controls.Add(this.label15);
            this.grbInfor.Controls.Add(this.dtpNgayGiaHan);
            this.grbInfor.Controls.Add(this.dtpNgaySinh);
            this.grbInfor.Controls.Add(this.label6);
            this.grbInfor.Controls.Add(this.txtQuocTich);
            this.grbInfor.Controls.Add(this.label10);
            this.grbInfor.Controls.Add(this.label5);
            this.grbInfor.Controls.Add(this.label4);
            this.grbInfor.Controls.Add(this.txtCoachName);
            this.grbInfor.Controls.Add(this.label2);
            this.grbInfor.Controls.Add(this.txtCoachId);
            this.grbInfor.Controls.Add(this.label1);
            this.grbInfor.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbInfor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfor.Location = new System.Drawing.Point(0, 0);
            this.grbInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfor.Name = "grbInfor";
            this.grbInfor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfor.Size = new System.Drawing.Size(1256, 386);
            this.grbInfor.TabIndex = 8;
            this.grbInfor.TabStop = false;
            this.grbInfor.Text = "Thông tin cầu thủ";
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocTich.HideSelection = false;
            this.txtQuocTich.Location = new System.Drawing.Point(699, 32);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(297, 34);
            this.txtQuocTich.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(556, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Quốc tịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(25, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(25, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vai Trò";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCoachName
            // 
            this.txtCoachName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoachName.HideSelection = false;
            this.txtCoachName.Location = new System.Drawing.Point(165, 95);
            this.txtCoachName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(297, 34);
            this.txtCoachName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên HLV";
            // 
            // txtCoachId
            // 
            this.txtCoachId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoachId.HideSelection = false;
            this.txtCoachId.Location = new System.Drawing.Point(165, 36);
            this.txtCoachId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoachId.Name = "txtCoachId";
            this.txtCoachId.Size = new System.Drawing.Size(297, 34);
            this.txtCoachId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã HLV";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.dgvCoach);
            this.panelMain.Controls.Add(this.lbl1);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1924, 975);
            this.panelMain.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl1.Location = new System.Drawing.Point(12, 54);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(187, 26);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "DANH SÁCH HLV";
            // 
            // frmListCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 975);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListCoach";
            this.Text = "frmListCoach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoach)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.grbInfor.ResumeLayout(false);
            this.grbInfor.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCoach;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpNgayGiaHan;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbInfor;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoachId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_hiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach_email;
    }
}