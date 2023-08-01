using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace رنگین_کمان_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Purple)
            {
                this.BackColor = Color.Blue;
                this.Text = "ابی";

            }
            else if(this.BackColor==Color.Blue)
            {
                this.BackColor = Color.Green;
                this.Text = "سبز";
            }
            else
            {
                this.BackColor = Color.Purple;
                this.Text = "بنفش";
            }
        }
    }
}
