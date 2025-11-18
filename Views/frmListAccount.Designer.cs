namespace FakeMadrid.Views
{
    partial class frmListAccount
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
            this.label6 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.grbInfor = new System.Windows.Forms.GroupBox();
            this.cbbActive = new System.Windows.Forms.ComboBox();
            this.dtpNgayKichHoat = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTaoOTP = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTaoTaiKhoan = new System.Windows.Forms.DateTimePicker();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTPDateSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelFooter.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.grbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(596, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngày Tạo Tài Khoản";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.grbChucNang);
            this.panelFooter.Controls.Add(this.grbInfor);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 541);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1903, 386);
            this.panelFooter.TabIndex = 4;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnIn);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnTim);
            this.grbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChucNang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.Location = new System.Drawing.Point(1256, 0);
            this.grbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChucNang.Size = new System.Drawing.Size(647, 386);
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
            this.btnSua.Location = new System.Drawing.Point(45, 42);
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
            this.btnXoa.Location = new System.Drawing.Point(307, 42);
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
            // grbInfor
            // 
            this.grbInfor.Controls.Add(this.cbbActive);
            this.grbInfor.Controls.Add(this.dtpNgayKichHoat);
            this.grbInfor.Controls.Add(this.dtpNgayTaoOTP);
            this.grbInfor.Controls.Add(this.dtpNgayTaoTaiKhoan);
            this.grbInfor.Controls.Add(this.cbbLevel);
            this.grbInfor.Controls.Add(this.txtEmail);
            this.grbInfor.Controls.Add(this.label16);
            this.grbInfor.Controls.Add(this.txtOTP);
            this.grbInfor.Controls.Add(this.label17);
            this.grbInfor.Controls.Add(this.Level);
            this.grbInfor.Controls.Add(this.label15);
            this.grbInfor.Controls.Add(this.label6);
            this.grbInfor.Controls.Add(this.label10);
            this.grbInfor.Controls.Add(this.label5);
            this.grbInfor.Controls.Add(this.txtUsername);
            this.grbInfor.Controls.Add(this.label2);
            this.grbInfor.Controls.Add(this.txtID);
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
            // cbbActive
            // 
            this.cbbActive.Enabled = false;
            this.cbbActive.FormattingEnabled = true;
            this.cbbActive.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbbActive.Location = new System.Drawing.Point(823, 155);
            this.cbbActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbActive.Name = "cbbActive";
            this.cbbActive.Size = new System.Drawing.Size(297, 34);
            this.cbbActive.TabIndex = 46;
            // 
            // dtpNgayKichHoat
            // 
            this.dtpNgayKichHoat.Enabled = false;
            this.dtpNgayKichHoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKichHoat.Location = new System.Drawing.Point(819, 208);
            this.dtpNgayKichHoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayKichHoat.Name = "dtpNgayKichHoat";
            this.dtpNgayKichHoat.Size = new System.Drawing.Size(301, 30);
            this.dtpNgayKichHoat.TabIndex = 45;
            // 
            // dtpNgayTaoOTP
            // 
            this.dtpNgayTaoOTP.Enabled = false;
            this.dtpNgayTaoOTP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTaoOTP.Location = new System.Drawing.Point(819, 36);
            this.dtpNgayTaoOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayTaoOTP.Name = "dtpNgayTaoOTP";
            this.dtpNgayTaoOTP.Size = new System.Drawing.Size(301, 30);
            this.dtpNgayTaoOTP.TabIndex = 44;
            // 
            // dtpNgayTaoTaiKhoan
            // 
            this.dtpNgayTaoTaiKhoan.Enabled = false;
            this.dtpNgayTaoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTaoTaiKhoan.Location = new System.Drawing.Point(819, 98);
            this.dtpNgayTaoTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayTaoTaiKhoan.Name = "dtpNgayTaoTaiKhoan";
            this.dtpNgayTaoTaiKhoan.Size = new System.Drawing.Size(301, 30);
            this.dtpNgayTaoTaiKhoan.TabIndex = 43;
            // 
            // cbbLevel
            // 
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "All",
            "CEO",
            "Coach",
            "Player",
            "Viewer"});
            this.cbbLevel.Location = new System.Drawing.Point(265, 261);
            this.cbbLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(297, 34);
            this.cbbLevel.TabIndex = 39;
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HideSelection = false;
            this.txtEmail.Location = new System.Drawing.Point(265, 149);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(297, 34);
            this.txtEmail.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(607, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 26);
            this.label16.TabIndex = 36;
            this.label16.Text = "Ngày Kích Hoạt";
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.HideSelection = false;
            this.txtOTP.Location = new System.Drawing.Point(265, 208);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.ReadOnly = true;
            this.txtOTP.Size = new System.Drawing.Size(297, 34);
            this.txtOTP.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(31, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 26);
            this.label17.TabIndex = 35;
            this.label17.Text = "OTP";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Level.Location = new System.Drawing.Point(25, 265);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(118, 26);
            this.Level.TabIndex = 30;
            this.Level.Text = "Quyền Hạn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(581, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(213, 26);
            this.label15.TabIndex = 28;
            this.label15.Text = "Trạng Thái Kích Hoạt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(615, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ngày Tạo OTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(25, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HideSelection = false;
            this.txtUsername.Location = new System.Drawing.Point(265, 94);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(297, 34);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.HideSelection = false;
            this.txtID.Location = new System.Drawing.Point(265, 36);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(297, 34);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
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
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Email,
            this.OTP,
            this.OTPDateSend,
            this.DateCreated,
            this.Active,
            this.DateActive,
            this.IDLevel});
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccount.Location = new System.Drawing.Point(0, 68);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(1903, 859);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 49;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên Tài Khoản";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // OTP
            // 
            this.OTP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OTP.DataPropertyName = "OTP";
            this.OTP.HeaderText = "OTP";
            this.OTP.MinimumWidth = 6;
            this.OTP.Name = "OTP";
            this.OTP.ReadOnly = true;
            // 
            // OTPDateSend
            // 
            this.OTPDateSend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OTPDateSend.DataPropertyName = "OTPDateSend";
            this.OTPDateSend.HeaderText = "Ngày Tạo OTP";
            this.OTPDateSend.MinimumWidth = 6;
            this.OTPDateSend.Name = "OTPDateSend";
            this.OTPDateSend.ReadOnly = true;
            // 
            // DateCreated
            // 
            this.DateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCreated.DataPropertyName = "DateCreated";
            this.DateCreated.HeaderText = "Ngày Tạo Tài Khoản";
            this.DateCreated.MinimumWidth = 6;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Trạng Thái Kích Hoạt";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // DateActive
            // 
            this.DateActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateActive.DataPropertyName = "DateActive";
            this.DateActive.HeaderText = "Ngày Kích Hoạt";
            this.DateActive.MinimumWidth = 6;
            this.DateActive.Name = "DateActive";
            this.DateActive.ReadOnly = true;
            // 
            // IDLevel
            // 
            this.IDLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDLevel.DataPropertyName = "IDLevel";
            this.IDLevel.HeaderText = "Quyền Hạn";
            this.IDLevel.MinimumWidth = 6;
            this.IDLevel.Name = "IDLevel";
            this.IDLevel.ReadOnly = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl1.Location = new System.Drawing.Point(12, 54);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(262, 26);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(788, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.dgvAccount);
            this.panelMain.Controls.Add(this.lbl1);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1903, 927);
            this.panelMain.TabIndex = 5;
            // 
            // frmListAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1903, 927);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListAccount";
            this.Text = "frmListAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListAccount_Load);
            this.panelFooter.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.grbInfor.ResumeLayout(false);
            this.grbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grbInfor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.DateTimePicker dtpNgayKichHoat;
        private System.Windows.Forms.DateTimePicker dtpNgayTaoOTP;
        private System.Windows.Forms.DateTimePicker dtpNgayTaoTaiKhoan;
        private System.Windows.Forms.ComboBox cbbActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTPDateSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLevel;
    }
}