using System;
class EarthVolume{
	static void Main(string[] args){
		double radiusKm = 6378;	//given radius of earth in km
		double volKm = (4*Math.PI*Math.Pow(radiusKm,3))/3;	//calculation of volume in cubic km
		double volMiles = volKm/Math.Pow(1.6,3);	//conversion of volume from cubic km to cubic miles
		Console.WriteLine("The volume of Earth in cubic kilometer is {0} and cubic miles is {1}",volKm,volMiles);
	}
}