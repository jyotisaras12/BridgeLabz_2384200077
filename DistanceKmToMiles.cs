using System;
class DistanceKmToMiles{
	static void Main(String[] args){
		double distKm = 10.8;	//given distance in km
		double distMiles = distKm / 1.609;		//km to miles conversion
		Console.WriteLine("The distance {0} km in miles is {1}",distKm,distMiles);
	}
}