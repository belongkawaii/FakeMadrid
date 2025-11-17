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
    public partial class frmLineup : Form
    {
        public frmLineup()
        {
            InitializeComponent();

            this.Deactivate += (s, e) => this.Close();

            picTureClick.Click += picTureClick_Event;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picTureClick_Event(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
