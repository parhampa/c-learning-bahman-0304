/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/19/2025
 * Time: 8:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace extended_class_name
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
			numeral nml=new numeral();
			string txt=textBox1.Text;
			int tst=int.Parse(txt);
			int cnt=nml.bakhsh_pazir(tst);
			MessageBox.Show(cnt.ToString());
		}
		void Button2Click(object sender, EventArgs e)
		{
			numeral2 nml2=new numeral2();
			
			string txt=textBox1.Text;
			int tst=int.Parse(txt);
			bool cnt=nml2.is_aval(tst);
			MessageBox.Show(cnt.ToString());
		}
		void Button3Click(object sender, EventArgs e)
		{
			numeral3 nml3=new numeral3();
			
			textBox2.Text=nml3.aval_1_to_100();
		}
	}
}
