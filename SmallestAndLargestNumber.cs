using System;
class SmallestAndLargestNumber{
	//method to find the smallest and the largest number
	public static int[] FindSmallestAndLargest(int number1, int number2, int number3){
		int smallest = (number1 < number2) ? 
               ((number1 < number3) ? number1 : number3) : 
               ((number2 < number3) ? number2 : number3);
		int largest = (number1 > number2) ? 
               ((number1 > number3) ? number1 : number3) : 
               ((number2 > number3) ? number2 : number3);
		return new int[]{smallest, largest};	//returning the result as an array
	}
		
	//Main method
	static void Main(string[] args){
		//taking numbers as input from user
		Console.Write("Enter first number: ");	
		int num1 = Convert.ToInt32(Console.ReadLine());	
		Console.Write("Enter second number: ");	
		int num2 = Convert.ToInt32(Console.ReadLine());	
		Console.Write("Enter third number: ");	
		int num3 = Convert.ToInt32(Console.ReadLine());	
		
		//calling the 'FindSmallestAndLargest' method to find the smallest and largest numbers
        int[] result = FindSmallestAndLargest(num1,num2,num3);
		
		//printing the smallest and the largest numbers using 'FindSmallestAndLargest' method
		Console.WriteLine("Smallest number is: "+result[0]);
		Console.WriteLine("Largest number is: "+result[1]);

	}
}
			