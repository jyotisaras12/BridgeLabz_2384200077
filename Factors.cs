using System;
class Factors{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
			for(int i = 1; i <= num; i++){	//iterating from 1 to num to check factors
				if(num % i == 0){	//checking for factor
					Console.WriteLine(i);	//printing the factor
					continue;
				}
			}
	}
}
			