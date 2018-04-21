using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 文件打开与保存
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.Multiselect = true;
            fileDialog.Title = "打开";
            fileDialog.Filter = "所有文件(*txt *) | *.txt * ";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "")
                return;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = this.saveFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("文件已成功保存");
            }
        }

        static private int j = 0;
        private void button3_Click(object sender, EventArgs e)
        {
                //查找下一个
                richTextBox1.Focus();
                int k;
                k = richTextBox1.Text.IndexOf(".net", j);
                //String类的IndexOf方法是查找子字符串，如果找到返回子字符串开始位置
                if (k >= 0)
                { //显示字符串
                    richTextBox1.SelectionStart = k;  // SELECTTIONSTART开始位置从0算起
                    richTextBox1.SelectionLength = 4;
                    j = k + 1;  //  从原来找到的".NET"下一个字符起继续查找               
                }
                else    //找不到，k=-1
                    MessageBox.Show("没找到");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

  
}
