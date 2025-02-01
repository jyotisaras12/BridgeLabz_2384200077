using System;
class NaturalNoSum{
	//method to find the sum of n natural numbers using loop 
	public int NaturalSum(int number){
		int sum = 0;	//variable to store sum of natural numbers
		int i = 1;
		while(i <= number){	//calculation of sum of n natural numbers using while loop
				sum += i;	//adding i to sum
				i++;	//incrementing the value of i by 1
			}
		return sum;	//returning the sum
	}
	
	//Main method
	static void Main(string[] args){
		//taking number as input from user
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	
		
		//instantiating the 'NaturalNoSum' class
		NaturalNoSum naturalSum = new NaturalNoSum();
		
		//printing the sum of n natural numbers using 'NaturalSum' method
		Console.WriteLine(naturalSum.NaturalSum(num));
	}
}
			