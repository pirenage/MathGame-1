using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;
        public Form1()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void IbIScore_Click(object sender, EventArgs e)
        {

        }

        private void IbINumA_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbAnswer_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswer(object sender, EventArgs e)
        {

        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {
            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                lblAnswer.Text = "Keren Puh";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Score: " + score;
                SetUpGame();

            }
            else
            {
                lblAnswer.Text = "NT gan";
                lblAnswer.ForeColor = Color.Red;
            }
        }

        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);

            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    break;

                case "Subtract":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Maroon;
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Blue;
                    break;
            }
            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
        }
    }
}
