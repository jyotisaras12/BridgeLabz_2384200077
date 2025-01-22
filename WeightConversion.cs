using System;
class WeightConversion{
	static void Main(String[] args){
		Console.Write("Enter weight in pounds: ");	
		double weight = Convert.ToDouble(Console.ReadLine());	//taking weight in pounds as input from user
		double weightKg = weight / 2.2;	//pounds to kg conversion
		Console.WriteLine("The weight of the person in pounds is {0} and in kg is {1}",weight,weightKg);
	}
}