using System;
class Area{
	static void Main(String[] args){
		Console.Write("Enter radius of circle: ");
		double radius = Convert.ToDouble(Console.ReadLine()); //to take input from user
		double area = Math.PI*Math.Pow(radius,2);   //area of circle
		Console.WriteLine("The area of the circle is: "+area);
		Console.ReadKey();
	}
}