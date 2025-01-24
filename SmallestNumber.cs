using System;
class SmallestNumber{
	static void Main(string[] args){
		Console.Write("Enter first number: ");	
		double num1 = Convert.ToDouble(Console.ReadLine());	//taking first number as input from user
		Console.Write("Enter second number: ");	
		double num2 = Convert.ToDouble(Console.ReadLine());	//taking second number as input from user
		Console.Write("Enter third number: ");	
		double num3 = Convert.ToDouble(Console.ReadLine());	//taking third number as input from user
		Console.WriteLine("Is the first number the smallest? "+ (num1<num2 && num1<num3));	//checking if first number is the smallest and printing the result
	}
}
			