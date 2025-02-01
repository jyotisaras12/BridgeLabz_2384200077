using System;
class AthleteRounds{
	//method for calculation of the number of rounds user needs to do to complete 5km run
	public int NoOfRounds(double distance, double perimeter){
		int rounds = (int)(distance / perimeter);	//calculation of total no. of rounds
		return rounds;	//returning the no. of rounds
	}
		
	//Main method
	static void Main(String[] args){
		//taking length of sides of triangle(in m) as input from user
		Console.Write("Enter side 1 of triangle in m: ");
		double side1 = Convert.ToDouble(Console.ReadLine()); //length of side 1
		Console.Write("Enter side 2 of triangle in m: ");
		double side2 = Convert.ToDouble(Console.ReadLine());	//length of side 1
		Console.Write("Enter side 3 of triangle in m: ");
		double side3 = Convert.ToDouble(Console.ReadLine()); //length of side 1
		
		double dist = 5000;	//given distance is 5 km(converted in m)
		double peri = side1 + side2 + side3;	//calculation of perimeter of triangle
		
		//instantiating the 'AthleteRounds' class
		AthleteRounds rounds = new AthleteRounds();	
		
		//printing the number of rounds user needs to do to complete 5km run using 'NoOfRounds' method
		Console.WriteLine("The total number of rounds the athlete will run is {0} to complete 5 km",rounds.NoOfRounds(dist,peri));
	}
}