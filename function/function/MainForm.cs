/*
 * Created by SharpDevelop.
 * User: Abraham trojan
 * Date: 4/21/2025
 * Time: 7:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace function
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
		public void sayhello(int i){
			for(int j=0;j<i;j++){
				MessageBox.Show("hello");
			}
		}
		public bool is_zoj(int i){
			if(i%2==0){
				return true;
			}else{
				return false;
			}
		}
		public void check_txt_zoj(){
			int tst=int.Parse(textBox1.Text);
			if(is_zoj(tst)==true){
				MessageBox.Show("zoj");
			}else{
				MessageBox.Show("fard");
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			sayhello(3);
		}
		void Button2Click(object sender, EventArgs e)
		{
			sayhello(2);
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			int tst=int.Parse(textBox1.Text);
			if(is_zoj(tst)==true){
				MessageBox.Show("zoj");
			}else{
				MessageBox.Show("fard");
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			check_txt_zoj();
		}
		
		public int sigma(int numb){
			int sum=0;
			for(int i=numb;i>0;i--){
				sum+=i;
			}
			return sum;
		}
		
		public int ret_sigma(int numb){
			if(numb<1){
				return 0;
			}
			if(numb==1){
				return 1;
			}else{
				return numb+ret_sigma(numb-1);
			}
		}
		void Button5Click(object sender, EventArgs e)
		{
			int tst=int.Parse(textBox1.Text);
			int s=sigma(tst);
			MessageBox.Show(s.ToString());
		}
		void Button6Click(object sender, EventArgs e)
		{
			MessageBox.Show(ret_sigma(int.Parse(textBox1.Text)).ToString());
		}
	}
}
