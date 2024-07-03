using System;
using System.Web.UI;

namespace _3_7_2024_Task2
{
    public partial class Calculator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }

        protected void BtnMultiply_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }

        protected void BtnDivide_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }

        protected void BtnSubtract_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void Calculate(char operation)
        {
            if (decimal.TryParse(Text1.Text, out decimal number1) && decimal.TryParse(Text2.Text, out decimal number2))
            {
                decimal result = 0;
                switch (operation)
                {
                    case '+':
                        result = number1 + number2;
                        break;
                    case '*':
                        result = number1 * number2;
                        break;
                    case '/':
                        if (number2 != 0) 
                            result = number1 / number2;
                        else
                            TextBox1.Text = "Error: Cannot divide by zero!";
                        break;
                    case '-':
                        result = number1 - number2;
                        break;
                }

                TextBox1.Text = result.ToString();
            }
            else
            {
                TextBox1.Text = "Error: Please enter valid numbers.";
            }
        }
    }
}
