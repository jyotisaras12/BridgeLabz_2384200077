using System;
class NoOfDigits{
	static void Main(String[] args){
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int n = num;	
		int noOfDigits = 0;	//initialising the noOfDigits counter with 0
		while(n != 0){
			int digit = n%10;	//for getting digits
			noOfDigits++;	//counter for no. of digits
			n = n/10;	
			}
		Console.WriteLine("The number of digits in {0} is {1}",num,noOfDigits);	//printing the output
	}
}
	
	
	
