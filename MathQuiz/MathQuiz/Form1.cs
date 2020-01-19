using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            todaysDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        //Randomizer
        Random randomizer = new Random();

        //Integers for Addition problem
        int addend1;
        int addend2;

        // Integers for the subtraction problem
        int minuend;
        int subtrahend;

        // Integers for the multiplication problem
        int multiplicand;
        int multiplier;

        // Integers for the division problem
        int dividend;
        int divisor;

        // Integer to keep track of quiz time
        int timeLeft;

        //Set the start button
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            timeLabel.BackColor = Color.White;
        }

        //Start the Quiz
        public void StartTheQuiz()
        {
            //Generate two randome numbers and store them
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Creating stings to store numbers
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //Sets the value to 0
            sum.Value = 0;

            //Fill in the subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            //Fill in the multiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //Fill in the division problem
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //Start the Timer
            timeLeft = 30;
            timeLabel.Text = "30 Seconds";
            timer1.Start();
        }

        //Timer
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //If CheckTheAnswer() returns true, then the user got the answer right. Stop the timer and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                //If CheckTheAnswer() return false, keep counting down. Decrease the time left by one second and display the new time left by updating the Time Left label.
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //If the user ran out of time, stop the timer, show a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                startButton.Enabled = true;
            }
            if (timeLeft <= 5)
            {
                //Changes the text color from Black to Red
                timeLabel.BackColor = Color.Red;
            }
            
        }

        // Check answers
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
            {
                return true;
            }
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in NumericUpDown control 
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        
    }
}




