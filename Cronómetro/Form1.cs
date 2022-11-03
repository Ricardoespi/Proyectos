using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronómetro
{
    public partial class Form1 : Form
    {
        Stopwatch SW1 = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            SW1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)SW1.ElapsedMilliseconds);
            txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            SW1.Reset();
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            SW1.Stop();
        }
    }
}
