using System;
class NumberSign{
	static void Main(string[] args){
		//creating 'nums' array of size 5
		int[] nums = new int[5];	
		
		//iterating from 0 to the largest index of array
		for(int i = 0; i < nums.Length; i++){	
			Console.Write("Enter number {0}: ",i+1);	
			//taking numbers as input from user
			nums[i] = Convert.ToInt32(Console.ReadLine());	
		}
		//iterating through array to check positive, negative or zero
		foreach(int num in nums){	
			if(num>0){	//checking positive number
				if(num % 2 == 0) Console.WriteLine("{0} is positive and even.",num);	//checking even number and printing the output
				else Console.WriteLine("{0} is positive and odd.",num);	//checking odd number
			}
			else if (num < 0) Console.WriteLine("{0} is negative.",num);	//checking negative number
			else Console.WriteLine("{0} is zero.",num);	//number is zero
		}
	}
}