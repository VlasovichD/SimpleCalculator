using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Presenter
    {
        Calculation calc = null;
        Form1 form1 = null;

        public Presenter(Form1 form1)
        {
            this.calc = new Calculation();
            this.form1 = form1;
            this.form1.Calculate += Form1_Calculate;

        }

        private void Form1_Calculate(object sender, EventArgs e)
        {
            foreach (Match m in Regex.Matches(form1.textBox1.Text, @"([+-]?\d*[.,]?\d+)([-+*/])([+-]?\d*[.,]?\d+)"))
            {
                double.TryParse(m.Groups[1].Value.Replace('.',','), out double number1);
                char.TryParse(m.Groups[2].Value, out char symbol);
                double.TryParse(m.Groups[3].Value.Replace('.', ','), out double number2);

                try
                {
                    form1.textBox1.Text = calc.Calculate(number1, number2, symbol).ToString();
                }
                catch (AppException ex)
                {
                    form1.textBox1.Text = ex.Message;
                    form1.textBox1.KeyDown += TextBox1_KeyDown;
                }
                
            }
        }

        private void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            form1.textBox1.Clear();
            form1.textBox1.KeyDown -= TextBox1_KeyDown;
        }
    }
}
