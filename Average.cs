using System;
class Average{
	static void Main(String[] args){
		Console.Write("Enter first number: ");
		double num1 = Convert.ToDouble(Console.ReadLine()); //to take input from user
		Console.Write("Enter second number: ");
		double num2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter third number: ");
		double num3 = Convert.ToDouble(Console.ReadLine());
		double avg = (num1 + num2 + num3)/3;   //average
		Console.WriteLine("The average of {0},{1} and {2} is: {3}",num1,num2,num3,avg);
		Console.ReadKey();
	}
}