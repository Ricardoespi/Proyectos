using Calculadora_2_.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2_
{
    public partial class Calculadora : Form
    {
        double primero, segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Suma obj1 = new Suma();
        Resta obj2 = new Resta();
        Multiplicacion obj3 = new Multiplicacion();
        Division obj4 = new Division();

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtbxScreen.Text = txtbxScreen.Text + "9";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtbxScreen.Text.Contains("."))
            {
                txtbxScreen.Text += ".";
            }
            
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            try
            {
                primero = double.Parse(txtbxScreen.Text);
                txtbxScreen.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número...");
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            try
            {
                primero = double.Parse(txtbxScreen.Text);
                txtbxScreen.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número...");
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            try
            {
                primero = double.Parse(txtbxScreen.Text);
                txtbxScreen.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número...");
            }
        }


        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            try
            {
                primero = double.Parse(txtbxScreen.Text);
                txtbxScreen.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número...");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbxScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text.Length == 1)
                txtbxScreen.Text = "";
            else
            {
                txtbxScreen.Text = txtbxScreen.Text.Substring(0, txtbxScreen.Text.Length - 1);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtbxScreen.Text);
            double sum, res, mult, div;

            switch (operador)
            {
                case "+":
                    sum = obj1.Sumar(primero, segundo);
                    txtbxScreen.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.Restar(primero, segundo);
                    txtbxScreen.Text=res.ToString();
                    break;
                case "*":
                    mult = obj3.Multiplicar(primero, segundo);
                    txtbxScreen.Text = mult.ToString();
                    break;
                case "/":
                    div = obj4.Dividir(primero, segundo);
                    txtbxScreen.Text = div.ToString();
                    break;
            }
        }


    }
}
