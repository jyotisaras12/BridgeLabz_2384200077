using System;
class Calculator{
    static void Main(string[] args){
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());	//taking first number as input from user
        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());	//taking second number as input from user
		Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();	//taking operator as input from user
        switch (op)	//performing operations based on switch case
        {
            case "+":	//addition
                Console.WriteLine("Result: "+(first + second));
                break;
            case "-":	//subtraction
                Console.WriteLine("Result: "+(first - second));
                break;
            case "*":	//multiplication
                Console.WriteLine("Result: "+(first * second));
                break;
            case "/":	//division
                if (second != 0) Console.WriteLine("Result: "+(first / second));	//ensuring denominator is non-zero
                else Console.WriteLine("Division by zero is not possible");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
