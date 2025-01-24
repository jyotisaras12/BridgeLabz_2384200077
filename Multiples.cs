using System;
class Multiples{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
			for(int i = 100; i >= 1; i--){	//iterating from 100 to 1 to check multiples
				if(i % num == 0){	//checking for multiple
					Console.WriteLine(i);	//printing the multiple
					continue;
				}
			}
	}
}
			