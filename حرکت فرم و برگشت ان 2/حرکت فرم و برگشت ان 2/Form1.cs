using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace حرکت_فرم_و_برگشت_ان_2
{
    public partial class Form1 : Form
    {
        int c = 20;
        int d = 20;
        int s = 20;
        int a = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (this.Text == "حرکت")
            {
                this.Text = "توقف";
                this.timer1.Enabled = false;
            }
            else if (this.Text == "توقف")
            {
                this.Text = "حرکت";
                this.timer1.Enabled = true;
            }*/
           // MessageBox.Show(Screen.PrimaryScreen.Bounds.Width.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left += c;
            this.Top += d;
            if (this.Width + this.Left > Screen.PrimaryScreen.Bounds.Width||this.Left<0)
                c = -c;
            else if (this.Height + this.Top > Screen.PrimaryScreen.Bounds.Height || this.Top<0)
                d = -d;
        }
           

        
    }
}
