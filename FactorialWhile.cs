using System;
class FactorialWhile{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		double fact = 1;	//fact variable to store factorial value
		if(num > 0){	//checking the number is natural number
			while(num > 1){	//calculation of factorial using while loop
				fact = fact * num;	
				num--;	//decrementing num by 1
			}
			Console.WriteLine("Factorial is "+fact);	//printing the factorial
		}
		else{	//not a natural number
			Console.WriteLine("Not a natural number!");
		}
		
	}
}
			