using System;
class Bonus{
	static void Main(string[] args){
		Console.Write("Enter the years of service: ");	
		double yearOfService = Convert.ToDouble(Console.ReadLine());	//taking years of service as input from user
		Console.Write("Enter the salary: ");
		double salary = Convert.ToDouble(Console.ReadLine());	//taking salary as input from user
		double bonus = 0;	//initialising bonus with 0
		if(yearOfService > 5){	//checking if years of service are more than 5
			bonus = (5 * salary)/100;	//calculation of 5% bonus on salary
		}
		Console.WriteLine("Bonus amount is "+bonus);	//printing the bonus
	}
}
			