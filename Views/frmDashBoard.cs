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
            #region Click

            GNpic1_Click.Click += GNpic1_Click_Event;
            GNpic2_Click.Click += GNpic2_Click_Event;
            GNpic3_Click.Click += GNpic3_Click_Event;
            GNpic4_Click.Click += GNpic4_Click_Event;

            lbl1_Click.Click += GNpic1_Click_Event;
            lbl2_Click.Click += GNpic2_Click_Event;
            lbl3_Click.Click += GNpic3_Click_Event;
            lbl4_Click.Click += GNpic4_Click_Event;


            #endregion
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
            ChangePassToolStripMenuItem.Visible = isLogin;


            int level = SessionManager.LoggedLevel;

            //Phân quyền
            if (level == 0)
            {
                //Mở full
                ManageCoachToolStripMenuItem.Visible = true;
                PlayerManagementToolStripMenuItem.Visible = true;
                ScheduleToolStripMenuItem.Visible = true;
                ChangePassToolStripMenuItem.Visible = true;
                tHỐNGKÊToolStripMenuItem.Visible = true;
                
            }
            else if (level == 1) //Coach
            {
                ManageCoachToolStripMenuItem.Visible = true;
                PlayerManagementToolStripMenuItem.Visible = true;
                ScheduleToolStripMenuItem.Visible = true;
                ListCoachToolStripMenuItem.Visible = false;
                ChangePassToolStripMenuItem.Visible = true;
                tHỐNGKÊToolStripMenuItem.Visible = false;

            } 
            else if (level == 2) //Player
            {
                
                PlayerManagementToolStripMenuItem.Visible = true;
                ScheduleToolStripMenuItem.Visible = true;
                ManageCoachToolStripMenuItem.Visible = false;
                PlayerListToolStripMenuItem.Visible = false;
                ChangePassToolStripMenuItem.Visible = true;
                tHỐNGKÊToolStripMenuItem.Visible = false;

            } else if(level == -1)
            {
                ManageCoachToolStripMenuItem.Visible = false;
                PlayerManagementToolStripMenuItem.Visible = false;
                ScheduleToolStripMenuItem.Visible = false;
                LogoutToolStripMenuItem.Visible = false;
                LoginToolStripMenuItem.Visible = true;
                SigninToolStripMenuItem.Visible = true;
                ChangePassToolStripMenuItem.Visible = false;
                tHỐNGKÊToolStripMenuItem.Visible = false;
            }
        }


        private void listCeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCEO ceo = new frmCEO();
            ceo.MdiParent = this;
            ceo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void PlayerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPlayer frm = new frmListPlayer();
            
            frm.Show();
        }

        private void ListCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCoach frm = new frmListCoach();
            frm.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đĂNGKÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignin frm = new frmSignin();
            
            frm.Show();
        }

        private void TitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhHieu frm = new frmDanhHieu();
            frm.Show();

        }

        private void đỔIMẬTKHÂUToolStripMenuItem_Click(object sender, EventArgs e)
        { 

            using (frmChangePass frm = new frmChangePass(SessionManager.LoggedUser))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lblInfor.Text = "Bạn chưa đăng nhập!";
                    SessionManager.LoggedLevel = -1;
                    UpdateMenu();
                }
            }
        }

        private void GNpic1_Click_Event(object sender, EventArgs e)
        {
            frmLineup frmlineup = new frmLineup();
            frmlineup.Show();
        }

        private void GNpic2_Click_Event(object sender, EventArgs e)
        {
            frmArda frmadra = new frmArda();
            frmadra.Show();
        }   

        private void GNpic3_Click_Event(object sender, EventArgs e)
        {
            frmNFL frmnfl = new frmNFL();
            frmnfl.Show();
        }  

        private void GNpic4_Click_Event(object sender, EventArgs e)
        {
            frmVini frmvini = new frmVini();
            frmvini.Show();
        }

        private void ScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MatchScheduleMenuItem_Click(object sender, EventArgs e)
        {
            frmLichThiDau frm = new frmLichThiDau();
            frm.Show();
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.Show();
        }

        private void PlayerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1Click_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mStripToolBox_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}