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
        //Randomizer
        Random randomizer = new Random();

        //Integers for Addition problem
        int addend1;
        int addend2;

        //
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;           
        }

        public void StartTheQuiz()
        {
            //Generate two randome numbers and store them
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Creating stings to store numbers
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;
        }
    }
}
