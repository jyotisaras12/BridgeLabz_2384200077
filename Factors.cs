using System;
class Factors{
	//method to find factors of a number and store in array
	public static int[] CalculateFactors(int number){
		int count = 0;	//counter variable for factors
		for(int i = 1; i <= number; i++){	//iterating from 1 to num to check factors
			if(number % i == 0){	//checking for factor
				count++;	//incrementing the counter
			}
		}
		//creating a 'factors' array to store the factors of a number
		int[] factors = new int[count];	
		int index = 0;	//counter for index
		for(int i = 1; i <= number; i++){	//iterating from 1 to num to check factors
			if(number % i == 0){	//checking for factor
				factors[index] = i;	//storing the factor in array
				index++;	//incrementing the counter
			}
		}
		return factors;	//returning the array
	}
	
	//method to find the sum of the factors using factors array	
	public static int CalculateSum(int[] factors){
		int sum = 0;	//variable to store the sum of factors
		//iterating through the array of factors to calculate the sum
		foreach(int factor in factors){	
			sum += factor;	//calculation of sum of factors
		}
		return sum;	//returning the sum
	}
	
	//method to find the product of the factors using factors array
	public static int CalculateProduct(int[] factors){
		int product = 1;	//variable to store the product of factors
		//iterating through the array of factors to calculate the product
		foreach(int factor in factors){
			product *= factor;	//calculation of product of factors
		}
		return product;	//returning the product
	}
	
	//method to find the sum of square of the factors using Math.Pow() method
	public static double CalculateSumOfSquare(int[] factors){
		double sumOfSquare = 0.0;	//variable to store the sum of squares of factors
		//iterating through the array of factors to calculate the sum of squares
		foreach(int factor in factors){
			sumOfSquare += Math.Pow(factor,2);	//calculation of sum of squares of factors
		}
		return sumOfSquare;	//returning the sum of squares
	}
	
	//Main method
	static void Main(string[] args){
		//taking number as input from user
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	
		
		//finding the factors
		int[] fact = CalculateFactors(num);
		
		//finding the sum, product, sum of squares of factors
		int sumOfFactors = CalculateSum(fact);
		int productOfFactors = CalculateProduct(fact);
		double sumOfSquaresOfFactors = CalculateSumOfSquare(fact);
		
		//printing the result
		Console.WriteLine("The factors of {0} are: ",num);
		foreach(int f in fact){
			Console.Write(f+" ");
		}
		Console.WriteLine();
		Console.WriteLine("Sum of factors is: "+sumOfFactors);
		Console.WriteLine("Product of factors is: "+productOfFactors);
		Console.WriteLine("Sum of square of factors is: "+sumOfSquaresOfFactors);
	}
}
			