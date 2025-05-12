/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/12/2025
 * Time: 9:45 AM
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
	/// Description of Class1.
	/// </summary>
	public class check_number
	{
		public int bakhsh_pazir(int numb){
			int count=0;
			for(int i=1;i<=numb;i++){
				if(numb%i==0){
					count++;
				}
			}
			return count;
		}
		
		public bool is_aval(int numb){
			if(this.bakhsh_pazir(numb)<=2){
				return true;
			}else{
				return false;
			}
		}
		
		public void aval_yek_ta_hezar(ListBox ls){
			for(int i=1;i<=1000;i++){
				if(is_aval(i)==true){
				ls.Items.Add(i.ToString());
				}
			}
		}
		
		public void yek_ta_hezar(ListBox ls){
			for(int i=1;i<=1000;i++){
				string aval=" is not aval";
				if(is_aval(i)==true){
					aval=" is aval";
				}
				ls.Items.Add("number is:"+i+" & "+ aval+" & bakhsh pazir: "+bakhsh_pazir(i));
			}
		}
	}
}
