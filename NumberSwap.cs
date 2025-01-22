using System;
class NumberSwap{
	static void Main(String[] args){
		Console.Write("Enter first number: ");
		double number1 = Convert.ToDouble(Console.ReadLine()); //taking first number as input from user
		Console.Write("Enter second number: ");
		double number2 = Convert.ToDouble(Console.ReadLine());	//taking second number as input from user
		double temp = number1 + number2;	//taking a variable temp to swap the numbers
		number2 = temp - number2;	
		number1 = temp - number2;
		Console.WriteLine("The swapped numbers are {0} and {1}",number1,number2);
	}
}