using System;
class Fibonacci{
	//method to calculate fibonacci sequence
	public static int FibonacciSequence(int num){
		if(num == 1) return 0;
		else if(num == 2) return 1;
		else return FibonacciSequence(num-1)+FibonacciSequence(num-2);
	}
	
	//method to take input from user
	public static int UserInput(){
		Console.Write("Enter number of terms of fibonacci sequence: ");
		int n = Convert.ToInt32(Console.ReadLine());
		return n;
	}
	
	//method to print the fibonacci sequence
	public static void DisplayFibonacciSequence(int n){
		for(int i = 1; i<=n ; i++){
			Console.Write(FibonacciSequence(i)+ " ");
		}
	}
			
	//Main method
	static void Main(String[] args){
		//calling 'UserInput' method to take input from the user
		int number = UserInput();
		
		//calling 'DisplayFibonacciSequence()' method to print the sequence
		DisplayFibonacciSequence(number);
	}
}
