using System;
class MaximumNumber{
	//method to find the maximum of three numbers
	public static int FindMaximumNumber(int number1, int number2, int number3){
		//using ternary operator to find maximum number
		int maximum = (number1 > number2) ? 
               ((number1 > number3) ? number1 : number3) : 
               ((number2 > number3) ? number2 : number3);
		return maximum;	//returning the maximum number
	}
	
	//method to take input from user
	public static int UserInput(){
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		return n;
	}
	
	//method to display the maximum number
	public static void DisplayMaximumNumber(int n){
		Console.WriteLine("The maximum number is: "+n);
	}
		
	//Main method
	static void Main(string[] args){
		//calling 'UserInput()' method to take input from user
		int num1 = UserInput();	
		int num2 = UserInput();
		int num3 = UserInput();
		
		
		//calling the 'FindMaximumNumber()' and 'DisplayMaximumNumber()' method to print the output
		int max = FindMaximumNumber(num1, num2, num3);
		DisplayMaximumNumber(max);
	}
}
			