using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizPRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string path = @".\Quiz.txt";

            string[] content = File.ReadAllLines(path, Encoding.UTF8);
            foreach (string item in content)
            {
                listBox1.Items.Add(item);
            }   
            
        }
    }
}
