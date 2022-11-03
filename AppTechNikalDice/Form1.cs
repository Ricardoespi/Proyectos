using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTechNikalDice
{
    public partial class frmPrincipal : Form
    {

        List<Dado> Dados = new List<Dado>();
        
         
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            if ((Dados.Count > 0))
            {
                lblCantidadDeDados.Text = Dados.Count.ToString();
                int resultado = 0, aux = 0;
                string auxtxt = "";
                foreach (Dado dice in Dados)
                {
                    aux = dice.Roll();
                    auxtxt += aux.ToString() + " ";
                    auxtxt += aux.ToString() + " + ";
                    resultado += aux;
                }

                lblResultado.Text = auxtxt + "= " + resultado.ToString();
                
            }
            else
            {
                lblResultado.Text = "Agregue un Dado... ";
            }
            
        }

        void tsbtnAgregarDado_Click(object sender, EventArgs e)
        {
            if(numudAgregarNroCaras.Visible == false)
            {
                numudAgregarNroCaras.Visible = true;
                CrearDado((int)numudAgregarNroCaras.Value);
                lblCantidadDeDados.Text = Dados.Count.ToString();
            }
            else
            {
                CrearDado((int)numudAgregarNroCaras.Value);
                lblCantidadDeDados.Text = Dados.Count.ToString();
            }
            
        }
        private Dado CrearDado(int nCaras)
        {
            Dado aux = new Dado(nCaras);
            Dados.Add(aux);
            return Dados[(Dados.Count - 1)];
        }
              
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            CrearDado((int)numudAgregarNroCaras.Value);
            lblCantidadDeDados.Text = Dados.Count.ToString();
        }
    }
}
