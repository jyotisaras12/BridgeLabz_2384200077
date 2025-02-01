using System;
class Factorial{
	//method to calculate factorial of a number
	public static int CalculateFactorial(int num){
		if(num == 0 || num == 1) return 1;
		else return num*CalculateFactorial(num-1);
	}
	
	//method to take input from user
	public static int UserInput(){
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		return n;
	}
	
	//method to print the factorial
	public static void DisplayFactorial(int n){
		Console.Write("The factorial is: "+n);
	}
			
	//Main method
	static void Main(String[] args){
		//calling 'UserInput' method to take input from the user
		int num = UserInput();
		
		//printing the result using 'CalculateFactorial()' and 'DisplayFactorial()' method
		int factorial = CalculateFactorial(num);
		DisplayFactorial(factorial);
	}
}
