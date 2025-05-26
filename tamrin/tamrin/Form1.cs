/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/26/2025
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tamrin
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
			listBox1.Items.Add(textBox1.Text);
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
	}
}
