using System;
class NumberSign{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		double num = Convert.ToDouble(Console.ReadLine());	//taking number as input from user
		if (num > 0){	//checking if number is positive
			Console.WriteLine("Positive");	
		}
		else if (num < 0 ) { //checking if number is negative
			Console.WriteLine("Negative");
		}
		else{	//number is zero
			Console.WriteLine("Zero");	
		}
	}
}		