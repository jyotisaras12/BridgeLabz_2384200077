using System;
class OddAndEvenArray{
	static void Main(string[] args){
		Console.Write("Enter a number: ");
		//taking a number as input from user
		int num = Convert.ToInt32(Console.ReadLine());
		
		if(num < 0){	//checking if num is not a natural number
			Console.Error.WriteLine("Not a natural number!");	//showing error message
			Environment.Exit(0);	//exiting the program
		}
		//creating array 'oddArray' of size num/2+1 to store odd numbers
		int[] oddArray = new int[num/2+1];	
		//creating array 'evenArray' of size num/2+1 to store even numbers
		int[] evenArray = new int[num/2+1];	
		
		int oddIndex = 0;	//variable to count index of oddArray
		int evenIndex = 0;	//variable to count index of evenArray
		
		//iterating from 0 to num to check odd and even
		for(int i = 1; i <= num; i++){	
			if(i % 2 == 0){	//checking even numbers
				evenArray[evenIndex] = i;
				evenIndex++;	//index counter for even numbers
			}
			else if(i % 2 == 1){	//checking odd numbers
				oddArray[oddIndex] = i;
				oddIndex++;	//index counter for odd numbers
			}
		}
		//printing odd numbers from OddArray
		Console.WriteLine("The odd numbers are: ");
		for(int i = 0;i < oddIndex; i++){
			Console.WriteLine(oddArray[i]);
		}
		//printing even numbers from evenArray
		Console.WriteLine("The even numbers are: ");
		for(int i = 0; i < evenIndex; i++){
			Console.WriteLine(evenArray[i]);
		}
	}
}