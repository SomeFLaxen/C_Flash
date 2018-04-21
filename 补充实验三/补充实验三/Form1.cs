using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 补充实验三
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 实验1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\1.exe";
            ps.Start();
        }

        private void 实验2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\2.exe";
            ps.Start();
        }

        private void 实验3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\3.exe";
            ps.Start();

        }

        private void 实验4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\4.exe";
            ps.Start();

        }

        private void 实验5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\5.exe";
            ps.Start();

        }

        private void 实验6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\6.exe";
            ps.Start();

        }

        private void 实验7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\7.exe";
            ps.Start();

        }

        private void 实验8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = @"C:\Users\zhang\Desktop\补充实验三 exe文件\8.exe";
            ps.Start();

        }
    }
}
