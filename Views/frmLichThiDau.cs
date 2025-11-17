using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakeMadrid.Database;

namespace FakeMadrid.Views
{
    public partial class frmLichThiDau : Form
    {

        private DataClassesQuanLyDoiBongDataContext db;

        public frmLichThiDau()
        {
            InitializeComponent();
            LoadData();
            //this.Size = new Size(940, 600);
            //this.MinimumSize = new Size(940, 600);
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        void LoadData()
        {
            lstMatch.FullRowSelect = true;
            lstMatch.View = View.Details;
            lstMatch.Font = new Font("Segoe UI", 15);
            //lstMatch.GridLines = true;
            db = new DataClassesQuanLyDoiBongDataContext();
            var matches = db.Matches
                .Join(db.Teams,
                    m => m.home_team_id,
                    t => t.team_id,
                    (m, homeTeam) => new { m, homeTeam })
                .Join(db.Teams,
                    x => x.m.away_team_id,
                    t => t.team_id,
                    (x, awayTeam) => new {
                        x.m.match_id,
                        MatchDate = x.m.match_date,
                        HomeTeam = x.homeTeam.team_name,
                        Score = (x.m.home_score.ToString() ?? "?") + " - " + (x.m.away_score.ToString() ?? "?"),
                        AwayTeam = awayTeam.team_name
                    }).ToList();

            ColumnHeader match_date = new ColumnHeader();
            match_date.Text = "Ngày thi đấu";
            match_date.Width = 150;
            match_date.TextAlign = HorizontalAlignment.Center;

            ColumnHeader home_team = new ColumnHeader();
            home_team.Text = "Đội nhà";
            home_team.Width = 200;
            home_team.TextAlign = HorizontalAlignment.Left;

            ColumnHeader matchResult = new ColumnHeader();
            matchResult.Text = "Kết quả";
            matchResult.Width = 100;
            matchResult.TextAlign = HorizontalAlignment.Center;

            ColumnHeader away_team = new ColumnHeader();
            away_team.Text = "Đội khách";
            away_team.Width = 200;
            away_team.TextAlign = HorizontalAlignment.Right;

            lstMatch.Columns.Add(match_date);
            lstMatch.Columns.Add(home_team);
            lstMatch.Columns.Add(matchResult);
            lstMatch.Columns.Add(away_team);

            foreach (var match in matches)
            {
                ListViewItem item = new ListViewItem();
                item.Text = match.MatchDate.ToString("dd/MM/yyyy");
                item.SubItems.Add(match.HomeTeam);
                item.SubItems.Add(match.Score);
                item.SubItems.Add(match.AwayTeam);
                lstMatch.Items.Add(item);
            }
        }
        private void frmLichThiDau_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lstMatch_DoubleClick(object sender, EventArgs e)
        {
            if (lstMatch.SelectedItems.Count > 0)
            {
                var item = lstMatch.SelectedItems[0];
                var match = db.Matches
                    .Join(db.Teams,
                        m => m.home_team_id,
                        t => t.team_id,
                        (m, homeTeam) => new { m, homeTeam })
                    .Join(db.Teams,
                        x => x.m.away_team_id,
                        t => t.team_id,
                        (x, awayTeam) => new {
                            x.m.match_id,
                            MatchDate = x.m.match_date.ToString("dd/MM/yyyy"),
                            HomeTeam = x.homeTeam.team_name,
                            HomeScore = x.m.home_score.ToString(),
                            AwayTeam = awayTeam.team_name,
                            AwayScore = x.m.away_score.ToString(),
                            Referee = x.m.referee,
                            IsHomeMatch = x.m.is_home_match
                        }).Where(m => m.match_id == item.Index + 1);
                List<string> parameter = new List<string>();
                parameter.Add(match.Where());
                frmChiTietTranDau detailForm = new frmChiTietTranDau(match);
                detailForm.Show();
            }
        }
    }
}
