using System;
class GCDAndLCMCalculator{
    //method to calculate GCD
    public static int CalculateGCD(int num1, int num2){
        while(num2 != 0){
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }

    //method to calculate LCM
    public static int CalculateLCM(int num1, int num2){
        return (num1 * num2) / CalculateGCD(num1, num2);	//LCM(a, b) = (a * b) / GCD(a, b)
    }

	//method to take input from user
	public static int UserInput(){
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		return n;
	}
	
    //Main method
    public static void Main(string[] args){
        //calling 'UserInput' method to take input from the user
		int n1 = UserInput();
		int n2 = UserInput();

        //calculating GCD and LCM using 'CalculateGCD()' and 'CalculateLCM' method
        int gcd = CalculateGCD(n1, n2);
        int lcm = CalculateLCM(n1, n2);

        //printing the results
        Console.WriteLine("The Greatest Common Divisor(GCD) of {0} and {1} is: {2}",n1, n2, gcd);
        Console.WriteLine("The Least Common Multiple (LCM) of {0} and {1} is: {2}",n1, n2, lcm);
    }
}
