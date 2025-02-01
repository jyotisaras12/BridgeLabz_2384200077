using System;
class PrimeCheck{
	//method to check if a number is prime or not
	public static bool IsPrime(int num){
		if(num<=1) return false;	//numbers <= 1 are not prime
		for(int i=2;i<=Math.Pow(num,0.5);i++){
			if(num%i==0)	//checking for factors
				return false;
		}
		return true;	//if no factor exists other than 1 and number itself, then return true
	}
	
	//method to take input from user
	public static int UserInput(){
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		return n;
	}
	
	//method to print whether a number is prime or not
	public static void DisplayPrimeCheck(bool result){
		if(result) Console.WriteLine("Prime number");
		else Console.WriteLine("Non-prime number");
	}
	
	//Main method
	static void Main(String[] args){
		//calling 'UserInput' method to take input from the user
		int num = UserInput();
		
		//printing the result using 'IsPrime()' and 'DisplayPrimeCheck()' method
		bool isPrime = IsPrime(num);
		DisplayPrimeCheck(isPrime);
	}
}
