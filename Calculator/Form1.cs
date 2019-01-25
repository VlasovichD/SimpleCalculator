using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private EventHandler calculate;

        public event EventHandler Calculate
        {
            add { calculate += value; }
            remove { calculate -= value; }
        }

        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);

        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonСalculate_Click(object sender, EventArgs e)
        {
            calculate.Invoke(sender, e);
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Select(textBox1.Text.Length, 0);
        }

    }
}
