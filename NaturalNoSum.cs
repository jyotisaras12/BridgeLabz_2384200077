using System;
class NaturalNoSum{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int sum = 0;	//variable to store the sum of natural numbers
		int sumFormula = 0;
		if (num > 0){	//checking if number is natural number
			sumFormula = (num * (num + 1))/2;	//calculation of sum of n natural numbers using formula
			while(num >= 1){	//calculation of sum of n natural numbers using loop
				sum = sum + num;	//adding num to sum
				num = num - 1;	//decrementing the value of num by 1
			}
			Console.WriteLine("Is the sum using while loop and formula same? "+(sum==sumFormula));	//printing whether sum by both the methods is equal
			Console.WriteLine("Sum is: "+sum);	//printing the sum
		}
		else{
			Console.WriteLine("Not a natural number");
		}
	}
}
			