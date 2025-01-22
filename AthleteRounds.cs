using System;
class AthleteRounds{
	static void Main(String[] args){
		Console.Write("Enter side 1 of triangle in m: ");
		double side1 = Convert.ToDouble(Console.ReadLine()); //taking side 1 of triangle as input from user
		Console.Write("Enter side 2 of triangle in m: ");
		double side2 = Convert.ToDouble(Console.ReadLine());	//taking side 2 of triangle as input from user
		Console.Write("Enter side 3 of triangle in m: ");
		double side3 = Convert.ToDouble(Console.ReadLine()); //taking side 3 of triangle as input from user
		double distance = 5000;	//given distance is 5 km(converted in m)
		double perimeter = side1 + side2 + side3;	//calculation of perimeter of triangle
		int rounds = (int)(distance / perimeter);	//calculation of total no. of rounds
		Console.WriteLine("The total number of rounds the athlete will run is {0} to complete 5 km",rounds);
	}
}