using System;
class FizzBuzzArray{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		string[] result = new string[num+1];
		if(num > 0){	//checking the number is positive
			for(int i = 0; i <= num; i++){	//iterating from 0 to number entered by user
				if(i % 3 == 0 && i % 5 == 0){	//checking if number is divisible by both 3 and 5
					result[i] = "FizzBuzz";	//printing FizzBuzz
				}
				else if(i % 3 == 0){	//checking if number is divisible by 3
					result[i] = "Fizz";	//printing Fizz
				}
				else if(i % 5 == 0){	//checking if number is divisible by 5
					result[i] = "Buzz";	//printing Buzz
				}
				else{
					result[i] = i.ToString();	//printing the number
				}
			}
		}
		else Console.WriteLine("Not a positive integer!");
		for(int j = 0; j <= num; j++){
			Console.WriteLine("Position {0} : {1}",j,result[j]);
		}
	}
}