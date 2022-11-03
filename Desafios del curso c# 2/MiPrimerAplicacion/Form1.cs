using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau...");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento click", "Atención");
            //this.BackColor = Color.Blue;
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                
        }

        private void frm1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Se presionó el click izquierdo", "ATENCIÓN");
            else if(click.Button == MouseButtons.Right)
                MessageBox.Show("Se presionó el click derecho", "ATENCIÓN");
            else
                MessageBox.Show("Se presionó el boton del medio", "ATENCIÓN");


        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.LightCoral;
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Se ingresaron " + txtNuevo.Text.Length + "caractéres.");
        }
    }
}
