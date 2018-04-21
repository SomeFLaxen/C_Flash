using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 判断回文数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsPalindrome(string text)
        {
            char[] temp;
            string reverse;
            reverse = text.Replace(" ", "");
            reverse = reverse.ToLower();
            temp = reverse.ToCharArray();
            System.Array.Reverse(temp);
            return reverse == new string(temp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (IsPalindrome(textBox1.Text))
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + "★" + "\r\n";
                }
                else
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + "\r\n";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
