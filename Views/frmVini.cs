using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmVini : Form
    {
        public frmVini()
        {
            InitializeComponent();
            this.Deactivate += (s, e) => this.Close();
            picTureClick.Click += picTureClick_Click;
        }

        private void frmVini_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picTureClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
