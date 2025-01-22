using System;
class DoubleOpt{
	static void Main(string[] args){
		Console.Write("Enter value of a: ");
		double a = Convert.ToDouble(Console.ReadLine()); //taking value of a from user
		Console.Write("Enter value of b: ");
		double b = Convert.ToDouble(Console.ReadLine()); //taking value of b from user
		Console.Write("Enter value of c: ");
		double c = Convert.ToDouble(Console.ReadLine()); //taking value of c from user
		double oper1 =  a + b * c;	//double operation 1
		double oper2 = a * b + c;	//double operation 2
		double oper3 = c + a / b;	//double operation 3
		double oper4 = a % b + c;	//double operation 4
		Console.WriteLine("The results of Int Operations are {0}, {1}, {2} and {3}",oper1,oper2,oper3,oper4);
	}
}