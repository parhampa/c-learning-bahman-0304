/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/5/2025
 * Time: 7:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace timer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public class mymsg
	{
		public void show(string inp)
		{
			MessageBox.Show(inp);
		}
		
		private int calc(int a, int b){
			return a+b;
		}
		public void calshow(){
			this.show(this.calc(12,10).ToString());
		}
	}
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			mymsg tst=new mymsg();
			//tst.show("salam");
			tst.calshow();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if(textBox1.Text=="")
			{
				textBox1.Text="0";
			}else{
				int tst=int.Parse(textBox1.Text);
				tst++;
				textBox1.Text=tst.ToString();
			}
			
			int vaz=int.Parse(textBox1.Text);
			if(vaz<30 && vaz>0){
				pictureBox1.Visible=true;
				pictureBox2.Visible=false;
				pictureBox3.Visible=false;
			}
			if(vaz>30 && vaz<40){
				pictureBox1.Visible=false;
				pictureBox2.Visible=true;
				pictureBox3.Visible=false;
			}
			if(vaz>40 && vaz<60){
				pictureBox1.Visible=false;
				pictureBox2.Visible=false;
				pictureBox3.Visible=true;
			}
			if(vaz>60){
				vaz=0;
				textBox1.Text=vaz.ToString();
				pictureBox1.Visible=true;
				pictureBox2.Visible=false;
				pictureBox3.Visible=false;
			}
		}
	}
}
