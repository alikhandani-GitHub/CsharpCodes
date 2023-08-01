using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ماشین_حساب_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        float x = 0; // +
        float y = 0; // *
        float z = 0; // -
        float s = 0; // /


     //   private void Form1_Load(object sender, EventArgs e)
      //  {

//
      //  }
        private void button15_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text != "")
            {

                z = float.Parse(resulttextbox.Text);

                resulttextbox.Clear();

            }
        }

        private void bndot_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text.Length == 1)


                resulttextbox.Text = resulttextbox.Text + ".";

        }
        private void button9_Click(object sender, EventArgs e)
        {

            if (resulttextbox.Text == "0")


                resulttextbox.Text = "";

            resulttextbox.Text = resulttextbox.Text + "1";





        }
        private void bn0_Click(object sender, EventArgs e)
        {

        }


        private void bn2_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "2";
        }


        private void bn3_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "3";
        }

        private void bn4_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "4";
        }

        private void bn5_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "5";
        }

        private void bn6_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "6";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void bnclear_Click(object sender, EventArgs e)
        {
            resulttextbox.Text = "0";
        }

        private void bn7_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "7";
        }

        private void bn8_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "8";
        }

        private void bn9_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text == "0")

                resulttextbox.Text = "";
            resulttextbox.Text = resulttextbox.Text + "9";
        }

        private void bnbackspace_Click(object sender, EventArgs e)
        {


            if (resulttextbox.Text.Length >= 1)
            {
                resulttextbox.Text = Convert.ToString(resulttextbox.Text.Remove(resulttextbox.Text.Length - 1));
            }
            if (resulttextbox.Text.Length < 1)
            {
                resulttextbox.Text = "0";
            }
        }

        private void bn0_CursorChanged(object sender, EventArgs e)
        {

            bn0.BackColor = Color.Yellow;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void bn1_MouseMove(object sender, MouseEventArgs e)
        {
            bn1.BackColor = Color.AliceBlue;
        }

        private void bn1_MouseLeave(object sender, EventArgs e)
        {
            bn1.BackColor = Color.White;
        }

        private void bn0_MouseMove(object sender, MouseEventArgs e)
        {
            bn0.BackColor = Color.Red;
        }

        private void bn0_MouseLeave(object sender, EventArgs e)
        {
            bn0.BackColor = Color.White;
        }

        private void bndot_MouseMove(object sender, MouseEventArgs e)
        {
            bndot.BackColor = Color.AliceBlue;
        }

        private void bndot_MouseLeave(object sender, EventArgs e)
        {
            bndot.BackColor = Color.White;
        }

        private void bn2_MouseMove(object sender, MouseEventArgs e)
        {
            bn2.BackColor = Color.AliceBlue;
        }

        private void bn2_MouseLeave(object sender, EventArgs e)
        {
            bn2.BackColor = Color.White;
        }

        private void bn3_MouseMove(object sender, MouseEventArgs e)
        {
            bn3.BackColor = Color.AliceBlue;
        }

        private void bn3_MouseLeave(object sender, EventArgs e)
        {
            bn3.BackColor = Color.White;
        }

        private void bn4_MouseMove(object sender, MouseEventArgs e)
        {
            bn4.BackColor = Color.AliceBlue;

        }

        private void bn4_MouseLeave(object sender, EventArgs e)
        {
            bn4.BackColor = Color.White;
        }

        private void bn5_MouseMove(object sender, MouseEventArgs e)
        {
            bn5.BackColor = Color.AliceBlue;
        }

        private void bn5_MouseLeave(object sender, EventArgs e)
        {
            bn5.BackColor = Color.White;
        }

        private void bn6_MouseMove(object sender, MouseEventArgs e)
        {
            bn6.BackColor = Color.AliceBlue;
        }

        private void bn6_MouseLeave(object sender, EventArgs e)
        {
            bn6.BackColor = Color.White;
        }

        private void bn7_MouseMove(object sender, MouseEventArgs e)
        {
            bn7.BackColor = Color.AliceBlue;
        }

        private void bn7_MouseLeave(object sender, EventArgs e)
        {
            bn7.BackColor = Color.White;
        }

        private void bn8_MouseMove(object sender, MouseEventArgs e)
        {

            bn8.BackColor = Color.AliceBlue;
        }

        private void bn8_MouseLeave(object sender, EventArgs e)
        {
            bn8.BackColor = Color.White;
        }

        private void bn29_MouseMove(object sender, MouseEventArgs e)
        {
            bn9.BackColor = Color.AliceBlue;
        }

        private void bn9_MouseLeave(object sender, EventArgs e)
        {
            bn9.BackColor = Color.White;
        }

        private void bnbackspace_MouseMove(object sender, MouseEventArgs e)
        {
            bnbackspace.BackColor = Color.AliceBlue;
        }

        private void bnbackspace_MouseLeave(object sender, EventArgs e)
        {
            bnbackspace.BackColor = Color.White;
        }

        private void bnclear_MouseMove(object sender, MouseEventArgs e)
        {
            bnclear.BackColor = Color.AliceBlue;
        }

        private void bnclear_MouseLeave(object sender, EventArgs e)
        {
            bnclear.BackColor = Color.White;
        }

        private void bnmosavi_MouseMove(object sender, MouseEventArgs e)
        {
            bnmosavi.BackColor = Color.AliceBlue;
        }

        private void bnmosavi_MouseLeave(object sender, EventArgs e)
        {
            bnmosavi.BackColor = Color.White;
        }

        private void bntaqsim_MouseMove(object sender, MouseEventArgs e)
        {
            bntaqsim.BackColor = Color.AliceBlue;
        }

        private void bntaqsim_MouseLeave(object sender, EventArgs e)
        {
            bntaqsim.BackColor = Color.White;
        }

        private void bnzarb_MouseMove(object sender, MouseEventArgs e)
        {
            bnzarb.BackColor = Color.AliceBlue;
        }

        private void bnzarb_MouseLeave(object sender, EventArgs e)
        {
            bnzarb.BackColor = Color.White;
        }

        private void bnmenha_MouseMove(object sender, MouseEventArgs e)
        {
            bnmenha.BackColor = Color.AliceBlue;
        }

        private void bnmenha_MouseLeave(object sender, EventArgs e)
        {
            bnmenha.BackColor = Color.White;
        }

        private void bnjam_MouseMove(object sender, MouseEventArgs e)
        {
            bnjam.BackColor = Color.AliceBlue;
        }

        private void bnjam_MouseLeave(object sender, EventArgs e)
        {
            bnjam.BackColor = Color.White;
        }

        private void bn0_Click_1(object sender, EventArgs e)
        {

            if (resulttextbox.Text == "0")
            {
                resulttextbox.Text = resulttextbox.Text + "";
            }
            else
            {
                resulttextbox.Text = resulttextbox.Text + "0";
            }
        }

        private void bnmosavi_Click(object sender, EventArgs e)
        {

            try
            {
                if (resulttextbox.Text != "")
                {
                    float sum = 0;

                    sum = float.Parse(resulttextbox.Text);
                    if (x > 0)
                    {
                        resulttextbox.Text = Convert.ToString(x + sum);
                        x = 0;
                    }
                    else if (y > 0)
                    {
                        resulttextbox.Text = Convert.ToString(y * sum);
                        y = 0;
                    }
                    else if (z > 0)
                    {
                        resulttextbox.Text = Convert.ToString(z - sum);
                        z = 0;
                    }
                    else if (s > 0)
                    {
                        resulttextbox.Text = Convert.ToString(s / sum);
                        s = 0;
                    }
                    comboBox1.Enabled = true;
                    clearhistory.Visible = true;
                    Useitemhistory.Visible = true;
                    if (resulttextbox.Text.Length <= 10)
                        comboBox1.Items.Add(resulttextbox.Text);

                }

                if (resulttextbox.Text.Length > 10)
                {
                    MessageBox.Show("Sorry,The Your Result is Long Number , ", "Error");
                    resulttextbox.Text = "0";
                }
            }
            catch
            {
            }
        }

        private void bnjam_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text != null)
            {

                x = float.Parse(resulttextbox.Text);


                resulttextbox.Clear();

            }
        }

        private void bnzarb_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text != "")
            {

                y = float.Parse(resulttextbox.Text);

                resulttextbox.Clear();
            }
        }

        private void clearhistory_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
        }

        private void clearhistory_MouseMove(object sender, MouseEventArgs e)
        {
            clearhistory.Font.Size.Equals(12);
        }

        private void bntaqsim_Click(object sender, EventArgs e)
        {
            if (resulttextbox.Text != "")
            {

                s = float.Parse(resulttextbox.Text);

                resulttextbox.Clear();

            }
        }

        private void resulttextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showOprToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            this.Size = new System.Drawing.Size(201, 425);


        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            this.Size = new System.Drawing.Size(201, 338);

        }

        private void bn0_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resulttextbox.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resulttextbox.Paste();
        }

        private void resulttextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ff = comboBox1.SelectedItem.ToString();

                resulttextbox.Text = ff;
            }
            catch
            {

            }

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(323, 317);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
