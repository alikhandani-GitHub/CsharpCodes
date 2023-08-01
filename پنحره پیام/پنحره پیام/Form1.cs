using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace پنحره_پیام
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r=MessageBox.Show("?خارج میشوید","تایید خروج",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button3,MessageBoxOptions.ServiceNotification);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
