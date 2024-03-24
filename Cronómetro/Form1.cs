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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Cronómetro
{
    public partial class Form1 : Form
    {
        Stopwatch SW1 = new Stopwatch();
        string txtAux;
        TimeSpan tsAux;
        private const int cGrip = 16; // Grip size
        private const int cCaption = 32; // Caption bar height
        private const int threshold = 15; // Adjust threshold as needed (in pixels)


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
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
            lblMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            lblSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            SW1.Reset();
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            SW1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(107, 52);
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private Point startPoint;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.Size = new Size(316, 25);
            txtDescripcion.Visible = true;
            
        }

        private void txtDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tsAux = SW1.Elapsed;
                txtAux = txtDescripcion.Text;
                this.Size = new Size(107, 52);
                txtDescripcion.Clear();
                txtDescripcion.Visible = false;
            }
        }

        //private void lblxd_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        isDragging = true;
        //        startPoint = Cursor.Position;
        //        dragTimer.Start();
        //    }
        //}

        //private void lblxd_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isDragging)
        //    {
        //        int deltaX = Cursor.Position.X - startPoint.X;
        //        int deltaY = Cursor.Position.Y - startPoint.Y;
        //        Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        //    }
        //}

        //private void lblxd_MouseUp(object sender, MouseEventArgs e)
        //{
        //    isDragging = false;
        //    dragTimer.Stop();
        //}
        //private void DragTimer_Tick(object sender, EventArgs e)
        //{
        //    if (isDragging)
        //    {
        //        int deltaX = Cursor.Position.X - startPoint.X;
        //        int deltaY = Cursor.Position.Y - startPoint.Y;

        //        // Apply threshold check
        //        if (Math.Abs(deltaX) > threshold || Math.Abs(deltaY) > threshold)
        //        {
        //            // Calculate scaled movement based on threshold and factor
        //            int movementX = (int)(Math.Sign(deltaX) * Math.Max(threshold, Math.Abs(deltaX)) * 0.1);
        //            int movementY = (int)(Math.Sign(deltaY) * Math.Max(threshold, Math.Abs(deltaY)) * 0.1);

        //            // Restrict movement to prevent the form from going off-screen
        //            int newX = Location.X + movementX;
        //            int newY = Location.Y + movementY;

        //            if (newX >= 0 && newX + Width <= Screen.PrimaryScreen.WorkingArea.Width)
        //            {
        //                Location = new Point(newX, Location.Y);
        //            }

        //            if (newY >= 0 && newY + Height <= Screen.PrimaryScreen.WorkingArea.Height)
        //            {
        //                Location = new Point(Location.X, newY);
        //            }
        //        }
        //    }
        //}
    }
}


