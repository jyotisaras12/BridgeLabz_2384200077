using System;
class Calculator{
	//method to calculate addition of two numbers
	public static int Add(int num1, int num2){
		return num1 + num2;
	}
	
	//method to calculate subtraction of two numbers
	public static int Subtract(int num1, int num2){
		return num1 - num2;
	}
	
	//method to calculate multiplication of two numbers
	public static int Multiply(int num1, int num2){
		return num1 * num2;
	}
	
	//method to calculate division of two numbers
	public static int Divide(int num1, int num2){
		return num1 / num2;
	}
	//method to take input from user
	public static int UserInput(){
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		return n;
	}
	
	//method to print the result
	public static void DisplayResult(int n){
		Console.Write("The result is: "+n);
	}
			
	//Main method
	static void Main(String[] args){
		//calling 'UserInput' method to take input from the user
		int n1 = UserInput();
		int n2 = UserInput();
		
		Console.Write("Enter the operator(+, -, *, /): ");
		char operation = (char)Console.Read();
		
		int answer = 0;
		switch(operation){
			case '+':
				answer = Add(n1, n2); break;
			case '-':
				answer = Subtract(n1, n2); break;
			case '*':
				answer = Multiply(n1, n2); break;
			case '/':
				answer = Divide(n1, n2); break;
			default:
				Console.WriteLine("Not a valid operator!");
				break;
		}
		
		DisplayResult(answer);
		
	}
}
