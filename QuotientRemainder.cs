using System;
class QuotientRemainder{
	static void Main(string[] args){
		Console.Write("Enter first number: ");
		double num1 = Convert.ToDouble(Console.ReadLine()); //taking first number as input from user
		Console.Write("Enter second number: ");
		double num2 = Convert.ToDouble(Console.ReadLine()); //taking second number as input from user
		double quot = num1 / num2;	//calculation of quotient
		double rem = num1 % num2;	//calculation of modulus
		Console.WriteLine("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}",quot,rem,num1,num2);
	}
}