using System;
class NaturalNoSumForLoop{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int sum = 0;	//variable to store the sum of natural numbers
		if(num > 0){
			int sumFormula = (num * (num + 1))/2;	//calculation of sum of n natural numbers using formula
			for(int i = 1; i <= num; i++){	//calculation of sum of n natural numbers using for loop
				sum = sum + i;
			}
			Console.WriteLine("Is the sum using while loop and formula same? "+(sum==sumFormula));	//printing whether sum by both the methods is equal
			Console.WriteLine("Sum is: "+sum);	//printing the sum
		}
		else{
			Console.WriteLine("Not a natural number");
		}
	}
}
			