using System;
class SimpleInterest{
	static void Main(String[] args){
		Console.Write("Enter Principal amount: ");
		double principal = Convert.ToDouble(Console.ReadLine()); //to take input from user
		Console.Write("Enter rate of interest: ");
		double rate = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter time period: ");
		double time = Convert.ToDouble(Console.ReadLine());
		double interest = (principal*rate*time)/100;   //simple interest
		Console.WriteLine("The simple interest is: "+interest);
		Console.ReadKey();
	}
}