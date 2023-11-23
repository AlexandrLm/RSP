namespace RSP
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Rock = new Button();
            Scissors = new Button();
            Paper = new Button();
            Score = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(Rock, 0, 0);
            tableLayoutPanel1.Controls.Add(Scissors, 1, 0);
            tableLayoutPanel1.Controls.Add(Paper, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 298);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(776, 140);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Rock
            // 
            Rock.Dock = DockStyle.Fill;
            Rock.Location = new Point(3, 3);
            Rock.Name = "Rock";
            Rock.Size = new Size(252, 134);
            Rock.TabIndex = 0;
            Rock.Text = "Rock";
            Rock.UseVisualStyleBackColor = true;
            Rock.Click += Rock_Click;
            // 
            // Scissors
            // 
            Scissors.Dock = DockStyle.Fill;
            Scissors.Location = new Point(261, 3);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(252, 134);
            Scissors.TabIndex = 1;
            Scissors.Text = "Scissors";
            Scissors.UseVisualStyleBackColor = true;
            Scissors.Click += Scissors_Click;
            // 
            // Paper
            // 
            Paper.Dock = DockStyle.Fill;
            Paper.Location = new Point(519, 3);
            Paper.Name = "Paper";
            Paper.Size = new Size(254, 134);
            Paper.TabIndex = 2;
            Paper.Text = "Paper";
            Paper.UseVisualStyleBackColor = true;
            Paper.Click += Paper_Click;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Location = new Point(616, 26);
            Score.Name = "Score";
            Score.Size = new Size(172, 20);
            Score.TabIndex = 1;
            Score.Text = "игрок - 0 противник - 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(564, 41);
            label1.TabIndex = 2;
            label1.Text = "Выберите камень, ножницы или бумагу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(693, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Счет";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(15, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(773, 239);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Score);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Rock;
        private Button Scissors;
        private Button Paper;
        private Label Score;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}