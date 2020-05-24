using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Group2 : Form
    {
        public Group2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            int bonus = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            {
                outcome = ((month * 12) + bonus + other);
                textBox4.Text = outcome.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDown7.Enabled = true;
            }
            else
            {
                numericUpDown7.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDown1.Text);
            int b = int.Parse(numericUpDown2.Text);
            int c = int.Parse(numericUpDown3.Text);
            int d = int.Parse(numericUpDown4.Text);
            int ea = int.Parse(numericUpDown5.Text);
            int f = int.Parse(numericUpDown6.Text);
            int n = int.Parse(numericUpDown7.Text);
            int k = 0;
            int outcome;
            if ((b + c) > 100000)
            {
                k = 100000;
            }
            else if ((b + c) < 100000)
            {
                k = b + c;
            }

            {
                outcome = (a + k + d + ea + n + f);
                textBox5.Text = outcome.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox4.Text);
            int outcome;
            int pasee = int.Parse(textBox5.Text);
            if (pasee > 5000000)
            {
                pasee = ((pasee * 35) / 100);
            }
            else if (pasee > 2000000)
            {
                pasee = ((pasee * 30) / 100);
            }
            else if (pasee > 1000000)
            {
                pasee = ((pasee * 25) / 100);
            }
            else if (pasee > 750000)
            {
                pasee = ((pasee * 20) / 100);
            }
            else if (pasee > 500000)
            {
                pasee = ((pasee * 15) / 100);
            }
            else if (pasee > 300000)
            {
                pasee = ((pasee * 10) / 100);
            }
            else if (pasee > 150000)
            {
                pasee = ((pasee * 5) / 100);
            }
            else
            {
                pasee = 0;
            }
            textBox6.Text = pasee.ToString();
            outcome = x - pasee;
            textBox7.Text = outcome.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home one = new home();
            one.Show();
            Close();
        }
    }
}
