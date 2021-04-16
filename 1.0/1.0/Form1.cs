using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cor.FileList fl = new Cor.FileList();
            fl.Start(textBox1.Text, textBox2.Text);
            MessageBox.Show("成功!", "提示");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "选择要生成的目录";
            if (textBox1.Text != "")
            {
                FBD.SelectedPath = textBox1.Text;

            }
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = FBD.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "选择保存位置";
            SFD.Filter = @"文本文件|*.txt";
            SFD.InitialDirectory = textBox2.Text == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : textBox2.Text;
            textBox2.Text = SFD.ShowDialog() == DialogResult.OK ? SFD.FileName : textBox2.Text;
        }
    }
}
