using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                cbMinutos.Items.Add(i);
                cbSegundos.Items.Add(i);
                if (i < 24)
                    cbHoras.Items.Add(i);
            }
            cbHoras.SelectedIndex = 0;
            cbMinutos.SelectedIndex = 0;
            cbSegundos.SelectedIndex = 0;
        }
        bool descanso = false;
        int horas, min, seg;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string segundos = seg.ToString();
            string minutos = min.ToString();
            string hor = horas.ToString();
            if (horas < 10)
                hor = "0" + horas.ToString();
            if (min < 10)
                minutos = "0" + min.ToString();
            if (seg < 10)
                segundos = "0" + seg.ToString();

            if(seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }
            if(min == 0 && seg == 0 && horas > 0)
            {
                horas -= 1;
                min = 59;
                seg = 60;
            }
            if (min == 0 && seg == 0 && horas == 0)
            {
                //btnPausar.Enabled = false;
                //btnPausar.ForeColor = Color.RoyalBlue;
                //btnPausar.FlatAppearance.BorderColor = Color.RoyalBlue;
                //btnPausar.Text = "Pausar";
                //timer1.Stop();
                //MessageBox.Show("Se acabó el tiempo.", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Stop();
                if (!descanso) 
                { 
                    min = 5;
                    lblPomodoro.Text = "Descanso";
                    descanso = true;         
                }else
                { 
                    min = 25;
                    descanso = false;
                    lblPomodoro.Text = "Trabajo";
                }
                timer1.Start();
            }
            
            lblTiempo.Text = hor + ":" + minutos + ":" + segundos;
            seg -= 1;

        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            lblHoras.Visible = false;
            lblMinutos.Visible = false;
            lblSegundos.Visible = false;
            cbSegundos.Visible = false;
            cbMinutos.Visible = false;
            cbHoras.Visible = false;
            lblPomodoro.Visible = true;
            timer1.Stop();
            min = 25;
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if(btnPausar.Text == "Pausar")
            {
                timer1.Stop();
                btnPausar.ForeColor = Color.DarkOrange;
                btnPausar.FlatAppearance.BorderColor = Color.DarkOrange;
                btnPausar.Text = "Reanudar";
            }
            else
            {
                timer1.Start();
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.FlatAppearance.BorderColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            if(btnIniciar.Text == "Iniciar")
            {
                timer1.Start();
                btnIniciar.ForeColor = Color.Firebrick;
                btnIniciar.FlatAppearance.BorderColor = Color.Firebrick;
                btnPausar.Enabled = true;
                horas = cbHoras.SelectedIndex;
                min = cbMinutos.SelectedIndex;
                seg = cbSegundos.SelectedIndex;
                btnIniciar.Text = "Reestablecer";
            }
            else
            {
                timer1.Stop();
                seg = 0;
                min = 0;
                horas = 0;
                lblTiempo.Text = "00:00:00";
                btnIniciar.Text = "Iniciar";
                btnIniciar.ForeColor = Color.ForestGreen;
                btnIniciar.FlatAppearance.BorderColor = Color.ForestGreen;
                //btnPausar.Enabled = false;
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.FlatAppearance.BorderColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
            }
        }
    }
}
