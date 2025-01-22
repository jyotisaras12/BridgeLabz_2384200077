using System;
class DistanceToMilesInput{
	static void Main(String[] args){
		Console.Write("Enter distance in km: ");	
		double distKm = Convert.ToDouble(Console.ReadLine());	//taking distance in km as input from user
		double distMiles = distKm / 1.609;	//km to miles conversion
		Console.WriteLine("The total distance is {0} miles for the given {1} km",distMiles,distKm);
	}
}