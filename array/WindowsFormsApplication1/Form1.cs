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
            int tst;
            if (int.TryParse(textBox1.Text, out tst) == false)
            {
                MessageBox.Show("ورودی عددی نیست");
            }
            else
            {
                int inp = int.Parse(textBox1.Text);
                for(int i = 1; i <= inp; i++)
                {
                    if(inp % i == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tst;
            if (int.TryParse(textBox1.Text, out tst) == false)
            {
                MessageBox.Show("ورودی عددی نیست");
            }
            else
            {
                int count = 0;
                int inp = int.Parse(textBox1.Text);
                if (inp == 1)
                {
                    MessageBox.Show("اول است");
                    return;
                }
                for (int i = 1; i <= inp; i++)
                {
                    if (inp % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    MessageBox.Show("عدد اول است");
                }
                else
                {
                    MessageBox.Show("عدد اول نیست");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tst;
            for (int inp = 1; inp < 100; inp++)
            {
                int count = 0;
                for (int i = 1; i <= inp; i++)
                {
                    if (inp % i == 0)
                    {
                        count++;
                    }
                }
                if (count <= 2)
                {
                    listBox1.Items.Add(inp);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] arr= new int[10];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;
            arr[6] = 7;
            arr[7] = 8;
            arr[8] = 9;
            arr[9] = 10;
            
            for(int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(arr[i]);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tst;
            int[] arr = new int[1000];
            int count_arr = 0;
            for (int inp = 1; inp < 1000; inp++)
            {
                int count = 0;
                for (int i = 1; i <= inp; i++)
                {
                    if (inp % i == 0)
                    {
                        count++;
                    }
                }
                if (count <= 2)
                {
                    //listBox1.Items.Add(inp);
                    arr[count_arr] = inp;
                    count_arr++;
                }
            }
            for(int i = 0; i < count_arr; i++)
            {
                listBox1.Items.Add(arr[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int tst;
            int[] arr = new int[1000];
            int count_arr = 0;

            int inp = 1;
            while(inp<1000)
            {
                int count = 0;
                int i = 1;
                while(i<=inp)
                {
                    if (inp % i == 0)
                    {
                        count++;
                    }
                    i++;
                }
                if (count <= 2)
                {
                    //listBox1.Items.Add(inp);
                    arr[count_arr] = inp;
                    count_arr++;
                }
                inp++;
            }
            int j= 0;
            while(j<count_arr)
            {
                listBox1.Items.Add(arr[j]);
                j++;
            }
        }
    }
}
