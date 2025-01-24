using System;
class CounterForLoop{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		for(int i = num; i >= 1; i--){	//condition for the loop
			Console.WriteLine(i);
		}
	}
}