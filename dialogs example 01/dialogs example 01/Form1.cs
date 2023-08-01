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

namespace dialogs_example_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult c = new DialogResult();
            c = colorDialog1.ShowDialog();
            if (c == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
          //  label1.Font = fontDialog1.Font;
           // label1.ForeColor = fontDialog1.Color;

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            label1.Font = fontDialog1.Font;
            label1.ForeColor = fontDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult r= folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
            if(r==DialogResult.OK)
            {
                DirectoryInfo selectedPath = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                listBox1.Items.Clear();
                if (selectedPath.GetDirectories().Length > 0)
                    listBox1.Items.Add("== Directories ==");
                foreach (DirectoryInfo dir in selectedPath.GetDirectories())
                    listBox1.Items.Add(dir.Name);
                if (selectedPath.GetFiles().Length > 0)
                    listBox1.Items.Add("== Files ==");
                foreach (FileInfo file in selectedPath.GetFiles())
                    listBox1.Items.Add(file.Name);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //openFileDialog1.Filter = "Text Files|*.txt";
           // openFileDialog1.FileName = string.Empty;
            DialogResult result = openFileDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                Stream fs = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(fs);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(textBox1.Text);
            writer.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
