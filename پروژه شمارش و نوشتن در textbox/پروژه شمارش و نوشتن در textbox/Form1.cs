using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace پروژه_شمارش_و_نوشتن_در_textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox txt;
            for (int i = 1; i <= 10; i++)
            {
                txt = new TextBox();
                txt.Location = new Point(20, i * 30);
                this.Controls.Add(txt);
                this.TextChanged += txt_textchang;
            }
            this.Text += txt.Text;
        }
      //  private void txt_textchang(object sender, EventArgs e)
        //{
          //  TextBox txt = sender as TextBox;
          //  this.Text+= txt.Text;

//        }
    }
}
