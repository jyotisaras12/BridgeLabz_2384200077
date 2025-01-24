using System;
class Power{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		Console.Write("Enter the power: ");	
		int power = Convert.ToInt32(Console.ReadLine());	//taking power for number as input from user
		double result = 1;
		for(int i = 1; i <= power; i++){	//iterating from 1 to power
			result *= num;	//calculation of result
		}
		Console.WriteLine("{0} raised to power {1} is {2}",num,power,result);	//printing the result
	}
}
			