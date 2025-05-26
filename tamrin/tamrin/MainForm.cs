/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/26/2025
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tamrin
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
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
		void Button1Click(object sender, EventArgs e)
		{
			Form1 fm=new Form1();
			//fm.Show();
			fm.ShowDialog();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int count=0;
			for(int i=0;i<=2;i++){
				for(int j=0;j<=5;j++){
					for(int k=0;k<=10;k++){
						for(int s=0;s<=20;s++){
							int sum=(i*500)+(j*200)+(k*100)+(s*50);
							if(sum==1000){
								count++;
							}
						}
					}
				}
			}
			MessageBox.Show(count.ToString());
		}
		void Button3Click(object sender, EventArgs e)
		{
			rahimi fazel=new rahimi();
			fazel.func();
		}
		void Button4Click(object sender, EventArgs e)
		{
			Form2 fm=new Form2();
			fm.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			//rahimi rm=new rahimi();
			//rm.family();
			
			fazel fl=new fazel();
			//fl.family();
			fl.name_family();
		}
		void Button6Click(object sender, EventArgs e)
		{
			mth mt=new mth();
			MessageBox.Show(mt.fact(3).ToString());
		}
	}
}
