using System;
class Volume{
	static void Main(String[] args){
		Console.Write("Enter radius of cylinder: ");
		double radius = Convert.ToDouble(Console.ReadLine()); //to take input from user
		Console.Write("Enter height of cylinder: ");
		double height = Convert.ToDouble(Console.ReadLine());
		double volume = Math.PI*Math.Pow(radius,2)*height;   //volume of cylinder
		Console.WriteLine("The volume of the cylinder is: "+volume);
		Console.ReadKey();
	}
}