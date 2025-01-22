using System;
class Height{
	static void Main(String[] args){
		Console.Write("Enter your height in cm: ");	
		double heightCm = Convert.ToDouble(Console.ReadLine()); //taking height in cm as input from user
		double heightInch = heightCm / 2.54;	//cm to inch conversion of height
		double heightFeet = heightInch / 12;	//inch to feet conversion of height
		Console.WriteLine("Your Height in cm is {0} while in feet is {1} and inches is {2}",heightCm,heightFeet,heightInch);
	}
}