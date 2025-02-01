using System;
class WindChill{
	//method to calculate the wind chill temperature 
	public double CalculateWindChill(double temperature, double windSpeed) {
		double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed,0.16);	//calculation of wind chill
		return windChill;	//returning the value
	}
	
	//Main method
	static void Main(string[] args){
		//taking temperature as input from user
		Console.Write("Enter temperature in Fehrenheit: ");	
		double temp = Convert.ToDouble(Console.ReadLine());	
		//taking wind speed as input from user
		Console.Write("Enter wind speed in mph: ");
		double speed = Convert.ToDouble(Console.ReadLine());
		
		//instantiating the 'WindChill' class
		WindChill wind = new WindChill();
		
		//printing the wind chill temperature
		Console.WriteLine("Wind chill is: "+wind.CalculateWindChill(temp,speed));
	}
}
