using System;
using System.Threading;
using System.Windows.Forms;

namespace Esercizio1
{
    public partial class Form1 : Form
    {
        private int tempoRimanente; 
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
            tempo.Text = numericUpDown1.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { 
            tempo.Text = numericUpDown1.Value.ToString();
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tempo.Text) > 0)
            {
                tempoRimanente = Convert.ToInt16(tempo.Text);
                pausa = false;
                numericUpDown1.Visible = false;
                btnAvvia.Visible = false;

                tempo.Text = "Tempo rimanente: " + tempoRimanente + "s";

                timer = new System.Threading.Timer(ScadenzaTimer, null, 0, 1000);
            }
            else
            {
                MessageBox.Show("IL TEMPO DEVE ESSERE MAGGIORE DI 0!", "ERRORE");
            }
        }

        private void ScadenzaTimer(object state)
        {
            if (!pausa && tempoRimanente > 0)
            {
                tempoRimanente--;

                
                tempo.Text = "Tempo rimanente: " + tempoRimanente + "s";

                
                if (tempoRimanente == 0)
                {
                    timer.Dispose();//ferma il timer
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
