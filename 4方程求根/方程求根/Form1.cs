using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace 方程求根
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//a
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//b
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//c
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//x1
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//x2
        {

        }

        private void button1_Click(object sender, EventArgs e)//计算
        {
            if (textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty)
                MessageBox.Show("请输入系数", "提示");

            if (textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty)
            {
                double a, c, d, f, x1, x2, b;
                b = double.Parse(textBox5.Text);
                a = double.Parse(textBox3.Text);
                c = double.Parse(textBox4.Text);
                d = b * b - 4 * a * c;

                if (a==0)
                {
                    x1 = -(b / c);
                    groupBox1.Text = "有一个实根X";
                    label2.Text = "x=";
                    label3.Text = "";
                    textBox1.Text = x1.ToString();
                }
                else if (a!=0 && d >= 0)
                {
                    x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    if (d > 0)
                    {
                        groupBox1.Text = "有两个不同的实根";
                        textBox1.Text = x1.ToString();
                        textBox2.Text = x2.ToString();
                    }

                    if (d == 0)
                    {
                        groupBox1.Text = "有两个相同的实根";
                        textBox1.Text = x1.ToString();
                        textBox2.Text = x2.ToString();
                    }
                }

                else if (a!=0 && d<0)
                {
                    f = (Math.Sqrt(4 * a * c - b * b)) / (2 * a);
                    groupBox1.Text = "有两个不同的虚根";

                    textBox1.Text = (-b / (2 * a)).ToString() + "-" + Math.Round(f, 2).ToString() + "i";

                    textBox2.Text = (-b / (2 * a)).ToString() + "+" + Math.Round(f, 2).ToString() + "i";
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//结束
        {
            Application.Exit();
        }
    }
}
