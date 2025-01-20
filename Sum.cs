using System;
class Sum{
	static void Main(String[] args){
		Console.Write("Enter first number: ");
		double num1 = Convert.ToDouble(Console.ReadLine()); //to take input from user
		Console.Write("Enter second number: ");
		double num2 = Convert.ToDouble(Console.ReadLine());
		double sum = num1 + num2;  //sum
		Console.WriteLine("The sum of {0} and {1} is: {2}",num1,num2,sum);
		Console.ReadKey();
	}
}