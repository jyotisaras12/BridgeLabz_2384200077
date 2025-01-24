using System;
class Counter{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		while (num >= 1){	//condition for the loop
			Console.WriteLine(num);
			num -= 1;	//decrementing the value of num by 1
		}
	}
}