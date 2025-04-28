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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void yek_ta_hezar()
        {
            for(int i = 1; i < 1000; i++)
            {
                if (is_aval(i) == true)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
            MessageBox.Show("finish");
        }

        public int bakhsh_pazirha(int inp)
        {
            int count = 0;
            if (inp == 0)
            {
                return 0;
            }
            if(inp == 1)
            {
                return 1;
            }
            for(int i = 1; i <= inp; i++)
            {
                if (inp % i == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public bool is_aval(int inp)
        {
            if (bakhsh_pazirha(inp) <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yek_ta_hezar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int a = 0; a <= 2; a++) //500 tomani
            {
                for(int b = 0; b <= 5; b++) //200
                {
                    for(int c = 0; c <= 10; c++) //100
                    {
                        for(int d = 0; d <= 20; d++)//50
                        {
                            for(int ee = 0; ee <= 40; ee++)//25
                            {
                                for(int f = 0; f <= 100; f++)//10
                                {
                                    for(int g = 0; g <= 200; g++)//5
                                    {
                                        if (a + b + c + d + ee + f + g == 1000)
                                        {
                                            string res = "";

                                            if (a > 0)
                                            {
                                                res += a.ToString() + " عدد 500 تومنی ";
                                            }
                                            if (b > 0)
                                            {
                                                res += b.ToString() + " عدد 200 تومنی ";
                                            }
                                            if (c > 0)
                                            {
                                                res += c.ToString() + " عدد 100 تومنی ";
                                            }
                                            if (d > 0)
                                            {
                                                res += d.ToString() + " عدد 50 تومنی ";
                                            }
                                            if (ee > 0)
                                            {
                                                res += ee.ToString() + " عدد 25 تومنی ";
                                            }
                                            if (f > 0)
                                            {
                                                res += f.ToString() + " عدد 10 تومنی ";
                                            }

                                            if (g > 0)
                                            {
                                                res += g.ToString() + " عدد 5 تومنی ";
                                            }
                                            listBox1.Items.Add(res);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }
    }
}
