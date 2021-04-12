using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class Form1 : Form
    {

        //random number generator
        Random randomizer = new Random();

        int addEnd1;
        int addEnd2;
        int minusEnd1;
        int minusEnd2;
        int multiplyEnd1;
        int multiplyEnd2;
        int divisionEnd1;
        int divisionEnd2;
        int timeLeft;

        public Form1()
        {
            InitializeComponent();

        }

        public void StartTheQuiz()
        {
            addEnd1 = randomizer.Next(51);
            addEnd2 = randomizer.Next(51);

            plusLeftLabel.Text = addEnd1.ToString();
            plusRightLabel.Text = addEnd2.ToString();

            sum.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            quizTimer.Start();
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PlusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void SumUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startTheQuizButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startTheQuizButton.Enabled = false;
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft.ToString() + " seconds";
            }else
            {
                quizTimer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addEnd1 + addEnd2;
                startTheQuizButton.Enabled = true;
            }
        }
    }
}
