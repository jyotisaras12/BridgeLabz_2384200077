using System;
class PositiveNegative{
	//method to check positive and negative
	public static bool isPositive(int number){
		return (number>=0);	//returning true if positive
	}
	
	//method to check even and odd
	public static bool isEven(int number){
		return (number%2==0);	//returning true if even
	}
	
	//method to compare elements
	public static int Compare(int a, int b){
		if(a > b) return 1;
		else if(a < b) return -1;
		else return 0;
	}
		
	//Main method
	static void Main(string[] args){
		//declaring 'numbers' array of size 5
		int[] numbers = new int[5];
		
		//taking numbers as input from user
		for(int i = 0; i < 5; i++){
			Console.Write("Enter number {0}: ",i+1);
			numbers[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		//printing the output using 'isPositive' and 'isEven' methods
		foreach(int num in numbers){
			if(isPositive(num)){	//checking positive
				if(isEven(num)) Console.WriteLine("{0} is positive and even.",num);	//checking even
				else Console.WriteLine("{0} is positive and odd.",num);	//checking odd
			}
			else Console.WriteLine("{0} is negative.",num);	//negative
		}
		//comparing first and last elements of array using 'Compare' method
		int compare = Compare(numbers[0],numbers[4]);
		if(compare==1) Console.WriteLine("{0} is greater than {1}",numbers[0],numbers[4]);
		else if(compare==-1) Console.WriteLine("{0} is smaller than {1}",numbers[0],numbers[4]);
		else Console.WriteLine("{0} is equal to {1}",numbers[0],numbers[4]);
	}
}