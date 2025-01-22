using System;
class TemperatureConversion{
	static void Main(String[] args){
		Console.Write("Enter temperature in Celsius: ");
		double celsius = Convert.ToDouble(Console.ReadLine()); //taking temperature in celsius as input from user
		double fahrenheit = (9.0/5.0)*celsius+32;   //celsius to fahrenheit conversion
		Console.WriteLine("The {0} Celsius is {1} Fahrenheit",celsius,fahrenheit);
	}
}