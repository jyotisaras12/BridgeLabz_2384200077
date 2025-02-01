using System;
class NumberChecker4{
    //method to check prime number
    public static bool IsPrime(int number){
        if(number <= 1) return false;
        for(int i = 2; i <= Math.Sqrt(number); i++){
            if(number % i == 0) return false;
        }
        return true;
    }

    //method to check neon number
    public static bool IsNeonNumber(int number){
        int square = number * number;
        int sumOfDigits = 0;

        while(square > 0){
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    //method to check spy number
    public static bool IsSpyNumber(int number){
        int sum = 0, product = 1;
        int temp = number;

        while(temp > 0){
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }
		return sum == product;
    }

    //method to check automorphic number
    public static bool IsAutomorphicNumber(int number){
        int square = number * number;
        while(square > 0){
            if(square % 10 != number % 10) return false;
            square /= 10;
            number /= 10;
        }
        return true;
    }

    //method to check buzz number
    public static bool IsBuzzNumber(int number){
        return (number % 7 == 0 || number % 10 == 7);
    }

    //Main method
    static void Main(string[] args){
        //taking number as input from user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        //checking if the number is prime
        bool isPrime = IsPrime(num);
        Console.WriteLine("Is Prime: {0}",isPrime);

        //checking if the number is a neon number
        bool isNeon = IsNeonNumber(num);
        Console.WriteLine("Is Neon Number: {0}",isNeon);

        //checking if the number is a spy number
        bool isSpy = IsSpyNumber(num);
        Console.WriteLine("Is Spy Number: {0}",isSpy);

        //checking if the number is an automorphic number
        bool isAutomorphic = IsAutomorphicNumber(num);
        Console.WriteLine("Is Automorphic Number: {0}",isAutomorphic);

        //checking if the number is a buzz number
        bool isBuzz = IsBuzzNumber(num);
        Console.WriteLine("Is Buzz Number: {0}",isBuzz);
    }
}
