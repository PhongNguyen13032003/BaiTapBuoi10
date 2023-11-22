using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        public Form1()
        {
            InitializeComponent();
            questions = new List<Question>
            {
                new Question("what?", "A.A", "B.B", "C.C", "D.D", 'A'),
                new Question("what?", "A.A", "B.B", "C.C", "D.D", 'B')
            };
            currentQuestionIndex = 0;
            ShowQuestion(currentQuestionIndex);

        }
        private void ShowQuestion(int questionIndex)
        {
            if(questionIndex>=0 && questionIndex<questions.Count)
            {
                Question question = questions[questionIndex];
                label1.Text = question.Text;
                ARadioButton.Text = question.OptionA;
                BRadioButton.Text = question.OptionB;
                CRadioButton.Text = question.OptionC;
                DRadioButton.Text = question.OptionD;
                ARadioButton.Checked = false;
                BRadioButton.Checked = false;
                CRadioButton.Checked = false;
                DRadioButton.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char userAnswer = ' ';
            if (ARadioButton.Checked)
            {
                userAnswer = 'A';
            }
            else if (BRadioButton.Checked)
            {
                userAnswer = 'B';
            }
            else if (CRadioButton.Checked)
            {
                userAnswer = 'C';
            }
            else if (DRadioButton.Checked)
            {
                userAnswer = 'D';
            }

            Question currentQuestion = questions[currentQuestionIndex];
            if (userAnswer == currentQuestion.Answer)
            {
                MessageBox.Show("Dap An Dung!");
            }
            else
            {
                MessageBox.Show("Dap An Sai!");
            }
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                ShowQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("Hoan Thanh Cau Hoi");
                Close();
            }

        }
        public class Question
        {
            public string Text { get; }
            public string OptionA { get; }
            public string OptionB { get; }
            public string OptionC { get; }
            public string OptionD { get; }
            public char Answer { get; }
            public Question(string text, string optionA, string optionB, string optionC, string optionD, char answer)
            {
                Text = text;
                OptionA = optionA;
                OptionB = optionB;
                OptionC = optionC;
                OptionD = optionD;
                Answer = answer;
            }
        }
    }
}
