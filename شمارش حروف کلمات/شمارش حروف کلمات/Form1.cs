using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace شمارش_حروف_کلمات
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] texti = textBox1.Text.Split(new[]{" "}, StringSplitOptions.None);
            string uzunkelime = " ";
            int karakterSayisi = 0;
            foreach (string kelime in texti)
            {
                ListViewItem liset = new ListViewItem();
                liset.Text = kelime;
                liset.SubItems.Add(kelime.Length.ToString());
                listView1.Items.Add(liset);
                if(kelime.Length>karakterSayisi)
                {
                    uzunkelime = kelime;
                    karakterSayisi = kelime.Length;
                }
            }
            textBox2.Text = uzunkelime;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
