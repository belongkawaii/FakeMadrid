namespace FakeMadrid.Views
{
    partial class frmXacThuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXacThuc));
            this.pnlRight = new System.Windows.Forms.Panel();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnGuiLai = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pcbOTP = new System.Windows.Forms.PictureBox();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRight.Controls.Add(this.txtUser);
            this.pnlRight.Controls.Add(this.btnGuiLai);
            this.pnlRight.Controls.Add(this.btnXacNhan);
            this.pnlRight.Controls.Add(this.txtOTP);
            this.pnlRight.Controls.Add(this.pcbOTP);
            this.pnlRight.Controls.Add(this.pcbUser);
            this.pnlRight.Controls.Add(this.pcbLogo);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(413, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(356, 578);
            this.pnlRight.TabIndex = 0;
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(116, 365);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(228, 34);
            this.txtOTP.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(210, 462);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(134, 38);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnGuiLai
            // 
            this.btnGuiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiLai.Location = new System.Drawing.Point(26, 462);
            this.btnGuiLai.Name = "btnGuiLai";
            this.btnGuiLai.Size = new System.Drawing.Size(134, 38);
            this.btnGuiLai.TabIndex = 5;
            this.btnGuiLai.Text = "GỬI LẠI OTP";
            this.btnGuiLai.UseVisualStyleBackColor = true;
            this.btnGuiLai.Click += new System.EventHandler(this.btnGuiLai_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackgroundImage = global::FakeMadrid.Properties.Resources.backgroundXacThuc;
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(413, 578);
            this.pnlLeft.TabIndex = 1;
            // 
            // pcbOTP
            // 
            this.pcbOTP.Image = global::FakeMadrid.Properties.Resources.xacthuc_removebg_preview;
            this.pcbOTP.Location = new System.Drawing.Point(26, 349);
            this.pcbOTP.Name = "pcbOTP";
            this.pcbOTP.Size = new System.Drawing.Size(50, 50);
            this.pcbOTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOTP.TabIndex = 2;
            this.pcbOTP.TabStop = false;
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::FakeMadrid.Properties.Resources.iconUser;
            this.pcbUser.Location = new System.Drawing.Point(26, 256);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(50, 50);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 1;
            this.pcbUser.TabStop = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::FakeMadrid.Properties.Resources.Logo1;
            this.pcbLogo.Location = new System.Drawing.Point(116, 56);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(150, 150);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(116, 272);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(228, 34);
            this.txtUser.TabIndex = 6;
            // 
            // frmXacThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 578);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXacThuc";
            this.Text = "XÁC THỰC TÀI KHOẢN";
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox pcbOTP;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnGuiLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtUser;
    }
}