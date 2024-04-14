namespace PizzaGame
{
    partial class ucPopUp
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            lblTurno = new Label();
            panel1 = new Panel();
            lblQuestion = new Label();
            panel2 = new Panel();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            btnConferma = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTurno
            // 
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurno.Location = new Point(0, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(588, 51);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "È IL TURNO DEL GIOCATORE";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTurno);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 51);
            panel1.TabIndex = 1;
            // 
            // lblQuestion
            // 
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(0, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(588, 54);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "QUANTE PIZZE VUOI MANGIARE?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblQuestion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 54);
            panel2.TabIndex = 3;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Enabled = false;
            rb1.Location = new Point(194, 121);
            rb1.Name = "rb1";
            rb1.Size = new Size(38, 24);
            rb1.TabIndex = 4;
            rb1.TabStop = true;
            rb1.Text = "1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Enabled = false;
            rb2.Location = new Point(283, 121);
            rb2.Name = "rb2";
            rb2.Size = new Size(38, 24);
            rb2.TabIndex = 5;
            rb2.TabStop = true;
            rb2.Text = "2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Enabled = false;
            rb3.Location = new Point(365, 121);
            rb3.Name = "rb3";
            rb3.Size = new Size(38, 24);
            rb3.TabIndex = 6;
            rb3.TabStop = true;
            rb3.Text = "3";
            rb3.UseVisualStyleBackColor = true;
            // 
            // btnConferma
            // 
            btnConferma.Dock = DockStyle.Bottom;
            btnConferma.Location = new Point(0, 170);
            btnConferma.Name = "btnConferma";
            btnConferma.Size = new Size(588, 55);
            btnConferma.TabIndex = 7;
            btnConferma.Text = "CONFERMO LA MIA SCELTA";
            btnConferma.UseVisualStyleBackColor = true;
            btnConferma.Click += btnConferma_Click;
            // 
            // ucPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnConferma);
            Controls.Add(rb3);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucPopUp";
            Size = new Size(588, 225);
            VisibleChanged += ucPopUp_VisibleChanged;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTurno;
        private Panel panel1;
        private Label lblQuestion;
        private Panel panel2;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private Button btnConferma;
    }
}
