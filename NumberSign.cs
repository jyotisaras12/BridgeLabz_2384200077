using System;
class NumberSign{
	//method to check whether a number is positive, negative, or zero 
	public int NumberCheck(double number){
		if(number > 0) return 1;	//checking if number is positive;	
		else if (number < 0 ) return -1; //checking if number is negative
		else return 0;	//number is zero
	}
	
	//Main method
	static void Main(string[] args){
		//taking number as input from user
		Console.Write("Enter a number: ");	
		double num = Convert.ToDouble(Console.ReadLine());
			
		//instantiating the 'NumberSign' class
		NumberSign numCheck = new NumberSign();	
		
		//printing 1 for positive, -1 for negative and 0 for zero using 'NumberCheck' method
		Console.WriteLine(numCheck.NumberCheck(num));
	}
}		