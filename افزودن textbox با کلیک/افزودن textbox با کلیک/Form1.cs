using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace افزودن_textbox_با_کلیک
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            TextBox txtRun = new TextBox();           
            c++;
            txtRun.Location = new System.Drawing.Point(20, 18 + (20 * c));
            txtRun.Size = new System.Drawing.Size(100, 25);
            this.Controls.Add(txtRun);            
        }
    }
}
