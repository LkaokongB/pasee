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
    public partial class Group5 : Form
    {
        public Group5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home one = new home();
            one.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nation = int.Parse(numericUpDown1.Text);
            int edusport = int.Parse(numericUpDown2.Text);
            int book = int.Parse(numericUpDown3.Text);
            int otop = int.Parse(numericUpDown4.Text);
            int travalmain = int.Parse(numericUpDown7.Text);
            int travalsecond = int.Parse(numericUpDown8.Text);
            int spendhouse1 = int.Parse(numericUpDown6.Text);
            int spendcar1 = int.Parse(numericUpDown5.Text);
            int spendhouse2 = int.Parse(numericUpDown9.Text);
            int spendcar2 = int.Parse(numericUpDown10.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int outcome;
            if ((travalmain + travalsecond) >= 20000)
            {
                a = 20000;
            }
            else if ((travalmain + travalsecond) < 20000)
            {
                a = travalmain + travalsecond;
            }
            if ((spendhouse1 + spendcar1) >= 100000)
            {
                b = 100000;
            }
            else if ((spendhouse1 + spendcar1) < 100000)
            {
                b = spendhouse1 + spendcar1;
            }
            if ((spendhouse2 + spendcar2) >= 100000)
            {
                c = 100000;
            }
            else if ((spendhouse2 + spendcar2) < 100000)
            {
                c = spendhouse2 + spendcar2;
            }
            {
                outcome = (nation + edusport + book + otop + a + b + c);
                textBox1.Text = outcome.ToString();
            }
        }

        private void Group5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox5.Text);
            int pasee = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            {
                outcome = (month * 12) + pasee + other;
                textBox4.Text = outcome.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y = int.Parse(textBox4.Text);
            int outcome2;
            int pasee = int.Parse(textBox1.Text);
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
    }
}
