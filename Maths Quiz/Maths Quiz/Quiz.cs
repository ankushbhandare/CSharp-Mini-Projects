using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Quiz
{
    public partial class Quiz : Form
    {
        Random random = new Random();
        int count,numberOfQuestions;
        int minValue=0,maxValue;
        int answer;
        int totalCount = 0;
        int correctCount = 0;
        public Quiz()
        {
            InitializeComponent();
            count = 1;
        }

        public void GenerateQuiz(int selectedLevel,int count)
        {
            numberOfQuestions = count;
            if(selectedLevel == 0)
            {
                maxValue = 11;
            }
            else if(selectedLevel == 1)
            {
                maxValue = 51;
            }
            else
            {
                maxValue = 100;
            }
            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            txtAnswer.Clear();
            int number1 = random.Next(maxValue);
            int number2 = random.Next(maxValue);
            int operation=random.Next(4);
            try
            {
                switch (operation)
                {
                    case 0:
                        lblQuestion.Text = number1.ToString() + " + " + number2.ToString() + " = ?";
                        answer = number1 + number2;
                        break;
                    case 1:
                        lblQuestion.Text = number1.ToString() + " - " + number2.ToString() + " = ?";
                        answer = number1 - number2;
                        break;
                    case 2:
                        lblQuestion.Text = number1.ToString() + " * " + number2.ToString() + " = ?";
                        answer = number1 * number2;
                        break;
                    case 3:
                        if (number2 == 0)
                            number2 = random.Next(1, maxValue);
                        lblQuestion.Text = (number1*number2).ToString() + " / " + number2.ToString() + " = ?";
                        answer = number1;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            int userAnswer;
            try
            {
                if(!int.TryParse(txtAnswer.Text, out userAnswer))
                {
                    throw new ArgumentException();
                }
                if(userAnswer == answer)
                {
                    lblResult.Text = "Correct Answer";
                    correctCount++;
                }
                else
                {
                    lblResult.Text = "Incorrect Answer";
                }
                totalCount++;
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Please Enter Numbers Only!");
            }
            if(count<numberOfQuestions)
            {
                count++;
                GenerateQuestion();
            }
            else
            {
                showResult();
            }
        }

        private void showResult()
        {
            DialogResult result = MessageBox.Show("Quiz Over", "Result", MessageBoxButtons.OK);
            this.Close();
            this.Owner.Show();
        }

        private void txtAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSubmitAnswer_Click(sender, e);
        }

        private void Quiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}