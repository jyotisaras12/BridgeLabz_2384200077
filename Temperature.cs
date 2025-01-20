using System;
class Temperature{
	static void Main(String[] args){
		Console.Write("Enter temperature in Celsius: ");
		double celsius = Convert.ToDouble(Console.ReadLine()); //to take input from user
		double fahrenheit = (9.0/5.0)*celsius+32;   //celsius to fahrenheit
		Console.WriteLine("{0} C is equal to {1} F",celsius,fahrenheit);
		Console.ReadKey();
	}
}