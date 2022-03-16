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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnconnection.Hide();
            pnlcreation.Hide();
      
        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btnconnection.Hide();
            btncreation.Show();
           
           
            pnlcreation.Show();
            pnlgauche.Show();
            pnlcreation.Hide();
        }

        private void btncreation_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btncreation.Hide();
            btnconnection.Show();
            pnlgauche.Show();
           
            pnlcreation.Show();
            pnlgauche.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnldroite.Location.X>-1)
            {
                pnldroite.Location = new Point(pnldroite.Location.X - 10, pnldroite.Location.Y);
            }
            else
            {
                timer1.Stop();
                btnconnection.Enabled = true;
                btncreation.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnldroite.Location.X < 451)
            {
                pnldroite.Location = new Point(pnldroite.Location.X + 10, pnldroite.Location.Y);
            }
            else
            {
                timer2.Stop();
                btnconnection.Enabled = true;
                btncreation.Enabled = true;
            }
        }

        private void pnldroite_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuTextBox5_TextChange(object sender, EventArgs e)
        {
           

            if (bunifuTextBox5.Text != "")
            {
                bunifuTextBox5.UseSystemPasswordChar = true;
            }
            if (bunifuTextBox5.Text == "")
            {
                bunifuTextBox5.UseSystemPasswordChar = false;
            }
           



            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chbmdp.Checked == true)
            {
                bunifuTextBox5.UseSystemPasswordChar = false;
            }
            else
            {
                bunifuTextBox5.UseSystemPasswordChar = true;
            }
        }

        private void chbmdp2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbmdp2.Checked == true)
            {
                bunifuTextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                bunifuTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            if (bunifuTextBox2.Text != "")
            {
                bunifuTextBox2.UseSystemPasswordChar = true;
            }
            if (bunifuTextBox2.Text == "")
            {
                bunifuTextBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
