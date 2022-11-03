using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío2_AplicacionWIndows2_
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                txtApellido.CausesValidation = true;
            }
            else
            {
                txtApellido.CausesValidation = false;
            }
            if(txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                txtDireccion.CausesValidation = true;
            }
            else
            {
                txtDireccion.CausesValidation = false;
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                txtEdad.CausesValidation = true;
            }
            else
            {
                txtEdad.CausesValidation = false;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.CausesValidation = true;
            }
            else
            {
                txtNombre.CausesValidation = false;
            }
            if (txtApellido.CausesValidation == false && txtNombre.CausesValidation == false && txtDireccion.CausesValidation == false && txtEdad.CausesValidation == false)
            {
                txtResultado.Text = "Apellido y Nombre: " + txtNombre.Text + " " + txtApellido.Text + "\r\n" +
                "Edad: " + txtEdad.Text + Environment.NewLine
                + "Dirección: " + txtDireccion.Text;
            }
            else
            {
                txtResultado.Text = "";
            }
            
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.BackColor = SystemColors.Control;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtEdad.BackColor = SystemColors.Control;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.BackColor = SystemColors.Control;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = SystemColors.Control;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
