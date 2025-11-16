namespace FakeMadrid.Views
{
    partial class frmChangePass
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.SeePass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imgPass = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.txtNewPass);
            this.panelLogin.Controls.Add(this.SeePass);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.imgPass);
            this.panelLogin.Controls.Add(this.imgUser);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(667, 502);
            this.panelLogin.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FakeMadrid.Properties.Resources.ChangePass;
            this.pictureBox2.Location = new System.Drawing.Point(84, 334);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(173, 334);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(327, 35);
            this.txtNewPass.TabIndex = 9;
            // 
            // SeePass
            // 
            this.SeePass.AutoSize = true;
            this.SeePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SeePass.Location = new System.Drawing.Point(577, 337);
            this.SeePass.Name = "SeePass";
            this.SeePass.Size = new System.Drawing.Size(41, 31);
            this.SeePass.TabIndex = 8;
            this.SeePass.Text = "🙈";
            this.SeePass.Click += new System.EventHandler(this.SeePass_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(237, 395);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(204, 68);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Xác Nhận";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imgPass
            // 
            this.imgPass.Image = global::FakeMadrid.Properties.Resources.iconPasss;
            this.imgPass.Location = new System.Drawing.Point(84, 273);
            this.imgPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgPass.Name = "imgPass";
            this.imgPass.Size = new System.Drawing.Size(49, 36);
            this.imgPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPass.TabIndex = 4;
            this.imgPass.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Image = global::FakeMadrid.Properties.Resources.iconUser;
            this.imgUser.Location = new System.Drawing.Point(84, 207);
            this.imgUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtPass.Location = new System.Drawing.Point(173, 273);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtUser.Location = new System.Drawing.Point(173, 207);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(327, 35);
            this.txtUser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::FakeMadrid.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 502);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChangePass";
            this.ShowIcon = false;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label SeePass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox imgPass;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}