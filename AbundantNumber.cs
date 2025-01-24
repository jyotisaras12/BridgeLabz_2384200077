using System;
class AbundantNumber{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		int sum = 0;
		for(int i = 1; i <= num-1; i++){	//iterating from 1 to num to check factors
			if(num % i == 0){	//checking for factor
				sum += i;	//printing the factor
				continue;
			}
		}
		if(sum > num) Console.WriteLine("{0} is an Abundant Number",num);
		else Console.WriteLine("{0} is not an Abundant Number",num);
	}
}
			