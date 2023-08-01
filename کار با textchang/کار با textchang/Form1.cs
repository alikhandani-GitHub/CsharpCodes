using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace کار_با_textchang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "i")
                button1.Enabled = true;
            else
                textBox1.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                MessageBox.Show("شما کلید اسکیپ را فشار دادید");
            else if (e.KeyChar == 13)
                this.BackColor = Color.Green;
            else if (e.KeyChar == 'a')
                e.KeyChar='b';
            else
                this.BackColor = Color.Yellow;
        }
    }
}
