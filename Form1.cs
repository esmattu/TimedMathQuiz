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
            
            // addition calculation
            addEnd1 = randomizer.Next(51);
            addEnd2 = randomizer.Next(51);

            plusLeftLabel.Text = addEnd1.ToString();
            plusRightLabel.Text = addEnd2.ToString();
            sum.Value = 0;

            //minus calculation

            minusEnd1 = randomizer.Next(51);
            minusEnd2 = randomizer.Next(1, minusEnd1);

            minusLeftLabel.Text = minusEnd1.ToString();
            minusRightlabel.Text = minusEnd2.ToString();
            minus.Value = 0;

            //multiplication calculation
            multiplyEnd1 = randomizer.Next(2, 11);
            multiplyEnd2 = randomizer.Next(2, 11);

            multiplicationLeftLabel.Text = multiplyEnd1.ToString();
            multiplicationRightLabel.Text = multiplyEnd2.ToString();
            multiplication.Value = 0;

            divisionEnd2 = randomizer.Next(2, 11);
            int temptQutotient = randomizer.Next(2, 11);
            divisionEnd1 = divisionEnd2 * temptQutotient;

            divisionLeftLabel.Text = divisionEnd1.ToString();
            divisionRightLabel.Text = divisionEnd2.ToString();

            division.Value = 0;

            timeLabel.BackColor = Color.Empty;
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
            if (checkTheAnswer())
            {
                quizTimer.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");

                startTheQuizButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft.ToString() + " seconds";
            }else
            {
                quizTimer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addEnd1 + addEnd2;
                minus.Value = minusEnd1 - minusEnd2;
                multiplication.Value = multiplyEnd1 * multiplyEnd2;
                division.Value = divisionEnd1 / divisionEnd2;
                startTheQuizButton.Enabled = true;
            }

            if(timeLeft < 6 )
            {
                timeLabel.BackColor = Color.Red;
            } 

        }

        private bool checkTheAnswer()
        {
            if ((addEnd1 + addEnd2 == sum.Value)
                && (minusEnd1 - minusEnd2 == minus.Value)
                && (multiplyEnd1 * multiplyEnd2 == multiplication.Value)
                && (divisionEnd1 / divisionEnd2 == division.Value))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if(answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

    }
}
