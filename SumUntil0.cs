using System;
class SumUntil0{
	static void Main(string[] args){
		//creating array 'numbers' of size 10
		double[] numbers = new double[10];
		double sum = 0.0;	//variable sum to store the sum of numbers 
		int index = 0;	//variable index to count index of the array
		while(true){
			Console.Write("Enter a number: ");	
			double num = Convert.ToDouble(Console.ReadLine());	//taking number as input from user
			if (num <= 0 || index >= 10) {	//checking if index>= size of array, and number is negative or zero
				break;
			}
				
			numbers[index] = num;	//assigning values in the array
			index++;	//index counter
		}
		Console.WriteLine("The numbers entered are: ");
		foreach(double n in numbers){	//to display the numbers in the array
			Console.WriteLine(n);
			sum += n;	//calculation of sum of numbers
		}	
		Console.WriteLine("The total sum is "+sum);	//printing the sum
	}
}
			