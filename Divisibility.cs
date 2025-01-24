using System;
class Divisibility{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		double num = Convert.ToDouble(Console.ReadLine());	//taking number as input from user
		Console.WriteLine("Is the number {0} divisible by 5? {1}",num,(num%5==0));	//checking if number is divisible by 5 and printing the result
	}
}
