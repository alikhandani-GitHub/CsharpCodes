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

namespace NotePade_example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Stream fs = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(fs);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(textBox1.Text);
            writer.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            textBox1.Width = this.Width + 16;
            textBox1.Height = this.Height + 66;
        }
    }
}
