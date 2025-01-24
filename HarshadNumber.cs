using System;
class HarshadNumber{
	static void Main(String[] args){
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int n = num;	
		int sum = 0;	//initialising the sum of digits with 0
		while(n != 0){
			int digit = n%10;	//for getting digits
			sum += digit;	//calculation of sum of digits
			n = n/10;	
		}
		if(num % sum == 0) Console.WriteLine("{0} is a Harshad Number",num);	//printing the output
		else Console.WriteLine("{0} is not a Harshad Number",num);
	}
}
	
	
	
