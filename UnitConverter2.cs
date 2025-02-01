using System;
class UnitConverter2{
    //method to convert yards to feet
    public static double ConvertYardsToFeet(double yards){
        double yards2feet = 3;	//yards to feet conversion
        return yards * yards2feet;
    }

    //method to convert feet to yards
    public static double ConvertFeetToYards(double feet){
        double feet2yards = 0.333333;	//feet to yards conversion
        return feet * feet2yards;
    }

    //method to convert meters to inches
    public static double ConvertMetersToInches(double meters){
        double meters2inches = 39.3701;	//meters to inches conversion
        return meters * meters2inches;
    }

    //method to convert inches to meters
    public static double ConvertInchesToMeters(double inches){
        double inches2meters = 0.0254;	//feet to meters conversion
        return inches * inches2meters;
    }
	
	//method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches){
        double inches2cm = 2.54;	//inches to centimeters conversion
        return inches * inches2cm;
    }
	
	//Main method
	static void Main(string[] args){
        //taking input from user
        //yards to feet
        Console.Write("Enter distance in yards: ");
        double yardsInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} yards is equal to {1} feet.",yardsInput,ConvertYardsToFeet(yardsInput));

        //feet to yards
        Console.Write("Enter distance in feet: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} feet is equal to {1} yards.", feetInput,ConvertFeetToYards(feetInput));

        //meters to inches
        Console.Write("Enter distance in meters: ");
        double mInput = Convert.ToDouble(Console.ReadLine());
       //printing the output
        Console.WriteLine("{0} meters is equal to {1} inches.",mInput,ConvertMetersToInches(mInput));

        //inches to meters
        Console.Write("Enter distance in inches: ");
        double inchesInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} feet is equal to {1} meters.",inchesInput,ConvertInchesToMeters(feetInput));
		
		//inches to centimeters
        Console.Write("Enter distance in inches: ");
        double inchInput = Convert.ToDouble(Console.ReadLine());
		//printing the output
        Console.WriteLine("{0} feet is equal to {1} meters.",inchInput,ConvertInchesToCentimeters(feetInput));
    }
}
