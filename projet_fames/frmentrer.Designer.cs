
namespace projet_fames
{
    partial class frmentrer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbvg = new Guna.UI.WinForms.GunaVProgressBar();
            this.pbhb = new Guna.UI.WinForms.GunaProgressBar();
            this.pbvd = new Guna.UI.WinForms.GunaVProgressBar();
            this.pbhh = new Guna.UI.WinForms.GunaProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbvg
            // 
            this.pbvg.BackColor = System.Drawing.Color.Gainsboro;
            this.pbvg.BorderColor = System.Drawing.Color.Black;
            this.pbvg.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.pbvg.IdleColor = System.Drawing.Color.Orange;
            this.pbvg.Location = new System.Drawing.Point(0, 0);
            this.pbvg.Name = "pbvg";
            this.pbvg.ProgressMaxColor = System.Drawing.Color.Yellow;
            this.pbvg.ProgressMinColor = System.Drawing.Color.Yellow;
            this.pbvg.Size = new System.Drawing.Size(17, 375);
            this.pbvg.TabIndex = 0;
            // 
            // pbhb
            // 
            this.pbhb.BorderColor = System.Drawing.Color.Black;
            this.pbhb.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.pbhb.IdleColor = System.Drawing.Color.Orange;
            this.pbhb.Location = new System.Drawing.Point(0, 354);
            this.pbhb.Name = "pbhb";
            this.pbhb.ProgressMaxColor = System.Drawing.Color.Yellow;
            this.pbhb.ProgressMinColor = System.Drawing.Color.Yellow;
            this.pbhb.Size = new System.Drawing.Size(748, 18);
            this.pbhb.TabIndex = 1;
            // 
            // pbvd
            // 
            this.pbvd.BorderColor = System.Drawing.Color.Black;
            this.pbvd.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.pbvd.IdleColor = System.Drawing.Color.Orange;
            this.pbvd.Location = new System.Drawing.Point(730, 0);
            this.pbvd.Name = "pbvd";
            this.pbvd.ProgressMaxColor = System.Drawing.Color.Yellow;
            this.pbvd.ProgressMinColor = System.Drawing.Color.Yellow;
            this.pbvd.Size = new System.Drawing.Size(17, 375);
            this.pbvd.TabIndex = 2;
            // 
            // pbhh
            // 
            this.pbhh.BorderColor = System.Drawing.Color.Black;
            this.pbhh.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.pbhh.IdleColor = System.Drawing.Color.Orange;
            this.pbhh.Location = new System.Drawing.Point(0, 0);
            this.pbhh.Name = "pbhh";
            this.pbhh.ProgressMaxColor = System.Drawing.Color.Yellow;
            this.pbhh.ProgressMinColor = System.Drawing.Color.Yellow;
            this.pbhh.Size = new System.Drawing.Size(748, 18);
            this.pbhh.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projet_fames.Properties.Resources.logofrv;
            this.pictureBox1.Location = new System.Drawing.Point(243, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmentrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(748, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbhh);
            this.Controls.Add(this.pbvd);
            this.Controls.Add(this.pbhb);
            this.Controls.Add(this.pbvg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmentrer";
            this.Text = "frmentrer";
            this.Load += new System.EventHandler(this.frmentrer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaVProgressBar pbvg;
        private Guna.UI.WinForms.GunaProgressBar pbhb;
        private Guna.UI.WinForms.GunaVProgressBar pbvd;
        private Guna.UI.WinForms.GunaProgressBar pbhh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}