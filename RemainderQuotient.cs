using System;
class RemainderQuotient{
	//method to find remainder and quotient
	public static int[] FindRemainderAndQuotient(int number, int divisor){
		int quot = number / divisor;	//quotient
		int rem = number % divisor;	//remainder
		return new int[]{quot,rem};	//returning the result as an array
	}
	//Main method
	static void Main(string[] args){
		//taking number as input from user
		Console.Write("Enter number: ");
		int num = Convert.ToInt32(Console.ReadLine()); 
		//taking second number as input from user
		Console.Write("Enter divisor: ");
		int div = Convert.ToInt32(Console.ReadLine()); 
		
		//calling the 'FindRemainderAndQuotient' method to find quotient and remainder
        int[] result = FindRemainderAndQuotient(num,div);
			
		//printing the remainder and quotient using result
		Console.WriteLine("Quotient is: "+result[0]);
		Console.WriteLine("Remainder is: "+result[1]);
	}
}