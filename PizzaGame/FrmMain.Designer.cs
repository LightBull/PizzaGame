namespace PizzaGame
{
    partial class FrmMain
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtNameB = new TextBox();
            label2 = new Label();
            txtNameA = new TextBox();
            label1 = new Label();
            btnGeneraPizze = new Button();
            groupBox2 = new GroupBox();
            txtNumPizze = new TextBox();
            btnAvvia = new Button();
            txtBox = new TextBox();
            ucPopUp = new ucPopUp();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "NOMI GIOCATORI";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.18033F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.81967F));
            tableLayoutPanel1.Controls.Add(txtNameB, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNameA, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(297, 89);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtNameB
            // 
            txtNameB.Dock = DockStyle.Fill;
            txtNameB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameB.Location = new Point(74, 47);
            txtNameB.Name = "txtNameB";
            txtNameB.Size = new Size(220, 38);
            txtNameB.TabIndex = 3;
            txtNameB.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(65, 45);
            label2.TabIndex = 2;
            label2.Text = "B";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameA
            // 
            txtNameA.Dock = DockStyle.Fill;
            txtNameA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameA.Location = new Point(74, 3);
            txtNameA.Name = "txtNameA";
            txtNameA.Size = new Size(220, 38);
            txtNameA.TabIndex = 0;
            txtNameA.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 44);
            label1.TabIndex = 1;
            label1.Text = "A";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGeneraPizze
            // 
            btnGeneraPizze.Location = new Point(331, 50);
            btnGeneraPizze.Name = "btnGeneraPizze";
            btnGeneraPizze.Size = new Size(94, 60);
            btnGeneraPizze.TabIndex = 1;
            btnGeneraPizze.Text = "GENERA PIZZE";
            btnGeneraPizze.UseVisualStyleBackColor = true;
            btnGeneraPizze.Click += tbnGeneraPizze_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNumPizze);
            groupBox2.Location = new Point(442, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 76);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "PIZZE DA MANGIARE";
            // 
            // txtNumPizze
            // 
            txtNumPizze.Dock = DockStyle.Fill;
            txtNumPizze.Enabled = false;
            txtNumPizze.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumPizze.Location = new Point(3, 23);
            txtNumPizze.Name = "txtNumPizze";
            txtNumPizze.Size = new Size(164, 47);
            txtNumPizze.TabIndex = 0;
            txtNumPizze.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAvvia
            // 
            btnAvvia.Location = new Point(629, 50);
            btnAvvia.Name = "btnAvvia";
            btnAvvia.Size = new Size(94, 60);
            btnAvvia.TabIndex = 3;
            btnAvvia.Text = "AVVIA";
            btnAvvia.UseVisualStyleBackColor = true;
            btnAvvia.Click += btnAvvia_Click;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(12, 133);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.ScrollBars = ScrollBars.Vertical;
            txtBox.Size = new Size(711, 305);
            txtBox.TabIndex = 5;
            // 
            // ucPopUp
            // 
            ucPopUp.Choosed = 0;
            ucPopUp.Location = new Point(56, 158);
            ucPopUp.Name = "ucPopUp";
            ucPopUp.PizzeRemaining = 0;
            ucPopUp.PlayerName = "";
            ucPopUp.Size = new Size(578, 211);
            ucPopUp.TabIndex = 6;
            ucPopUp.Visible = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ucPopUp);
            Controls.Add(txtBox);
            Controls.Add(btnAvvia);
            Controls.Add(groupBox2);
            Controls.Add(btnGeneraPizze);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "PIZZA GAME";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtNameB;
        private Label label2;
        private TextBox txtNameA;
        private Label label1;
        private Button btnGeneraPizze;
        private GroupBox groupBox2;
        private TextBox txtNumPizze;
        private Button btnAvvia;
        private TextBox txtBox;
        private ucPopUp ucPopUp;
    }
}
