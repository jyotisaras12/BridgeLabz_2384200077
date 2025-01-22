using System;
class Calculator{
	static void Main(String[] args){
		Console.Write("Enter first number: ");
		double num1 = Convert.ToDouble(Console.ReadLine()); //taking first number as input from user
		Console.Write("Enter second number: ");
		double num2 = Convert.ToDouble(Console.ReadLine());	//taking second number as input from user
		double addition = num1 + num2;	//addition of numbers
		double sub = num1 - num2;	//subtraction of numbers
		double multiply = num1 * num2;	//multiplication of numbers
		double divide = num1 / num2;	//division of numbers
		Console.WriteLine("The addition, subtraction, multiplication and division value of numbers {0} and {1} is {2}, {3}, {4} and {5}",num1,num2,addition,sub,multiply,divide);
	}
}