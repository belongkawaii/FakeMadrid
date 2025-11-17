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
    public partial class frmChiTietTranDau : Form
    {
        public frmChiTietTranDau()
        {
            InitializeComponent();
        }

        public frmChiTietTranDau(List<(int MatchID, string MatchDate, string HomeTeam, string HomeScore, string AwayTeam, string AwayScore, string Referee, bool? IsHomeMatch)> arg)
        {
            InitializeComponent();
            
        }


        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
