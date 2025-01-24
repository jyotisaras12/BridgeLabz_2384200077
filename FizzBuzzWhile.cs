using System;
class FizzBuzzWhile{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int i = 0;
		if(num > 0){	//checking the number is positive
			while(i <= num){	//iterating for values from 0 to num
				if(i % 3 == 0 && i % 5 == 0){	//checking if number is divisible by both 3 and 5
					Console.WriteLine("FizzBuzz");	//printing FizzBuzz
				}
				else if(i % 3 == 0){	//checking if number is divisible by 3
					Console.WriteLine("Fizz");	//printing Fizz
				}
				else if(i % 5 == 0){	//checking if number is divisible by 5
					Console.WriteLine("Buzz");	//printing Buzz
				}
				else{
					Console.WriteLine(i);	//printing the number
				}
				i++;
			}
		}
	}
}
			