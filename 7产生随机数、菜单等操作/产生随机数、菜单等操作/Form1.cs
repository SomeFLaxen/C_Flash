using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 产生随机数_菜单等操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        public int  u2, u3 ;
        double u1;
        
        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Show();
            this.toolStripSplitButton1.Enabled = true;
            this.toolStripMenuItem2.Enabled = true;
            this.toolStripMenuItem3.Enabled = true;
            this.toolStripMenuItem4.Enabled = true;

            int total = 0;
            int[] a = new int[10];
            Random r = new Random();
            
            for (int i=0;i<10;i++)
            {
                a[i] = r.Next(10, 100);
                total += a[i];
                listBox1.Items.Add(a[i].ToString());
            }
            u1 = total;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int i, min = 999;

            for (i = 0; i < listBox1.Items.Count; i++)
            {
                if (min > Int32.Parse(listBox1.Items[i].ToString()))
                    min = Int32.Parse(listBox1.Items[i].ToString());
            }
            u2 = min;
            listBox1.Items.Remove(min.ToString());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int i, max = 0;

            for (i = 0; i < listBox1.Items.Count; i++)
            {
                if (max < Int32.Parse(listBox1.Items[i].ToString()))
                    max = Int32.Parse(listBox1.Items[i].ToString());
            }
            listBox1.Items.Remove(max.ToString());
            u3 = max;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int a = new int();
            Random r = new Random();
            a = r.Next(10, 100);
            listBox1.Items.Add(a.ToString());
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.textBox1.Text = u2.ToString();
            f2.textBox2.Text = u3.ToString();
            f2.textBox3.Text = (u1 / 10).ToString();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
