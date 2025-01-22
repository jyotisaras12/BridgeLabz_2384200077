using System;
class AreaTriangle{
	static void Main(String[] args){
		Console.Write("Enter height of triangle in inches: ");
		double heightInch = Convert.ToDouble(Console.ReadLine()); //taking height in inch as input from user
		Console.Write("Enter base of triangle in inches: ");
		double baseInch = Convert.ToDouble(Console.ReadLine());	//taking base in inch as input from user
		double areaInch = (baseInch * heightInch) / 2;	//calculation of area in square inch
		double areaCm = areaInch * Math.Pow(2.54,2);	//square inch to square cm conversion
		Console.WriteLine("Area of triangle in square inch is {0} and square cm is {1}",areaInch,areaCm);
	}
}