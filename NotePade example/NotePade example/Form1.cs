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
    public partial class Form1 : Form
    {
        Form2 myform = new Form2();
        bool fileSaved1 = false;
        string myFilename;
        bool fileSaved2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                myFilename = openFileDialog1.FileName;
                Stream fs = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(fs);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
                this.Text = "Nodepad - " + Path.GetFileName(myFilename);
                fileSaved1 = true;
                fileSaved2 = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileSaved1==true)
            {
                FileStream fs = new FileStream(myFilename, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(textBox1.Text);                
                writer.Close();
                fileSaved2 = true;
            }
            else
            {
                saveFileDialog1.FileName = string.Empty;
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    myFilename = saveFileDialog1.FileName;
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.Write(textBox1.Text);
                    writer.Close();
                    this.Text = "Nodepad - " + Path.GetFileName(saveFileDialog1.FileName);
                    fileSaved1 = true;
                    fileSaved2 = true;
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileSaved2)
            {
                DialogResult r=MessageBox.Show("ذخیره شود؟", "پیغام", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
                switch(r)
                {
                    case DialogResult.Yes:
                        saveToolStripMenuItem_Click(sender, e);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;        
                }
                textBox1.Clear();             
                fileSaved1 = false;
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Width = this.Width + 16;
            textBox1.Height = this.Height + 66;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(textBox1.Text);
                writer.Close();
                this.Text = "Nodepad - " + Path.GetFileName(saveFileDialog1.FileName);
                fileSaved1 = true;
                fileSaved2 = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fileSaved2 = false;
        }
    }
}
