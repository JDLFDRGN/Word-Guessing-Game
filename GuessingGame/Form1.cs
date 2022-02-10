using System;
using System.Collections;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        int lives = 3, score = 0, randomNumber = 0;
        string inputAnswer = "";

        ArrayList Flower;

        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();

            Flower = new ArrayList
            {
                "gumamela",
                "sampaguita",
                "sunflower",
                "rose",
                "dandelion"
            };
            Lives.Text = lives.ToString();
            Score.Text = score.ToString();

            randomNumber = random.Next(5);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            inputAnswer = submitAnswer.Text;

            submitAnswer.Text = "";

            randomNumber = random.Next(5);
    
            if (inputAnswer == Flower[randomNumber].ToString())
            {
                score++;
                Score.Text = score.ToString();
            }
            else
            {
                lives--;
                Lives.Text = lives.ToString();      
            }
            if (lives == 0)
            {
                MessageBox.Show("Gameover\n\n" + "Final score: " + score);
                submit.Enabled = false;
                return;
            }
        }
    }
}
