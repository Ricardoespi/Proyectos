using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lblClock.ForeColor = button.BackColor;
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Font f1 = new Font(lblClock.Font.FontFamily, 0.12f, FontStyle.Bold, GraphicsUnit.Inch);
            lblClock.Font = new Font(button.Font.FontFamily, 90, FontStyle.Regular);
            button.Font = f1;
        }
    }
}
