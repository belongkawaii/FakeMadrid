namespace FakeMadrid.Views
{
    partial class frmNFL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNFL));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picTureClick = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureClick)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.picTureClick);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 55);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(361, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(623, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "Real Madird";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTureClick
            // 
            this.picTureClick.Image = global::FakeMadrid.Properties.Resources.Logo;
            this.picTureClick.ImageRotate = 0F;
            this.picTureClick.Location = new System.Drawing.Point(1284, -9);
            this.picTureClick.Name = "picTureClick";
            this.picTureClick.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picTureClick.Size = new System.Drawing.Size(64, 64);
            this.picTureClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTureClick.TabIndex = 3;
            this.picTureClick.TabStop = false;
            this.picTureClick.Click += new System.EventHandler(this.picTureClick_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1368, 742);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 742);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(735, 230);
            this.label4.TabIndex = 11;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.Image = global::FakeMadrid.Properties.Resources.NFL;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(321, 117);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(733, 346);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 91);
            this.label1.TabIndex = 8;
            this.label1.Text = "The president welcomes NFL Commissioner Roger Goodell to Real Madrid City";
            // 
            // frmNFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 805);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 867);
            this.MinimizeBox = false;
            this.Name = "frmNFL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTureClick)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picTureClick;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}