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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(pnlmenu);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
        }

        private void btnidentification_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void btncreeationcompte_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void chbmdp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbmdp.Checked == true)
            {
                txtmdp.UseSystemPasswordChar = false;
            }
            else
            {
                txtmdp.UseSystemPasswordChar = true;
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void txtmdp_TextChange(object sender, EventArgs e)
        {
            if (txtmdp.Text!="")
            {
                txtmdp.UseSystemPasswordChar = true;
            }
            if (txtmdp.Text=="")
            {
                txtmdp.UseSystemPasswordChar = false;
            }
        }
    }
   
}
