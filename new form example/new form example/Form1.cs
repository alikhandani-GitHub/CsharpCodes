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
   
    public partial class Form1 : Form
    {
        Form2 myform = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Form2 myform = new Form2();
            myform.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
                e.KeyChar = 'a';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
                e.KeyChar = 'b';
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
                e.KeyChar = 'c';
        }
    }
}
