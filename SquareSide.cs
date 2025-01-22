using System;
class SquareSide{
	static void Main(String[] args){
		Console.Write("Enter perimeter of square: ");
		double perimeter = Convert.ToDouble(Console.ReadLine()); //taking perimeter of square as input from user
		double side = perimeter/4;	//calculation of length of the side
		Console.WriteLine("The length of the side is {0} whose perimeter is {1}",side,perimeter);
	}
}