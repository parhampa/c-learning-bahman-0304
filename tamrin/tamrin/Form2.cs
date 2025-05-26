/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/26/2025
 * Time: 8:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tamrin
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public int count=0;
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if(count>=0 && count<5){
				pictureBox1.Visible=false;
				pictureBox2.Visible=false;
				pictureBox3.Visible=true;
			}
			if(count>=5 && count<8){
				pictureBox1.Visible=false;
				pictureBox2.Visible=true;
				pictureBox3.Visible=false;
			}
			if(count>=8 && count<16){
				pictureBox1.Visible=true;
				pictureBox2.Visible=false;
				pictureBox3.Visible=false;
			}
			if(count>=16){
				count=0;
				pictureBox1.Visible=false;
				pictureBox2.Visible=false;
				pictureBox3.Visible=true;
			}
			count++;
			textBox1.Text=count.ToString();
		}
		void Form2Load(object sender, EventArgs e)
		{
			count=0;
			textBox1.Text=count.ToString();
			pictureBox1.Visible=false;
			pictureBox2.Visible=false;
		}
	}
}
