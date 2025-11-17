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

        
        private void UpdateMenu()
        {
            bool isLogin = SessionManager.IsLoggedIn;
            LoginToolStripMenuItem.Visible = !isLogin;
            LogoutToolStripMenuItem.Visible = isLogin;
            SigninToolStripMenuItem.Visible = !isLogin;
            ChangePassToolStripMenuItem.Visible = isLogin;


            int level = SessionManager.LoggedLevel;

            //Phân quyền
            //ceo
            if (level == 0)
            {
                //Mở 
                CategoryToolStripMenuItem.Visible = true;

                tHỐNGKÊToolStripMenuItem.Visible = true;
                ManagerAccountToolStripMenuItem.Visible = true;

                PlayerManagementToolStripMenuItem.Visible = true;
                PlayerContractToolStripMenuItem.Visible = false;
                PlayerListToolStripMenuItem.Visible = true;

                ListCoachToolStripMenuItem.Visible = true;
                ManageCoachToolStripMenuItem.Visible = true;
                CoachContractToolStripMenuItem.Visible = false;
                
                
                

                lblInfor.Text = $"Xin chào CEO, {SessionManager.LoggedUser}!";
            }
            //coach
            else if (level == 1) //Coach
            {
                CategoryToolStripMenuItem.Visible = true;

                tHỐNGKÊToolStripMenuItem.Visible = false;
                ManagerAccountToolStripMenuItem.Visible = false;

                PlayerManagementToolStripMenuItem.Visible = true;
                PlayerListToolStripMenuItem.Visible = true;               
                PlayerContractToolStripMenuItem.Visible = false;

                ManageCoachToolStripMenuItem.Visible = true;
                ListCoachToolStripMenuItem.Visible = true;               
                CoachContractToolStripMenuItem.Visible = true;

               
                lblInfor.Text = $"Xin chào Coach, {SessionManager.LoggedUser}!";
            }
            // player
            else if (level == 2) //Player
            {
                CategoryToolStripMenuItem.Visible = true;

                tHỐNGKÊToolStripMenuItem.Visible = false;
                ManagerAccountToolStripMenuItem.Visible = false;

                PlayerManagementToolStripMenuItem.Visible = true;
                PlayerListToolStripMenuItem.Visible = true;
                PlayerContractToolStripMenuItem.Visible = true;

                ManageCoachToolStripMenuItem.Visible = true;
                ListCoachToolStripMenuItem.Visible = true;
                CoachContractToolStripMenuItem.Visible = false;

                
                lblInfor.Text = $"Xin chào Player, {SessionManager.LoggedUser}!";
            }
            // viewer
            else if (level == 3)
            {
                CategoryToolStripMenuItem.Visible = true;

                tHỐNGKÊToolStripMenuItem.Visible = false;
                ManagerAccountToolStripMenuItem.Visible = false;

                PlayerManagementToolStripMenuItem.Visible = true;
                PlayerListToolStripMenuItem.Visible = true;
                PlayerContractToolStripMenuItem.Visible = false;

                ManageCoachToolStripMenuItem.Visible = true;
                ListCoachToolStripMenuItem.Visible = true;
                CoachContractToolStripMenuItem.Visible = false;

                
                lblInfor.Text = $"Xin chào , {SessionManager.LoggedUser}!";
            }
            // not logged in
            else if (level == -1)
            {
                CategoryToolStripMenuItem.Visible = false;
                PlayerManagementToolStripMenuItem.Visible = false;
                ManageCoachToolStripMenuItem.Visible = false;
                
                HelpToolStripMenuItem.Visible = true;
                LogoutToolStripMenuItem.Visible = false;
                LoginToolStripMenuItem.Visible = true;
                SigninToolStripMenuItem.Visible = true;
                ChangePassToolStripMenuItem.Visible = false;
            }
            else lblInfor.Text = $"Xin chào, {SessionManager.LoggedUser}!";
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }



        #region Xu Ly Event Click

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
        private void PlayerContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlayerContract frm = new frmPlayerContract(SessionManager.LoggedUser);
            frm.Show();
        }

        private void CoachContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoachContract frm = new frmCoachContract(SessionManager.LoggedUser);
            frm.Show();
        }
        private void listCeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCEO ceo = new frmCEO();
            ceo.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    UpdateMenu();
                }
            }

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
            frmHelp frm = new frmHelp();
            frm.Show();
        }

        private void đĂNGKÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignin frm = new frmSignin();

            frm.Show();
        }

        private void TitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhHieu frm = new frmDanhHieu();
            frm.StartPosition = FormStartPosition.CenterParent;
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

        private void ManagerAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAccount frm = new frmListAccount();

            frm.Show();
        }
        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.Show();
        }
        private void ScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MatchScheduleMenuItem_Click(object sender, EventArgs e)
        {
            frmLichThiDau frm = new frmLichThiDau();
            frm.Show();
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
        #endregion

        
    }
}