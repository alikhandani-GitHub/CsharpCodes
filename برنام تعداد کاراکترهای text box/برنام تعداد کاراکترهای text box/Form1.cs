using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace برنام_تعداد_کاراکترهای_text_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
            this.Text = textBox1.TextLength.ToString();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 97 && e.KeyChar <= 123)
                e.KeyChar = (char)(e.KeyChar - (char)32);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case 'a':
                    e.KeyChar = 'ش';
                    break;
                case 's':
                    e.KeyChar = 'س';
                    break;
            }
        }
        private void textBox2_textchenged(object sender, KeyPressEventArgs e)
        {

        }


    }
}
