using System;
class LargestNumber{
	static void Main(string[] args){
		Console.Write("Enter first number: ");	
		double num1 = Convert.ToDouble(Console.ReadLine());	//taking first number as input from user
		Console.Write("Enter second number: ");	
		double num2 = Convert.ToDouble(Console.ReadLine());	//taking second number as input from user
		Console.Write("Enter third number: ");	
		double num3 = Convert.ToDouble(Console.ReadLine());	//taking third number as input from user
		Console.WriteLine("Is the first number the largest? "+ (num1>num2 && num1>num3));	//checking if first number is the largest and printing the result
		Console.WriteLine("Is the second number the largest? "+ (num2>num1 && num2>num3));	//checking if second number is the largest and printing the result
		Console.WriteLine("Is the third number the largest? "+ (num3>num1 && num3>num2));	//checking if third number is the largest and printing the result
	}
}
			