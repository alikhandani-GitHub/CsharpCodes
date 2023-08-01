using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مثال_منو2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ابیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void سبزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void قرمزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ساعتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
            timer1.Tick += new EventHandler(ساعتToolStripMenuItem_Click);
           // timer1.Interval = 800;
            timer1.Start();
                ساعتToolStripMenuItem.Checked = false;
                عبارتدلخواهToolStripMenuItem.Checked = false;
               // timer1.Stop();
        }

        private void عبارتدلخواهToolStripMenuItem_Click(object sender, EventArgs e)
        {                      
                خالیToolStripMenuItem.Checked = false;
                ساعتToolStripMenuItem.Checked = false;
          //  textBox1.Enabled = true;
               this.Text = textBox1.Text;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text += textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  this.Text = DateTime.Now.ToString();
        }

        private void تغییرعنوانToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void خالیToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
                ساعتToolStripMenuItem.Checked = false;
                عبارتدلخواهToolStripMenuItem.Checked = false;            
            this.Text = "";
            timer1.Stop();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
