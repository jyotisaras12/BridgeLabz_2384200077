using System;
class UnitConverter1{
    //method to convert kilometers to miles
    public static double ConvertKmToMiles(double km){
        double km2miles = 0.621371;	//kilometers to miles conversion
        return km * km2miles;
    }

    //method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles){
        double miles2km = 1.60934;	//miles to kilometers conversion
        return miles * miles2km;
    }

    //method to convert meters to feet
    public static double ConvertMetersToFeet(double meters){
        double meters2feet = 3.28084;	//meters to feet conversion
        return meters * meters2feet;
    }

    //method to convert feet to meters
    public static double ConvertFeetToMeters(double feet){
        double feet2meters = 0.3048;	//feet to meters conversion
        return feet * feet2meters;
    }
	
	//Main method
	static void Main(string[] args){
        //taking input from user
        //kilometers to miles
        Console.Write("Enter distance in kilometers: ");
        double kmInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} kilometers is equal to {1} miles.",kmInput,ConvertKmToMiles(kmInput));

        //miles to kilometers
        Console.Write("Enter distance in miles: ");
        double milesInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} miles is equal to {1},kilometers.", milesInput, ConvertMilesToKm(milesInput));

        //meters to feet
        Console.Write("Enter distance in meters: ");
        double mInput = Convert.ToDouble(Console.ReadLine());
       //printing the output
        Console.WriteLine("{0} meters is equal to {1} feet.",mInput,ConvertMetersToFeet(mInput));

        //feet to meters
        Console.Write("Enter distance in feet: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} feet is equal to {1} meters.",feetInput,ConvertFeetToMeters(feetInput));
    }
}
