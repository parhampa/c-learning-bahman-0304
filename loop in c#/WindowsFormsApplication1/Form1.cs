using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i += 2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i += 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i += 2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i += 2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int tst;
            int inp;
            if (int.TryParse(textBox1.Text,out tst) == true)
            {
                inp = int.Parse(textBox1.Text);
                for (int i = 1; i <= inp; i++)
                {
                    if (inp % i == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }

            }else
            {
                MessageBox.Show("ورودی شما صحیح نمی باشد");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int tst;
            int inp;
            int count = 0;
            if (int.TryParse(textBox1.Text, out tst) == true)
            {
                inp = int.Parse(textBox1.Text);
                for (int i = 2; i < inp; i++)
                {
                    if (inp % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("اول است");
                }
                else
                {
                    MessageBox.Show("اول نیست");
                }

            }
            else
            {
                MessageBox.Show("ورودی شما صحیح نمی باشد");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int inp = 2; inp <= 100; inp++)
            {
                int count = 0;
                for (int i = 2; i < inp; i++)
                {
                    if (inp % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    listBox1.Items.Add(inp);
                }
            }
        }
    }
}
