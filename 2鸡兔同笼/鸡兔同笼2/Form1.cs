using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 鸡兔同笼2
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(textBox1.Text.Trim()))
            {
                MessageBox.Show("头数必须是整值", "提示");
                textBox1.Focus();
                textBox3.Text = "";
                return;
            }

            if (double.Parse(textBox1.Text) % 1 != 0) 
            {
                MessageBox.Show("头数必须是整值", "提示");
                textBox1.Focus();
                textBox3.Text = "";
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(textBox2.Text) % 1 != 0)
            {
                MessageBox.Show("脚数必须是整值", "提示");
                textBox2.Focus();
                textBox3.Text = "";
                return;
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            int x, y;  //x--鸡数, y--兔数   

            

            if (e.KeyCode == Keys.Enter) 
            {
                if (!IsNumber(textBox2.Text.Trim()))
                {
                    MessageBox.Show("脚数必须是整值", "提示");
                    textBox2.Focus();
                    textBox3.Text = "";
                    return;
                }

                if (int.Parse(textBox2.Text) % 2 != 0)
                {
                    MessageBox.Show("脚数必须是双数", "提示");
                    textBox2.Focus();
                    textBox3.Text = "";
                    return;
                }

                

                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
                bool flag = false;
                for (int i = 1; i <= x; i++)
                {
                    if ((i * 2 + (x - i) * 4) == y)
                    {
                        textBox3.Text = i.ToString() + "       " + (x - i).ToString();
                        flag = true;
                    }
                }

                if (flag==false)
                {
                    MessageBox.Show("荒唐解！请重新输入", "提示");
                    textBox2.Focus();
                    textBox3.Text = "";
                    return;
                }
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
