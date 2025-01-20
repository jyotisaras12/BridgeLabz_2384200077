using System;
class Distance{
	static void Main(String[] args){
		Console.Write("Enter distance in kilometers: ");
		double km = Convert.ToDouble(Console.ReadLine()); //to take input from user
		double miles = km*0.621371;   //km to miles
		Console.WriteLine("The distance in miles is: "+miles);
		Console.ReadKey();
	}
}