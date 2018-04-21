using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 配置电脑
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in groupBox1.Controls.OfType<RadioButton>())
            {
                radioButton.CheckedChanged += radioButton_CheckedChanged;
            }

            foreach (RadioButton radioButton in groupBox2.Controls.OfType<RadioButton>())
            {
                radioButton.CheckedChanged += radioButton_CheckedChanged;
            }

            foreach(CheckBox checkBox in groupBox3.Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += checkBox_CheckedChanged;
            }
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        void checkBox_CheckedChanged(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
            else MessageBox.Show("请选择电脑", "提示");



            int c1 = 0, c2 = 0;

            if ((radioButton3.Checked == true) || (radioButton4.Checked == true) || (radioButton5.Checked == true))
            {
                c1++;
            }

            if (c1==0)
            {
                MessageBox.Show("请选择CPU", "提示");
            }
            else if (c1>1)
            {
                MessageBox.Show("CPU只能选择一项", "提示");
            }
            else if (c1==1)
            {
                if (radioButton3.Checked == true)
                    textBox1.Text += "\r\n" + radioButton3.Text;
                if (radioButton4.Checked == true)
                    textBox1.Text += "\r\n" + radioButton4.Text;
                if (radioButton5.Checked == true)
                    textBox1.Text += "\r\n" + radioButton5.Text;
            }

            if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                c2++;
            }
            if (c2==0)
            {
                MessageBox.Show("请选择内存", "提示");
            }
            else if (c2 > 1)
            {
                MessageBox.Show("内存只能选择一项", "提示");
            }
            else if (c2==1)
            {
                if (radioButton1.Checked == true)
                    textBox1.Text += "\r\n" + radioButton1.Text;
                if (radioButton2.Checked == true)
                    textBox1.Text += "\r\n" + radioButton2.Text;
            }

            if (checkBox1.Checked==true)
                textBox1.Text += "\r\n" + checkBox1.Text;
            if (checkBox2.Checked == true)
                textBox1.Text += "\r\n" + checkBox2.Text;
            if (checkBox3.Checked == true)
                textBox1.Text += "\r\n" + checkBox3.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

