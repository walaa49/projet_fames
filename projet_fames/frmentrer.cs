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
    public partial class frmentrer : Form
    {
        public frmentrer()
        {
            InitializeComponent();
        }
        int startpoint = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            pbhb.Value = startpoint;
            pbhh.Value = startpoint;
            pbvd.Value = startpoint;
            pbvg.Value = startpoint;
            if (pbhh.Value==100 && pbhb.Value==100)
            {
                pbvg.Value = 0;
                pbvd.Value = 0;
                pbhh.Value = 0;
                pbhb.Value = 0;
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
            }
        }

        private void frmentrer_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
