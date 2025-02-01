using System;
class SimpleInterest{
	//method for simple interest calculation
	public double Interest(double principal, double rate, double time){	
		double interest = (principal*rate*time)/100;	//calculation of simple interest
		return interest;	//returning the interest value
	}
	//Main method
	static void Main(String[] args){
		//taking principal, rate of interest and time as input from user
		Console.Write("Enter Principal amount: ");
		double p = Convert.ToDouble(Console.ReadLine()); 
		Console.Write("Enter rate of interest: ");
		double r = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter time period: ");
		double t = Convert.ToDouble(Console.ReadLine());
		
		//instantiating the 'SimpleInterest' class
		SimpleInterest si = new SimpleInterest();	
		
		//printing the simple interest using 'Interest' method
		Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3} years.",si.Interest(p,r,t),p,r,t);
	}
}