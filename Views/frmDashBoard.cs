using FakeMadrid.Controllers;
using FakeMadrid.Views;
using FakeMadrid.Views;
using System;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        string infor = "Bạn chưa đăng nhập!";
        public frmDashBoard(string _infor)
        {
            InitializeComponent();
            infor = _infor;

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblInfor.Text = infor;

            UpdateMenu();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInfor.Text = "Bạn chưa đăng nhập!";
            SessionManager.LoggedLevel = -1;
            UpdateMenu();


        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    lblInfor.Text = $"Xin chào, {SessionManager.LoggedUser}!";
                    UpdateMenu();
                }
            }

        }

        private void UpdateMenu()
        {
            bool isLogin = SessionManager.IsLoggedIn;
            LoginToolStripMenuItem.Visible = !isLogin;
            LogoutToolStripMenuItem.Visible = isLogin;
            SigninToolStripMenuItem.Visible = !isLogin;

            int level = SessionManager.LoggedLevel;

            //Phân quyền
            if (level == 0)
            {
                //Mở full
                ManageCoachToolStripMenuItem.Visible = true;
                PlayerManagementToolStripMenuItem.Visible = true;
                ScheduleToolStripMenuItem.Visible = true;
            } else if (level == 1) //Coach
            {
                ManageCoachToolStripMenuItem.Visible = true;
                PlayerManagementToolStripMenuItem.Visible = true;
                ScheduleToolStripMenuItem.Visible = true;
                ListCoachToolStripMenuItem.Visible = false;


            } else if (level == 2) //Player
            {
                
                PlayerManagementToolStripMenuItem.Visible = true;
                ScheduleToolStripMenuItem.Visible = true;
                ManageCoachToolStripMenuItem.Visible = false;
                PlayerListToolStripMenuItem.Visible = false;
            } else if(level == -1)
            {
                ManageCoachToolStripMenuItem.Visible = false;
                PlayerManagementToolStripMenuItem.Visible = false;
                ScheduleToolStripMenuItem.Visible = false;
                LogoutToolStripMenuItem.Visible = false;
                LoginToolStripMenuItem.Visible = true;
            }
        }

        private void listCeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCEO ceo = new frmCEO();
            MdiParent = this;
            ceo.StartPosition = FormStartPosition.CenterParent;
            ceo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void PlayerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPlayer frm = new frmListPlayer();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void ListCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCoach frm = new frmListCoach();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đĂNGKÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignin frm = new frmSignin();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void TitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhHieu frm = new frmDanhHieu();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}