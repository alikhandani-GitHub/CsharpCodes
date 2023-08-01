using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_Resize
{
    public partial class Form1 : Form
    {
        int startWidth=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            textBox1.Text = "Resise Begin start";
            startWidth = this.Width;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            textBox1.Text = "Resise Begin end";
            if (this.Width > startWidth)
                textBox1.Text = "big  "+this.Width;
            else if (this.Width < startWidth)
                textBox1.Text = "small "+this.Width;
        }
    }
}
