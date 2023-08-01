using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {

                case 0:
                    this.BackColor = Color.Green;
                    break;

                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Blue;
                    break;
            }   
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
                button1.Enabled = true;
         /*   List<string> fonts = new List<string>();
            foreach(FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);         
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.Text);       
           if (listBox1.Items.Count==0)
                button2.Enabled = false;     
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.Text);
            listBox2.Items.Remove(listBox2.Text);         
              if(listBox2.Text=="")
                button3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
               comboBox1.Items.Add(font.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(comboBox1.SelectedItem.ToString(), textBox1.Font.Size);
        }
    }
}
