using System;
class TemperatureConverter{
	//method to convert Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }

    //method to convert Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
	
	//method to take input from user
	public static double UserInput(){
		Console.Write("Enter the temperature: ");
		double temp = Convert.ToDouble(Console.ReadLine());
		return temp;
	}
			
	//Main method
	static void Main(String[] args){
		//calling 'UserInput' method to take input from the user
		Console.WriteLine("Celsius to Fahrenheit");
		double tempC = UserInput();
		
		Console.WriteLine("Fahrenheit to Celsius");
		double tempF = UserInput();
		
		
		//printing the result using 'CelsiusToFahrenheit' and 'FahrenheitToCelsius' method
		Console.WriteLine("{0} Celsius is equal to {1} fahrenheit.",tempC,CelsiusToFahrenheit(tempC));
		Console.WriteLine("{0} fahrenheit is equal to {1} celsius.",tempF,FahrenheitToCelsius(tempF));
	}
}
