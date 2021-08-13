using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philowolf
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (pgr_bar.Value < 100)
            {
                pgr_bar.Value += 2;
            } else
            {
                timer1.Enabled = false;
                this.Visible = false;
                login login = new login();
                login.ShowDialog();
            }
        }

        private void pgr_bar_Click(object sender, EventArgs e)
        {

        }
    }
}
