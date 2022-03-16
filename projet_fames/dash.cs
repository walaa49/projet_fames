using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_fames
{
    public partial class dash : Form
    {
        public dash()
        {
            InitializeComponent();
            //bunifuFormDock1.SubscribeControlsToDragEvents(panel1) ;
            //bunifuFormDock1.SubscribeControlsToDragEvents(panel2);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("tabPage1");

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;

            bunifuPages1.SetPage("tabPage2");
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;

            bunifuPages1.SetPage("tabPage3");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;

        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;

        }
    }
}
