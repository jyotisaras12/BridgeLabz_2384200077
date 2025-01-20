using System;
class Perimeter{
	static void Main(String[] args){
		Console.Write("Enter length of rectangle: ");
		double length = Convert.ToDouble(Console.ReadLine()); //to take input from user
		Console.Write("Enter width of rectangle: ");
		double width = Convert.ToDouble(Console.ReadLine());
		double perimeter = 2*(length+width);   //perimeter of rectangle
		Console.WriteLine("The perimeter of the rectangle is: "+perimeter);
		Console.ReadKey();
	}
}