using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace بازی_کلمات__2
{
    public partial class Form1 : Form
    {
        public int secondsToWait = 30;
        public DateTime startTime;
        string[] arry = new string[10] { "دفتر", "کتاب", "مداد", "خرما", "خیار", "خنده", "فروش", "خرید", "سایه", "زبان" };
        string myWord;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            timer1.Start();
            startTime = DateTime.Now;
            Random rnd = new Random();
            int rand = rnd.Next(0, 9);
           // label3.Text = rand.ToString();
            for (int i = 0; i < 4; i++)
            {
                rand = rnd.Next(0, 9);
                label3.Text = arry[rand];
            }
            myWord = arry[rand];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
            int remainingSeconds = secondsToWait - elapsedSeconds;

            if (remainingSeconds == 0)
            {
                timer1.Stop();
                this.BackColor = Color.Red;
                this.Text = "باختی";
                label2.Text = "!!!وقت تمام شد";
            }
            else
                this.BackColor = Color.White;
            label1.Text = String.Format("{0} زمان باقی مانده...", remainingSeconds);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // this.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == myWord.Substring(0,1))
            {
                textBox1.BackColor = Color.LightGreen;
                this.Text = "جواب درست است";
            }
            else
            {
                textBox1.BackColor = Color.Red;
                this.Text = "جواب غلط است";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == myWord.Substring(1,1))
            {
                textBox2.BackColor = Color.LightGreen;
                this.Text = "افرین";
            }
            else
            {
                textBox2.BackColor = Color.Red;
                this.Text = "جواب غلط است";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == myWord.Substring(2, 1))
            {
                textBox3.BackColor = Color.LightGreen;
                this.Text = "عالی بود";
            }
            else
            {
                textBox3.BackColor = Color.Red;
                this.Text = "جواب غلط است";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == myWord.Substring(3, 1))
            {
                textBox4.BackColor = Color.LightGreen;
                this.Text = "برنده شدی";
                timer1.Stop();
                MessageBox.Show("برنده شدی.");            
            }
            else
            {
                textBox4.BackColor = Color.Red;
                this.Text = "جواب غلط است";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
