using System;
class Sum0{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		double num = Convert.ToDouble(Console.ReadLine());	//taking number as input from user
		double sum = 0;	//variable sum to store the sum of numbers entered by user
		while(true){
			if (num < 0 || num == 0){	//checking for negative number or zero entered by user
				break;
			}
			else{	
				sum = sum + num;	//adding number to sum
				Console.Write("Enter a number again: ");
				num = Convert.ToDouble(Console.ReadLine());
			}
		}
		Console.WriteLine("The total sum is "+sum);	//printing the sum
	}
}
			