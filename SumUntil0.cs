using System;
class SumUntil0{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		double num = Convert.ToDouble(Console.ReadLine());	//taking number as input from user
		double sum = 0;	//variable sum to store the sum of numbers entered by user
		while(num != 0){	//check until 0 is entered by user
			sum = sum + num;	//adding number to sum
			Console.Write("Enter a number again: ");	//taking number as input again from user when 0 is not entered
			num = Convert.ToDouble(Console.ReadLine());
		}
		Console.WriteLine("The total sum is "+sum);	//printing the sum
	}
}