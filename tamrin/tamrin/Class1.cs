/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/26/2025
 * Time: 8:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
namespace tamrin
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class rahimi
	{
		public void func(){
			MessageBox.Show("salam");
		}
		public void family(){
			MessageBox.Show("my family is rahimi");
		}
	}
	
	public class fazel:rahimi{
		public void name_family(){
			MessageBox.Show("my name and family is fazel rahimi");
		}
	}
	
	public class mth{
		public int fact(int a){
			if(a>1){
			return a*fact(a-1);
			}else{
				return 1;
			}
		}
	}
	
}
