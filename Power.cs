using System;
class Power{
	static void Main(String[] args){
		Console.Write("Enter base: ");
		double base_num = Convert.ToDouble(Console.ReadLine()); //to take input from user
		Console.Write("Enter exponent: ");
		double exponent = Convert.ToDouble(Console.ReadLine());
		double result = Math.Pow(base_num,exponent);   //power
		Console.WriteLine("The base raised to the exponent is: "+result);
		Console.ReadKey();
	}
}