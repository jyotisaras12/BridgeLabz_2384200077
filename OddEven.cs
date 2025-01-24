using System;
class OddEven{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		if(num > 0){	//checking the number is natural number
			for(int i = 1; i <= num; i++){	//iterating values from 1 to num
				if(i % 2 == 0){	//checking if num is even
					Console.WriteLine("{0} : Even",i);	//printing even numbers
				}
				else if(i % 2 == 1){	//checking if num is odd
					Console.WriteLine("{0} : Odd",i);	//printing odd numbers
				}
			}
		}
		else{	//not a natural number
			Console.WriteLine("Not a natural number!");
		}
	}
}
			