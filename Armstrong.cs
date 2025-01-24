using System;
class Armstrong{
	static void Main(String[] args){
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int n = num;	
		int sum = 0;
		int length = num.ToString().Length;	//number of digits of number
		while(n > 0){
			int digit = n%10;	//for getting digits
			sum += (int)Math.Pow(digit,length);
			n = n/10;	
			}
		if(sum==num) Console.Write("{0} is a Armstrong number",num);	//printing the output
		else Console.Write("{0} is a Non-Armstrong number",num);
	}
}
	
	
	
