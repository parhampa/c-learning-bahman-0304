/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/19/2025
 * Time: 8:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extended_class_name
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class numeral
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
	}
	
	public class numeral2 : numeral{
		public bool is_aval(int numb){
			if(this.bakhsh_pazir(numb)<=2)
			{
				return true;
			}else{
				return false;
			}
		}
	}
	
	public class numeral3:numeral2{
		public string aval_1_to_100(){
			string tst="";
			for(int i=1;i<=1000;i++){
				if(this.is_aval(i)==true){
					if(tst==""){
						tst=i.ToString();
					}else{
						tst=tst+","+i.ToString();
					}
				}
			}
			return tst;
		}
	}
}
