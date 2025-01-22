using System;
class DistanceInput{
	static void Main(String[] args){
		Console.Write("Enter distance in feet: ");
		double distFeet = Convert.ToDouble(Console.ReadLine()); //taking distance in feet as input from user
		double distYard = distFeet / 3;	//feet to yards conversion
		double distMiles = distYard / 1760;	//yard to miles conversion
		Console.WriteLine("The distance in feet is {0} while in yards is {1} and miles is {2}",distFeet,distYard,distMiles);
	}
}