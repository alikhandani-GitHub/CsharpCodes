using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void دانشاموزجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = "iran";
                دانشاموزجدیدToolStripMenuItem.Checked = true;
            }
            else
            {
                this.Text = "";
                دانشاموزجدیدToolStripMenuItem.Checked = false;
            }
        }

        private void ویرایشدانشاموزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "برنامه منو";
        }
    }
}
