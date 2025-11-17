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
    public partial class frmArda : Form
    {
        public frmArda()
        {
            InitializeComponent();
            this.Deactivate += (s, e) => this.Close();
            picTureClick.Click += picTureClick_Click;
        }

        private void picTureClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
