using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    
    public partial class Form1 : Form
    {
        int tempoG = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            this.label1.Text = "Tempo em segundos";
        }

        //Botao iniciar
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempoG -= 1;
            this.label1.Text = tempoG.ToString() ;
            if(tempoG == 0)
            {
                this.timer1.Stop();
            }

        }
        //Botao parar
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        //Botao definir
        private void button3_Click(object sender, EventArgs e)
        {
            int tempo = int.Parse(textBox1.Text);
            tempoG = tempo;
            this.label1.Text = tempoG.ToString();
            

        }

        
        private void textBox1_FocusChanged(object sender,EventArgs e)
        {
            this.textBox1.Text = "";
        }
       

       
    }
}
