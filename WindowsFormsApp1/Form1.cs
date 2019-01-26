using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int minutos;
        int segundos;

        
        private void setValorDisplay(int numero)
        {


            string[] valores = lblDisplay.Text.Split(':');
            lblDisplay.Text = "";
           
           
            if (valores[1].Length+1 > 2 && int.Parse(valores[1] + numero.ToString()) > 60)
            {
                valores[0] += valores[1][0];
                valores[1] =valores[1][1] +  numero.ToString();


            }
            else
            {
                valores[1] = int.Parse(valores[1]).ToString() + numero.ToString();
            }

            minutos = int.Parse(valores[0]);
            segundos = int.Parse(valores[1]);



            lblDisplay.Text =string.Format("{0,0:00}",minutos) +":" +  string.Format("{0,0:00}",segundos);


             
            
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            setValorDisplay(int.Parse(((Button)sender).Text));

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (segundos > 60)
            {
                timer1.Enabled = false;
                minutos = 0;
                segundos = 0;
                lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);

            }

            else if(minutos >= 2 && segundos > 0)
            {
                MessageBox.Show("Valor fora dos parametros");
                minutos = 0;
                segundos = 0;
                lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);
            }


            else if (minutos == 0 && segundos == 0)
            {
                segundos += 31;
                minutos = 0;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
            }
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            if (segundos < 0 && minutos != 0 )
            {
                minutos--;
                segundos = 59;
            }
            if(segundos == 0  && minutos == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Aquecido");
            }
            lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            segundos = 0;
            minutos = 0;
            lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);
            tckPotencia.Value = 0;
            lblPotencia.Text = "Potência: " + tckPotencia.Value.ToString();
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            segundos = 50;
            minutos = 1;
            tckPotencia.Value = 2;
            lblPotencia.Text = "Potência: " + tckPotencia.Value.ToString();
            lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);
        }

        private void tckPotencia_Scroll(object sender, EventArgs e)
        {
            lblPotencia.Text = "Potência: " + tckPotencia.Value.ToString();
        }

        private void btnPipoca_Click(object sender, EventArgs e)
        {
            segundos = 0;
            minutos = 1;
            tckPotencia.Value = 6;
            lblPotencia.Text = "Potência: " + tckPotencia.Value.ToString();
            lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);
        }

        private void btnArroz_Click(object sender, EventArgs e)
        {
            segundos = 0;
            minutos = 2;
            tckPotencia.Value = 4;
            lblPotencia.Text = "Potência: " + tckPotencia.Value.ToString();
            lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);
        }

        private void btnCarneMoida_Click(object sender, EventArgs e)
        {
            segundos = 30;
            minutos = 1;
            tckPotencia.Value = 10;
            lblPotencia.Text = "Potência: " + tckPotencia.Value.ToString();
            lblDisplay.Text = string.Format("{0,0:00}", minutos) + ":" + string.Format("{0,0:00}", segundos);
        }
    }
}
