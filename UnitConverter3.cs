using System;
class UnitConverter3{
    //method to convert fahrenheit to celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit) {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;	//fahrenheit to celsius conversion
        return fahrenheit2celsius;
    }

    //method to convert celsius to fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius){
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;	//celsius to fahrenheit conversion
        return celsius2fahrenheit;
    }

    //method to convert pounds to kilograms 
    public static double ConvertPoundsToKilograms(double pounds){
        double pounds2kilograms = 0.453592;	//pounds to kilograms conversion
        return pounds * pounds2kilograms;
    }

    //method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms){
        double kilograms2pounds = 2.20462; 	//kilograms to pounds conversion
        return kilograms * kilograms2pounds;
    }
	
	//method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons){
        double gallons2liters = 3.78541;	//gallons to liters conversion
        return gallons * gallons2liters;
    }
	
	//method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters){
        double liters2gallons = 0.264172;	//liters to gallons conversion
        return liters * liters2gallons;
    }
	
	//Main method
	static void Main(string[] args){
        //taking input from user
        //fahrenheit to celsius
        Console.Write("Enter temperature in fahrenheit: ");
        double fahrenInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} fahrenheit is equal to {1} celsius.",fahrenInput,ConvertFahrenheitToCelsius(fahrenInput));

        //celsius to fahrenheit
        Console.Write("Enter temperature in celsius: ");
        double celsiusInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} celsius is equal to {1} fahrenheit.",celsiusInput,ConvertCelsiusToFahrenheit(celsiusInput));

        //pounds to kilograms
        Console.Write("Enter weight in pounds: ");
        double poundsInput = Convert.ToDouble(Console.ReadLine());
       //printing the output
        Console.WriteLine("{0} pounds is equal to {1} kilograms.",poundsInput,ConvertPoundsToKilograms(poundsInput));
	
		//kilograms to pounds
        Console.Write("Enter weight in kilograms: ");
        double kgInput = Convert.ToDouble(Console.ReadLine());
       //printing the output
        Console.WriteLine("{0} kilograms is equal to {1} pounds.",kgInput,ConvertKilogramsToPounds(kgInput));
		
        //gallons to liters
        Console.Write("Enter in gallons: ");
        double gallonsInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} gallons is equal to {1} liters.",gallonsInput,ConvertGallonsToLiters(gallonsInput));
		
		//liters to gallons
        Console.Write("Enter in liters: ");
        double litersInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} liters is equal to {1} gallons.",litersInput,ConvertLitersToGallons(litersInput));
    }
}
