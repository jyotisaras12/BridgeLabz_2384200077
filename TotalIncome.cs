using System;
class TotalIncome{
	static void Main(string[] args){
		Console.Write("Enter salary: ");
		double salary = Convert.ToDouble(Console.ReadLine()); //taking salary of a person as input from user
		Console.Write("Enter bonus: ");
		double bonus = Convert.ToDouble(Console.ReadLine()); //taking bonus as input from user
		double totalIncome = salary + bonus;	//calculation of total income(salary+bonus)
		Console.WriteLine("The salary is INR {0} and bonus is INR {1}. Hence Total Income is INR {2}",salary,bonus,totalIncome);
	}
}