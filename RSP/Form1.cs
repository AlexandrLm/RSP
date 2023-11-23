namespace RSP
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); // 1 - камень 2 - ножницы 3 - бумага
        int Enemy;
        int player_score = 0;
        int enemy_score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Score_Show()
        {
            Score.Text = $"игрок - {player_score} противник - {enemy_score}";
            if(enemy_score == 3)
            {
                MessageBox.Show("You lose");
                this.Close();
            }
            else if (player_score == 3)
            {
                MessageBox.Show("You win");
                this.Close();
            }
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            Enemy = rnd.Next(1, 4);
            if (Enemy == 1)
            {
                textBox1.Text += "Бот тоже выбрал камень, у вас ничья" + Environment.NewLine;
            }
            else if (Enemy == 2)
            {
                textBox1.Text += "Бот выбрал ножницы, вы победили!" + Environment.NewLine;
                player_score++;
            }
            else if (Enemy == 3)
            {
                textBox1.Text += "Бот выбрал бумагу, вы проиграли!" + Environment.NewLine;
                enemy_score++;
            }
            Score_Show();
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            Enemy = rnd.Next(1, 4);
            if (Enemy == 1)
            {
                textBox1.Text += "Бот выбрал камень, вы проиграли!" + Environment.NewLine;
                enemy_score++;
            }
            else if (Enemy == 2)
            {
                textBox1.Text += "Бот тоже выбрал ножницы, у вас ничья" + Environment.NewLine;
            }
            else if (Enemy == 3)
            {
                textBox1.Text += "Бот выбрал бумагу, вы победили!" + Environment.NewLine;
                player_score++;
            }
            Score_Show();
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            Enemy = rnd.Next(1, 4);
            if (Enemy == 1)
            {
                textBox1.Text += "Бот выбрал камень, вы победили!" + Environment.NewLine;
                player_score++;
            }
            else if (Enemy == 2)
            {
                textBox1.Text += "Бот выбрал ножницы, вы проиграли!" + Environment.NewLine;
                enemy_score++;
            }
            else if (Enemy == 3)
            {
                textBox1.Text += "Бот тоже выбрал бумагу, у вас ничья" + Environment.NewLine;
            }
            Score_Show();
        }
    }
}