using System;
using System.Threading;
using System.Windows.Forms;

namespace Esercizio2
{
    public partial class Form1 : Form
    {
        private double tempoRimanente;
        private int intervallo;
        private double intervalloDouble;
        private bool pausa;
        private System.Threading.Timer timer;

        public Form1()
        {
            InitializeComponent();
            pausa = false;

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempo.Text = numericUpDownTempo.Value.ToString();
        }

        private void numericUpDownTempo_ValueChanged(object sender, EventArgs e)
        {
            tempo.Text = numericUpDownTempo.Value.ToString();
        }


        private void btnAvvia_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tempo.Text) > 0 && Convert.ToInt16(numericUpDownIntervallo.Value) > 0)
            {
                tempoRimanente = Convert.ToInt16(tempo.Text);
                intervallo = Convert.ToInt16(numericUpDownIntervallo.Value);
                pausa = false;

                numericUpDownTempo.Visible = false;
                label1.Visible = false;
                numericUpDownIntervallo.Visible = false;
                label2.Visible = false;
                btnAvvia.Visible = false;

                tempo.Text = "Tempo rimanente: " + tempoRimanente + "s";

                timer = new System.Threading.Timer(ScadenzaTimer, null, 0, intervallo);
                intervalloDouble = Convert.ToDouble(intervallo)/1000.0;
            }
            else
            {
                MessageBox.Show("IL TEMPO E L'INTERVALLO DEVONO ESSERE MAGGIORI DI 0!", "ERRORE");
            }
        }

        private void ScadenzaTimer(object state)
        {
            if (pausa==false && tempoRimanente > 0)
            {
                tempoRimanente-=intervalloDouble;

                tempo.Text = "Tempo rimanente: " + tempoRimanente + "s";

                if (tempoRimanente <= 0)
                {
                    timer.Dispose();
                    tempoRimanente = 0;
                    tempo.Text = "Tempo rimanente: " + tempoRimanente + "s";
                    MessageBox.Show("Tempo scaduto!");
                    tempo.Text = "Completato!";
                }
            }
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            pausa = true; 
        }

        private void btnRiprendi_Click(object sender, EventArgs e)
        {
            pausa = false; 
        }
    }
}
