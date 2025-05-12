/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/12/2025
 * Time: 9:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace class_array
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
			check_number chk=new check_number();
			
			chk.aval_yek_ta_hezar(listBox1);
		}
		void Button2Click(object sender, EventArgs e)
		{
			check_number chk=new check_number();
			chk.yek_ta_hezar(listBox1);
		}
	}
}
