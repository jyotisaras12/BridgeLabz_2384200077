using System;
class NaturalSum{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int sum = 0;	//variable to store sum of natural numbers
		if(num > 0){	//checking the number is a natural number 
			sum = (num * (num + 1))/2;	//calculation of sum of n natural numbers
			Console.WriteLine("The sum of {0} natural numbers is {1}",num,sum);	//printing the sum
		}
		else{
			Console.WriteLine("The number {0} is not a natural number",num);
		}

	}
}
			