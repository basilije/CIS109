/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 9: Create your own calculator
 * */

using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result_value = 0;
        string operator_clicked = "";
        bool is_operator_clicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickButton(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || is_operator_clicked)
                resultBox.Clear();

            is_operator_clicked = false;
            Button button = (Button)sender;

            if ( ((button.Text != ".")) || ((button.Text == ".") && (!resultBox.Text.Contains("."))) )
                resultBox.Text += button.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result_value != 0)
            {
                btnEquals.PerformClick();
                operator_clicked = button.Text;                
            }
            else
            {
                operator_clicked = button.Text;
                result_value = Double.Parse(resultBox.Text);
            }

            is_operator_clicked = true;
            operator_clicked = button.Text;
            result_value = Double.Parse(resultBox.Text);

        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            result_value = 0;
        }

        private void BtnEqualsClick(object sender, EventArgs e)
        {
            switch (operator_clicked)
            {
                case "+":
                    resultBox.Text = (result_value + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (result_value - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "×":
                    resultBox.Text = (result_value * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "÷":
                    resultBox.Text = (result_value / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
