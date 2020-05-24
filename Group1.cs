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
    public partial class Group1 : Form
    {
        public Group1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home one = new home();
            one.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            int pasee = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            {
                outcome = (month * 12) + pasee + other;
                textBox4.Text = outcome.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = int.Parse(numericUpDown1.Text);
            int g = int.Parse(numericUpDown2.Text);
            int h = int.Parse(numericUpDown3.Text);
            int i = int.Parse(numericUpDown4.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int ex = 0;
            int outcome1;
            if (radioButton5.Checked == true)
            {
                a = a + 60000;
            }
            if (checkBox1.Checked == true)
            {
                b = b + 30000;
            }
            if (checkBox2.Checked == true)
            {
                c = c + 30000;
            }
            if (checkBox3.Checked == true)
            {
                d = d + 30000;
            }
            if (checkBox4.Checked == true)
            {
                ex = ex + 30000;
            }

            f = f * 30000;
            g = g * 60000;
            i = i * 60000;
            {
                outcome1 = a + b + c + ex + f + g + i + h + d;
                textBox5.Text = outcome1.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y = int.Parse(textBox4.Text);
            int outcome2;
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
            outcome2 = y - pasee;
            textBox7.Text = outcome2.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
