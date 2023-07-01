using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerivativesIntuitioner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtVariable_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double variable;
            object function;
            double epsilon;
            function = (object)txtFunction.Text;
            variable = Convert.ToDouble(txtVariable.Text);
            epsilon = Convert.ToDouble(txtEpsilon.Text);
            Math.
        }
    }
}
