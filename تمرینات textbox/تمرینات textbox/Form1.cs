using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace تمرینات_textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                    e.KeyChar = '\0';
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
                e.SuppressKeyPress = true;
        }
      
        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.Text = "نام را وارد کنید";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.Text = "نام خانوادگی را وارد کنید";
        }
    }
}
