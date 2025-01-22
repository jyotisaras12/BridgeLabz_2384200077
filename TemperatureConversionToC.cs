using System;
class TemperatureConversionToC{
	static void Main(String[] args){
		Console.Write("Enter temperature in Fahrenheit: ");
		double fahrenheit = Convert.ToDouble(Console.ReadLine()); //taking temperature in fahrenheit as input from user
		double celsius = ((fahrenheit - 32) * 5)/9.0;  //fahrenheit to celsius conversion
		Console.WriteLine("The {0} Fahrenheit is {1} Celsius",fahrenheit,celsius);
	}
}