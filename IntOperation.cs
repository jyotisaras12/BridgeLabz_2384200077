using System;
class IntOperation{
	static void Main(string[] args){
		Console.Write("Enter value of a: ");
		int a = Convert.ToInt32(Console.ReadLine()); //taking value of a from user
		Console.Write("Enter value of b: ");
		int b = Convert.ToInt32(Console.ReadLine()); //taking value of b from user
		Console.Write("Enter value of c: ");
		int c = Convert.ToInt32(Console.ReadLine()); //taking value of c from user
		int oper1 =  a + b * c;	//int operation 1
		int oper2 = a * b + c;	//int operation 2
		int oper3 = c + a / b;	//int operation 3
		int oper4 = a % b + c;	//int operation 4
		Console.WriteLine("The results of Int Operations are {0}, {1}, {2} and {3}",oper1,oper2,oper3,oper4);
	}
}