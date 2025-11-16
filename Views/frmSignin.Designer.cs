namespace FakeMadrid.Views
{
    partial class frmSignin
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnSignin = new System.Windows.Forms.Button();
            this.imgPass = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.txtPassCheck = new System.Windows.Forms.TextBox();
            this.lblPassCheck = new System.Windows.Forms.Label();
            this.SeePass = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.SeePass);
            this.panelLogin.Controls.Add(this.lblPassCheck);
            this.panelLogin.Controls.Add(this.txtPassCheck);
            this.panelLogin.Controls.Add(this.btnSignin);
            this.panelLogin.Controls.Add(this.imgPass);
            this.panelLogin.Controls.Add(this.imgUser);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogin.Location = new System.Drawing.Point(622, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(423, 567);
            this.panelLogin.TabIndex = 3;
            // 
            // btnSignin
            // 
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(105, 447);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(245, 34);
            this.btnSignin.TabIndex = 5;
            this.btnSignin.Text = "Đăng Ký Tài Khoản";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // imgPass
            // 
            this.imgPass.Image = global::FakeMadrid.Properties.Resources.iconPasss;
            this.imgPass.Location = new System.Drawing.Point(21, 299);
            this.imgPass.Margin = new System.Windows.Forms.Padding(4);
            this.imgPass.Name = "imgPass";
            this.imgPass.Size = new System.Drawing.Size(49, 36);
            this.imgPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPass.TabIndex = 4;
            this.imgPass.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Image = global::FakeMadrid.Properties.Resources.iconUser;
            this.imgUser.Location = new System.Drawing.Point(21, 232);
            this.imgUser.Margin = new System.Windows.Forms.Padding(4);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(49, 36);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 3;
            this.imgUser.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(78, 299);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(327, 35);
            this.txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(79, 232);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(327, 35);
            this.txtUser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::FakeMadrid.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPicture
            // 
            this.panelPicture.BackgroundImage = global::FakeMadrid.Properties.Resources.bannerDangKy;
            this.panelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(4);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(624, 567);
            this.panelPicture.TabIndex = 2;
            // 
            // txtPassCheck
            // 
            this.txtPassCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPassCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassCheck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCheck.Location = new System.Drawing.Point(78, 358);
            this.txtPassCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassCheck.Name = "txtPassCheck";
            this.txtPassCheck.PasswordChar = '*';
            this.txtPassCheck.Size = new System.Drawing.Size(327, 35);
            this.txtPassCheck.TabIndex = 7;
            // 
            // lblPassCheck
            // 
            this.lblPassCheck.AutoSize = true;
            this.lblPassCheck.Location = new System.Drawing.Point(172, 368);
            this.lblPassCheck.Name = "lblPassCheck";
            this.lblPassCheck.Size = new System.Drawing.Size(114, 16);
            this.lblPassCheck.TabIndex = 8;
            this.lblPassCheck.Text = "Nhập lại mật khẩu";
            // 
            // SeePass
            // 
            this.SeePass.AutoSize = true;
            this.SeePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeePass.Location = new System.Drawing.Point(361, 407);
            this.SeePass.Name = "SeePass";
            this.SeePass.Size = new System.Drawing.Size(41, 31);
            this.SeePass.TabIndex = 9;
            this.SeePass.Text = "🙈";
            this.SeePass.Click += new System.EventHandler(this.SeePass_Click);
            // 
            // frmSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelPicture);
            this.Name = "frmSignin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ";
            this.Load += new System.EventHandler(this.frmSignin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.PictureBox imgPass;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Label lblPassCheck;
        private System.Windows.Forms.TextBox txtPassCheck;
        private System.Windows.Forms.Label SeePass;
    }
}