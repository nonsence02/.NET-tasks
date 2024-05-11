using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(a + b);
                        break;

                    case "-":
                        textBox3.Text = Convert.ToString(a - b);
                        break;

                    case "*":
                        textBox3.Text = Convert.ToString(a * b);
                        break;

                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("На нуль ділити не можна!");
                            break;
                        }
                        else
                        {
                            textBox3.Text = Convert.ToString(a / b);
                            break;
                        }

                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числа");
            }
           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
        }
    }
}

