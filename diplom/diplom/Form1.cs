using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form1 : Form
    {
        string FilePath = ""; //путь к исходному изображению
        string Folder = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourceImg= new OpenFileDialog();
            if (sourceImg.ShowDialog() == DialogResult.OK)
            {
                FilePath = sourceImg.FileName;
                textBox1.Text = FilePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                Folder = folder.SelectedPath;
                textBox2.Text = Folder;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BreakImg breakShit = new BreakImg(FilePath,Folder);
            breakShit.breakShit();
        }
    }
}
