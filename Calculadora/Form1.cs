using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            if((txtboxResultado.Text == "0") || (isOperationPerformed))
                txtboxResultado.Clear();
            
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!txtboxResultado.Text.Contains(","))
                    txtboxResultado.Text += button.Text;
            }
            else
                txtboxResultado.Text += button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnIgual.PerformClick();
                operationPerformed = button.Text;
                lblOperacionActual.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtboxResultado.Text);
                lblOperacionActual.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtboxResultado.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxResultado.Text = "0";
            resultValue = 0;
            lblOperacionActual.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtboxResultado.Text = (resultValue + Double.Parse(txtboxResultado.Text)).ToString();
                    break;
                case "-":
                    txtboxResultado.Text = (resultValue - Double.Parse(txtboxResultado.Text)).ToString();
                    break;
                case "*":
                    txtboxResultado.Text = (resultValue * Double.Parse(txtboxResultado.Text)).ToString();
                    break;
                case "/":
                    txtboxResultado.Text = (resultValue / Double.Parse(txtboxResultado.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(txtboxResultado.Text);
            lblOperacionActual.Text = "";
        }
    }
}
