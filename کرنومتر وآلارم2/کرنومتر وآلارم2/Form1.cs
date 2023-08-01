using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace کرنومتر_وآلارم2
{
    public partial class Form1 : Form
    {      
        int c = 15;
        int d = 15;
        // int i = 0;
        bool alarmEnabled = false;
        int chMinute = 0, chSecond = 0, chMillisecond = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* this.Left += c;
             this.Top += d;
             if (this.Width + this.Left > Screen.PrimaryScreen.Bounds.Width || this.Left < 0)
                 c = -c;
             else if (this.Height + this.Top > Screen.PrimaryScreen.Bounds.Height || this.Top < 0)
                 d = -d;*/
            label1.Text = DateTime.Now.ToLongTimeString();
            if (alarmEnabled == true && DateTime.Now.Hour.ToString() == textBox1.Text && DateTime.Now.Minute.ToString() == textBox2.Text)
            {
                button2_Click(sender, e);
                MessageBox.Show("finish!");
                alarmEnabled = false;
            }
            if (chkColor.Checked)
                ChangeDisplay();     
            if (chkMoving.Checked)
                movingForm();
            /* while (true)
             {
                 Random color = new Random();
                 Color randomColor = Color.FromArgb(color.Next(255), color.Next(255), color.Next(255));
                 label1.ForeColor = randomColor;
                 return;
             }*/
            /* switch (i)
             {
                 case 0:
                     label1.ForeColor = Color.Red;
                     i++;
                     break;
                 case 1:
                     label1.ForeColor = Color.Green;
                     i++;
                     break;
                 case 2:
                     label1.ForeColor = Color.Blue;
                     i++;
                     break;
                 case 3:
                     label1.ForeColor = Color.Yellow;
                     i++;
                     break;
                 case 4:
                     label1.ForeColor = Color.Purple;
                     i++;
                     break;
                 case 5:
                     label1.ForeColor = Color.Orange;
                     i++;
                     break;
                 case 6:
                     label1.ForeColor = Color.Indigo;
                     i++;
                     break;
             }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmEnabled = true;
            this.Text = "My Clock - Alarm set at: " + textBox1.Text + ":" + textBox2.Text;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alarmEnabled = false;
            this.Text = "My Clock";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer2.Start();
            // timer2.Enabled = true;
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            // timer2.Enabled = false;
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label4.Text = "00:00:00";
            //chMinute = 0;
            //chSecond = 0;
            //chMillisecond = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMoving_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            chMillisecond++;
            if (chMillisecond == 100)
            {
                chMillisecond = 0;
                chSecond++;
            }
            if (chSecond == 60)
            {
                chSecond = 0;
                chMinute++;
            }
            label4.Text = (chMinute < 10 ? "0" + chMinute.ToString() : chMinute.ToString()) + ":" + (chSecond < 10 ? "0" + chSecond.ToString() : chSecond.ToString()) + "." + (chMillisecond < 10 ? "0" + chMillisecond.ToString() : chMillisecond.ToString());
        }
       private void ChangeDisplay()
       {
            while (true)
            {
                Random color = new Random();
                Color randomColor = Color.FromArgb(color.Next(255), color.Next(255), color.Next(255));
                label1.ForeColor = randomColor;
                return;
            }
       }
        private void movingForm()
        {
            this.Left += c;
            this.Top += d;
            if (this.Width + this.Left > Screen.PrimaryScreen.Bounds.Width || this.Left < 0)
                c = -c;
            else if (this.Height + this.Top > Screen.PrimaryScreen.Bounds.Height || this.Top < 0)
                d = -d;
        }
    }
}
