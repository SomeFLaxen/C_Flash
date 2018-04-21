using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 随机生成整数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] a = new int[10];
            Random r = new Random();
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(30, 100);
                total += a[i];
                textBox1.Text = textBox1.Text + " " + a[i].ToString();
            }

            int temp = 0;

            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 9-k; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            textBox1.Text += "\r\n";

            textBox1.Text = textBox1.Text + "min=" + a[0] + " " + "max=" + a[9] + " " + "avg=" + (total / 10);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {      
        }
    }
}
