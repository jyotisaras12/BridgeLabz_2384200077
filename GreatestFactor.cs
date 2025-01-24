using System;
class GreatestFactor{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
			for(int i = num-1; i >= 1; i--){	//iterating from num-1 to 1 to find greatest factor
				if(num % i == 0){	//checking for factor
					Console.WriteLine(i);	//printing the greatest factor
					break;
				}
			}
	}
}
			