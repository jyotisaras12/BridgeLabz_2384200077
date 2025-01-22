using System;
class SimpleInterest{
	static void Main(String[] args){
		Console.Write("Enter Principal amount: ");
		double principal = Convert.ToDouble(Console.ReadLine()); //taking principle amount as input from user
		Console.Write("Enter rate of interest: ");
		double rate = Convert.ToDouble(Console.ReadLine());	//taking interest rate as input from user
		Console.Write("Enter time period: ");
		double time = Convert.ToDouble(Console.ReadLine());	//taking time period as input from user
		double interest = (principal*rate*time)/100;   //calculation of simple interest
		Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3}",interest,principal,rate,time);
	}
}