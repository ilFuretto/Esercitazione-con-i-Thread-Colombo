namespace Esercizio1
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
            numericUpDown1 = new NumericUpDown();
            btnPausa = new Button();
            btnRiprendi = new Button();
            tempo = new Label();
            lblStato = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAvvia
            // 
            btnAvvia.BackColor = Color.Lime;
            btnAvvia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvvia.Location = new Point(359, 216);
            btnAvvia.Name = "btnAvvia";
            btnAvvia.Size = new Size(92, 52);
            btnAvvia.TabIndex = 0;
            btnAvvia.Text = "AVVIA";
            btnAvvia.UseVisualStyleBackColor = false;
            btnAvvia.Click += btnAvvia_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(343, 187);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnPausa
            // 
            btnPausa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPausa.Location = new Point(167, 216);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new Size(92, 52);
            btnPausa.TabIndex = 2;
            btnPausa.Text = "PAUSA";
            btnPausa.UseVisualStyleBackColor = true;
            btnPausa.Click += btnPausa_Click;
            // 
            // btnRiprendi
            // 
            btnRiprendi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRiprendi.Location = new Point(537, 216);
            btnRiprendi.Name = "btnRiprendi";
            btnRiprendi.Size = new Size(92, 52);
            btnRiprendi.TabIndex = 3;
            btnRiprendi.Text = "RIPRENDI";
            btnRiprendi.UseVisualStyleBackColor = true;
            btnRiprendi.Click += btnRiprendi_Click;
            // 
            // tempo
            // 
            tempo.AutoSize = true;
            tempo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            tempo.Location = new Point(272, 121);
            tempo.Name = "tempo";
            tempo.Size = new Size(128, 50);
            tempo.TabIndex = 4;
            tempo.Text = "label1";
            tempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStato
            // 
            lblStato.AutoSize = true;
            lblStato.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStato.Location = new Point(607, 95);
            lblStato.Name = "lblStato";
            lblStato.Size = new Size(0, 37);
            lblStato.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStato);
            Controls.Add(tempo);
            Controls.Add(btnRiprendi);
            Controls.Add(btnPausa);
            Controls.Add(numericUpDown1);
            Controls.Add(btnAvvia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvvia;
        private NumericUpDown numericUpDown1;
        private Button btnPausa;
        private Button btnRiprendi;
        private Label tempo;
        private Label lblStato;
    }
}
