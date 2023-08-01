using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_form_example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Green)
                BackColor = Color.Red;
            else
                BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form 2 loaded!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            this.Text += "Hi";
        }

        private void Form2_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Help");
        }
    }
}
