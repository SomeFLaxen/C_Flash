using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例15_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsNumber(string str)
        {
            bool yes = true;
            Char ch;
            int t = 0, len;
            len = str.Length;
            if (String.IsNullOrEmpty(str))
                yes = false;
            else
            {
                for (int i = 0; i < len; i++)
                {
                    ch = Char.Parse(str.Substring(i, 1));
                    if (ch == '.') t++;
                    if (t > 1)
                    {
                        yes = false;
                        break;
                    }

                    if (!Char.IsDigit(ch) && ch != '.')
                    {
                        yes = false;
                        break;
                    }
                }
            }
            return yes;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!IsNumber(textBox2.Text.Trim()))
            {
                MessageBox.Show("兑换比率必须是数值");
                return;
            }

            if (!IsNumber(textBox3.Text.Trim()))
            {
                MessageBox.Show("美元必须是数值");
                return;
            }

            textBox1.Text = (Math.Round(double.Parse(textBox2.Text.Trim()) * double.Parse(textBox3.Text.Trim()), 4)).ToString();
        }
   

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!IsNumber(textBox1.Text.Trim()))
            {
                MessageBox.Show("人民币必须是数值");
                return;
            }

            if (!IsNumber(textBox2.Text.Trim()))
            {
                MessageBox.Show("兑换比率必须是数值");
                return;
            }

            if (double.Parse(textBox2.Text.Trim()) == 0)
            {
                MessageBox.Show("兑换比率不能为0");
                textBox3.Text = 0.ToString();
                return;
            }
            textBox3.Text = (Math.Round(double.Parse(textBox1.Text.Trim()) / double.Parse(textBox2.Text.Trim()), 4).ToString());
        }
    }
}

