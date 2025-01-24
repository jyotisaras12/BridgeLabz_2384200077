using System;
class FactorialFor{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		double fact = 1;	//fact variable to store factorial value
		if(num > 0){	//checking the number is natural number
			for(int i = 1; i <= num; i++){	//calculation of factorial using loop
				fact = fact * i;	
			}
			Console.WriteLine("Factorial is "+fact);	//printing the factorial
		}
		else{	//not a natural number
			Console.WriteLine("Not a natural number!");
		}	
	}
}
			