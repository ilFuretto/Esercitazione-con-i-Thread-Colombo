namespace Esercizio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAvvia = new Button();
            btnRiprendi = new Button();
            btnPausa = new Button();
            numericUpDownTempo = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            tempo = new Label();
            label1 = new Label();
            numericUpDownIntervallo = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTempo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIntervallo).BeginInit();
            SuspendLayout();
            // 
            // btnAvvia
            // 
            btnAvvia.BackColor = Color.Lime;
            btnAvvia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvvia.Location = new Point(344, 228);
            btnAvvia.Name = "btnAvvia";
            btnAvvia.Size = new Size(103, 58);
            btnAvvia.TabIndex = 0;
            btnAvvia.Text = "AVVIA";
            btnAvvia.UseVisualStyleBackColor = false;
            btnAvvia.Click += btnAvvia_Click;
            // 
            // btnRiprendi
            // 
            btnRiprendi.BackColor = SystemColors.ControlLight;
            btnRiprendi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRiprendi.Location = new Point(515, 228);
            btnRiprendi.Name = "btnRiprendi";
            btnRiprendi.Size = new Size(103, 58);
            btnRiprendi.TabIndex = 1;
            btnRiprendi.Text = "RIPRENDI";
            btnRiprendi.UseVisualStyleBackColor = false;
            btnRiprendi.Click += btnRiprendi_Click;
            // 
            // btnPausa
            // 
            btnPausa.BackColor = SystemColors.ControlLight;
            btnPausa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPausa.Location = new Point(177, 228);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new Size(103, 58);
            btnPausa.TabIndex = 2;
            btnPausa.Text = "PAUSA";
            btnPausa.UseVisualStyleBackColor = false;
            btnPausa.Click += btnPausa_Click;
            // 
            // numericUpDownTempo
            // 
            numericUpDownTempo.Location = new Point(219, 183);
            numericUpDownTempo.Name = "numericUpDownTempo";
            numericUpDownTempo.Size = new Size(120, 23);
            numericUpDownTempo.TabIndex = 3;
            numericUpDownTempo.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownTempo.ValueChanged += numericUpDownTempo_ValueChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // tempo
            // 
            tempo.AutoSize = true;
            tempo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            tempo.Location = new Point(317, 90);
            tempo.Name = "tempo";
            tempo.Size = new Size(128, 50);
            tempo.TabIndex = 5;
            tempo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 159);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 6;
            label1.Text = "tempo(in s)";
            // 
            // numericUpDownIntervallo
            // 
            numericUpDownIntervallo.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownIntervallo.Location = new Point(435, 183);
            numericUpDownIntervallo.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownIntervallo.Name = "numericUpDownIntervallo";
            numericUpDownIntervallo.Size = new Size(120, 23);
            numericUpDownIntervallo.TabIndex = 7;
            numericUpDownIntervallo.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(367, 159);
            label2.Name = "label2";
            label2.Size = new Size(261, 21);
            label2.TabIndex = 8;
            label2.Text = "intervallo aggiornamento(in ms)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(numericUpDownIntervallo);
            Controls.Add(label1);
            Controls.Add(tempo);
            Controls.Add(numericUpDownTempo);
            Controls.Add(btnPausa);
            Controls.Add(btnRiprendi);
            Controls.Add(btnAvvia);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTempo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIntervallo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvvia;
        private Button btnRiprendi;
        private Button btnPausa;
        private NumericUpDown numericUpDownTempo;
        private MenuStrip menuStrip1;
        private Label tempo;
        private Label label1;
        private NumericUpDown numericUpDownIntervallo;
        private Label label2;
    }
}
